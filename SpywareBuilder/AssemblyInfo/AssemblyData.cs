using System;

namespace SpywareBuilder.AssemblyInfo
{
    public class AssemblyData : EventArgs
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Product { get; set; }
        public string Company { get; set; }
        public string Copyrith { get; set; }
        public string MajorNumber { get; set; }
        public string MinorNumber { get; set; }
        public string BuildNumber { get; set; }

        public AssemblyData(string majorVersion = "1", string minorVersion = "0", string buildNumber = "0")
        {

        }
    }
}
