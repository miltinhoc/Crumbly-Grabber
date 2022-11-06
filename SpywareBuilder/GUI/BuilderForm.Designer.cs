namespace SpywareBuilder.GUI
{
    partial class BuilderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuilderForm));
            this.GroupBoxIcon = new System.Windows.Forms.GroupBox();
            this.IconPreview = new System.Windows.Forms.PictureBox();
            this.GroupBoxDiscord = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtWebhook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuild = new System.Windows.Forms.Button();
            this.BtnAssemblyConfig = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BwBuild = new System.ComponentModel.BackgroundWorker();
            this.PictureBuilding = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBrowseOutputFolder = new System.Windows.Forms.Button();
            this.TxtOutputFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PluginsGroupBox = new System.Windows.Forms.GroupBox();
            this.BtnAddPlugin = new System.Windows.Forms.Button();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.CheckBoxWifi = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.GroupBoxIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPreview)).BeginInit();
            this.GroupBoxDiscord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBuilding)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PluginsGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxIcon
            // 
            this.GroupBoxIcon.Controls.Add(this.IconPreview);
            this.GroupBoxIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GroupBoxIcon.Location = new System.Drawing.Point(474, 28);
            this.GroupBoxIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBoxIcon.Name = "GroupBoxIcon";
            this.GroupBoxIcon.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBoxIcon.Size = new System.Drawing.Size(99, 107);
            this.GroupBoxIcon.TabIndex = 0;
            this.GroupBoxIcon.TabStop = false;
            this.GroupBoxIcon.Text = "Icon";
            // 
            // IconPreview
            // 
            this.IconPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconPreview.Location = new System.Drawing.Point(9, 19);
            this.IconPreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IconPreview.Name = "IconPreview";
            this.IconPreview.Size = new System.Drawing.Size(80, 80);
            this.IconPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconPreview.TabIndex = 2;
            this.IconPreview.TabStop = false;
            this.toolTip1.SetToolTip(this.IconPreview, "Click to choose an icon");
            this.IconPreview.Click += new System.EventHandler(this.IconPreview_Click);
            // 
            // GroupBoxDiscord
            // 
            this.GroupBoxDiscord.Controls.Add(this.pictureBox1);
            this.GroupBoxDiscord.Controls.Add(this.TxtWebhook);
            this.GroupBoxDiscord.Controls.Add(this.label1);
            this.GroupBoxDiscord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GroupBoxDiscord.Location = new System.Drawing.Point(13, 16);
            this.GroupBoxDiscord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBoxDiscord.Name = "GroupBoxDiscord";
            this.GroupBoxDiscord.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBoxDiscord.Size = new System.Drawing.Size(453, 64);
            this.GroupBoxDiscord.TabIndex = 1;
            this.GroupBoxDiscord.TabStop = false;
            this.GroupBoxDiscord.Text = "Discord Configuration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = global::SpywareBuilder.Properties.Resources.icons8_help_96;
            this.pictureBox1.Location = new System.Drawing.Point(428, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Discord webhook url. Used for the spyware to send files and messages back to disc" +
        "ord.");
            // 
            // TxtWebhook
            // 
            this.TxtWebhook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TxtWebhook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtWebhook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtWebhook.Location = new System.Drawing.Point(90, 27);
            this.TxtWebhook.Name = "TxtWebhook";
            this.TxtWebhook.Size = new System.Drawing.Size(333, 21);
            this.TxtWebhook.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Webhook:";
            // 
            // BtnBuild
            // 
            this.BtnBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBuild.Location = new System.Drawing.Point(498, 316);
            this.BtnBuild.Name = "BtnBuild";
            this.BtnBuild.Size = new System.Drawing.Size(75, 23);
            this.BtnBuild.TabIndex = 4;
            this.BtnBuild.Text = "Build";
            this.BtnBuild.UseVisualStyleBackColor = true;
            this.BtnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // BtnAssemblyConfig
            // 
            this.BtnAssemblyConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAssemblyConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAssemblyConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAssemblyConfig.Location = new System.Drawing.Point(348, 316);
            this.BtnAssemblyConfig.Name = "BtnAssemblyConfig";
            this.BtnAssemblyConfig.Size = new System.Drawing.Size(144, 23);
            this.BtnAssemblyConfig.TabIndex = 3;
            this.BtnAssemblyConfig.Text = "Assembly Information";
            this.BtnAssemblyConfig.UseVisualStyleBackColor = true;
            this.BtnAssemblyConfig.Click += new System.EventHandler(this.BtnAssemblyConfig_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // BwBuild
            // 
            this.BwBuild.WorkerReportsProgress = true;
            this.BwBuild.WorkerSupportsCancellation = true;
            this.BwBuild.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwBuild_DoWork);
            this.BwBuild.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwBuild_RunWorkerCompleted);
            // 
            // PictureBuilding
            // 
            this.PictureBuilding.Image = global::SpywareBuilder.Properties.Resources.Spin_1s_23px__1_1;
            this.PictureBuilding.Location = new System.Drawing.Point(319, 316);
            this.PictureBuilding.Name = "PictureBuilding";
            this.PictureBuilding.Size = new System.Drawing.Size(23, 23);
            this.PictureBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBuilding.TabIndex = 14;
            this.PictureBuilding.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBrowseOutputFolder);
            this.groupBox1.Controls.Add(this.TxtOutputFolder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(15, 250);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(558, 60);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // BtnBrowseOutputFolder
            // 
            this.BtnBrowseOutputFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBrowseOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowseOutputFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBrowseOutputFolder.Location = new System.Drawing.Point(507, 22);
            this.BtnBrowseOutputFolder.Name = "BtnBrowseOutputFolder";
            this.BtnBrowseOutputFolder.Size = new System.Drawing.Size(39, 23);
            this.BtnBrowseOutputFolder.TabIndex = 15;
            this.BtnBrowseOutputFolder.Text = "...";
            this.BtnBrowseOutputFolder.UseVisualStyleBackColor = true;
            this.BtnBrowseOutputFolder.Click += new System.EventHandler(this.BtnBrowseOutputFolder_Click);
            // 
            // TxtOutputFolder
            // 
            this.TxtOutputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.TxtOutputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOutputFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxtOutputFolder.Location = new System.Drawing.Point(60, 24);
            this.TxtOutputFolder.Name = "TxtOutputFolder";
            this.TxtOutputFolder.Size = new System.Drawing.Size(441, 21);
            this.TxtOutputFolder.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Folder:";
            // 
            // PluginsGroupBox
            // 
            this.PluginsGroupBox.Controls.Add(this.BtnAddPlugin);
            this.PluginsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PluginsGroupBox.Location = new System.Drawing.Point(13, 86);
            this.PluginsGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PluginsGroupBox.Name = "PluginsGroupBox";
            this.PluginsGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PluginsGroupBox.Size = new System.Drawing.Size(453, 61);
            this.PluginsGroupBox.TabIndex = 5;
            this.PluginsGroupBox.TabStop = false;
            this.PluginsGroupBox.Text = "Plugins";
            // 
            // BtnAddPlugin
            // 
            this.BtnAddPlugin.Enabled = false;
            this.BtnAddPlugin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPlugin.Location = new System.Drawing.Point(12, 23);
            this.BtnAddPlugin.Name = "BtnAddPlugin";
            this.BtnAddPlugin.Size = new System.Drawing.Size(83, 23);
            this.BtnAddPlugin.TabIndex = 0;
            this.BtnAddPlugin.Text = "Add";
            this.BtnAddPlugin.UseVisualStyleBackColor = true;
            this.BtnAddPlugin.Click += new System.EventHandler(this.button1_Click);
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.CheckBoxWifi);
            this.OptionsGroupBox.Controls.Add(this.checkBox2);
            this.OptionsGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OptionsGroupBox.Location = new System.Drawing.Point(13, 153);
            this.OptionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OptionsGroupBox.Size = new System.Drawing.Size(560, 91);
            this.OptionsGroupBox.TabIndex = 6;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // CheckBoxWifi
            // 
            this.CheckBoxWifi.AutoSize = true;
            this.CheckBoxWifi.Location = new System.Drawing.Point(12, 50);
            this.CheckBoxWifi.Name = "CheckBoxWifi";
            this.CheckBoxWifi.Size = new System.Drawing.Size(141, 17);
            this.CheckBoxWifi.TabIndex = 2;
            this.CheckBoxWifi.Text = "Grab wifi passwords";
            this.CheckBoxWifi.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(12, 27);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(173, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Check for Virtual Machine";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // BuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(585, 351);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.PluginsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PictureBuilding);
            this.Controls.Add(this.BtnAssemblyConfig);
            this.Controls.Add(this.BtnBuild);
            this.Controls.Add(this.GroupBoxDiscord);
            this.Controls.Add(this.GroupBoxIcon);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "BuilderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crumbly Builder v1.0";
            this.Load += new System.EventHandler(this.BuilderForm_Load);
            this.GroupBoxIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPreview)).EndInit();
            this.GroupBoxDiscord.ResumeLayout(false);
            this.GroupBoxDiscord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBuilding)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PluginsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxIcon;
        private System.Windows.Forms.GroupBox GroupBoxDiscord;
        private System.Windows.Forms.PictureBox IconPreview;
        private System.Windows.Forms.TextBox TxtWebhook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBuild;
        private System.Windows.Forms.Button BtnAssemblyConfig;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker BwBuild;
        private System.Windows.Forms.PictureBox PictureBuilding;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtOutputFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnBrowseOutputFolder;
        private System.Windows.Forms.GroupBox PluginsGroupBox;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BtnAddPlugin;
        private System.Windows.Forms.CheckBox CheckBoxWifi;
    }
}

