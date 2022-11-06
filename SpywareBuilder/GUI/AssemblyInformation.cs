using SpywareBuilder.AssemblyInfo;
using System;
using System.Windows.Forms;

namespace SpywareBuilder.GUI
{
    public partial class AssemblyInformation : Form
    {
        public event EventHandler AssemblyInformationSaved;
        public AssemblyData assemblyData;

        public AssemblyInformation(AssemblyData assemblyData)
        {
            this.assemblyData = assemblyData;
            InitializeComponent();

            FillData();
        }

        private void FillData()
        {
            TxtTitle.Text = assemblyData.Title;
            TxtDescription.Text = assemblyData.Description;
            TxtProduct.Text = assemblyData.Product;
            TxtCompany.Text = assemblyData.Company;
            TxtCopyright.Text = assemblyData.Copyrith;
            TxtMajorNumber.Text = assemblyData.MajorNumber;
            TxtMinorNumber.Text = assemblyData.MinorNumber;
            TxtBuildNumber.Text = assemblyData.BuildNumber;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            AssemblyData assemblyData = new AssemblyData
            {
                Title = TxtTitle.Text,
                Description = TxtDescription.Text,
                Product = TxtProduct.Text,
                Company = TxtCompany.Text,
                Copyrith = TxtCopyright.Text,
                MajorNumber = TxtMajorNumber.Text,
                MinorNumber = TxtMinorNumber.Text,
                BuildNumber = TxtBuildNumber.Text
            };

            AssemblyInformationSaved?.Invoke(this, assemblyData);
            this.Close();
        }
    }
}
