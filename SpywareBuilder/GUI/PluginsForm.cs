using System;
using System.Windows.Forms;

namespace SpywareBuilder.GUI
{
    public partial class PluginsForm : Form
    {
        public PluginsForm()
        {
            InitializeComponent();
        }

        private void indentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = fastColoredTextBox1.Text.Trim();

            for (int i = 0; i < fastColoredTextBox1.LinesCount; i++)
            {
                fastColoredTextBox1.DoAutoIndent(i);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
