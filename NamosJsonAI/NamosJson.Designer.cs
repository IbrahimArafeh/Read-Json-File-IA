namespace NamosJsonAI
{
    partial class NamosJson
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.txtPathJsonFile = new MetroFramework.Controls.MetroTextBox();
            this.btnUploadJsonFile = new MetroFramework.Controls.MetroTile();
            this.titleOpenJsonFile = new MetroFramework.Controls.MetroTile();
            this.btnBrowseJsonFile = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(67, 227);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(129, 85);
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "Duplicate File";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(67, 328);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(319, 85);
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Text = "Restore Original file";
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // txtPathJsonFile
            // 
            // 
            // 
            // 
            this.txtPathJsonFile.CustomButton.Image = null;
            this.txtPathJsonFile.CustomButton.Location = new System.Drawing.Point(350, 1);
            this.txtPathJsonFile.CustomButton.Name = "";
            this.txtPathJsonFile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPathJsonFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPathJsonFile.CustomButton.TabIndex = 1;
            this.txtPathJsonFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPathJsonFile.CustomButton.UseSelectable = true;
            this.txtPathJsonFile.CustomButton.Visible = false;
            this.txtPathJsonFile.Lines = new string[0];
            this.txtPathJsonFile.Location = new System.Drawing.Point(23, 84);
            this.txtPathJsonFile.MaxLength = 32767;
            this.txtPathJsonFile.Name = "txtPathJsonFile";
            this.txtPathJsonFile.PasswordChar = '\0';
            this.txtPathJsonFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPathJsonFile.SelectedText = "";
            this.txtPathJsonFile.SelectionLength = 0;
            this.txtPathJsonFile.SelectionStart = 0;
            this.txtPathJsonFile.ShortcutsEnabled = true;
            this.txtPathJsonFile.Size = new System.Drawing.Size(372, 23);
            this.txtPathJsonFile.TabIndex = 0;
            this.txtPathJsonFile.UseSelectable = true;
            this.txtPathJsonFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPathJsonFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUploadJsonFile
            // 
            this.btnUploadJsonFile.ActiveControl = null;
            this.btnUploadJsonFile.Location = new System.Drawing.Point(213, 127);
            this.btnUploadJsonFile.Name = "btnUploadJsonFile";
            this.btnUploadJsonFile.Size = new System.Drawing.Size(173, 185);
            this.btnUploadJsonFile.TabIndex = 3;
            this.btnUploadJsonFile.Text = "Open Json File";
            this.btnUploadJsonFile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUploadJsonFile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnUploadJsonFile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnUploadJsonFile.UseSelectable = true;
            this.btnUploadJsonFile.UseTileImage = true;
            this.btnUploadJsonFile.Click += new System.EventHandler(this.btnUploadJsonFile_Click);
            // 
            // titleOpenJsonFile
            // 
            this.titleOpenJsonFile.ActiveControl = null;
            this.titleOpenJsonFile.Location = new System.Drawing.Point(67, 127);
            this.titleOpenJsonFile.Name = "titleOpenJsonFile";
            this.titleOpenJsonFile.Size = new System.Drawing.Size(129, 94);
            this.titleOpenJsonFile.TabIndex = 2;
            this.titleOpenJsonFile.Text = "Update Json";
            this.titleOpenJsonFile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleOpenJsonFile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.titleOpenJsonFile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.titleOpenJsonFile.UseSelectable = true;
            this.titleOpenJsonFile.UseTileImage = true;
            this.titleOpenJsonFile.Click += new System.EventHandler(this.titleOpenJsonFile_Click);
            // 
            // btnBrowseJsonFile
            // 
            this.btnBrowseJsonFile.Location = new System.Drawing.Point(401, 84);
            this.btnBrowseJsonFile.Name = "btnBrowseJsonFile";
            this.btnBrowseJsonFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseJsonFile.TabIndex = 1;
            this.btnBrowseJsonFile.Text = "Browse";
            this.btnBrowseJsonFile.UseSelectable = true;
            this.btnBrowseJsonFile.Click += new System.EventHandler(this.btnBrowseJsonFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NamosJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 442);
            this.Controls.Add(this.btnBrowseJsonFile);
            this.Controls.Add(this.txtPathJsonFile);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.btnUploadJsonFile);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.titleOpenJsonFile);
            this.Name = "NamosJson";
            this.Text = "NamosJson";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile titleOpenJsonFile;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        public MetroFramework.Controls.MetroTile btnUploadJsonFile;
        private MetroFramework.Controls.MetroTextBox txtPathJsonFile;
        private MetroFramework.Controls.MetroButton btnBrowseJsonFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}