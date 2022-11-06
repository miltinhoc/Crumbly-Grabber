using System;
using System.IO;

namespace SpywareBuilder.AssemblyInfo
{
    public class AssemblyInformationBuilder
    {
        private string TemplateContent;
        private readonly string FileName = "AssemblyInfo.cs";

        public AssemblyInformationBuilder()
        {
            TemplateContent = Properties.Resources.AssemblyInfo_Temp;
        }

        public void BuildAssembly(AssemblyData assemblyData)
        {
            TemplateContent = TemplateContent.Replace("%TITLE%", assemblyData.Title);
            TemplateContent = TemplateContent.Replace("%DESCRIPTION%", assemblyData.Description);
            TemplateContent = TemplateContent.Replace("%PRODUCT%", assemblyData.Product);
            TemplateContent = TemplateContent.Replace("%COMPANY%", assemblyData.Company);
            TemplateContent = TemplateContent.Replace("%COPYRIGHT%", assemblyData.Copyrith);
        }

        public void SaveAssembly(string path)
        {
            try
            {
                File.WriteAllText(Path.Combine(path, FileName), TemplateContent);
            }
            catch (Exception)
            {

            }
        }
    }
}
