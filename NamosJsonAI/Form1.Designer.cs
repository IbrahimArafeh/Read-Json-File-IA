namespace NamosJsonAI
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlSettings = new MetroFramework.Controls.MetroTabControl();
            this.tabConnection = new MetroFramework.Controls.MetroTabPage();
            this.txtMaxPOSCount = new MetroFramework.Controls.MetroTextBox();
            this.lblMaxPOSCount = new MetroFramework.Controls.MetroLabel();
            this.txtReplicationArticleCount = new MetroFramework.Controls.MetroTextBox();
            this.lblReplicationArticleCount = new MetroFramework.Controls.MetroLabel();
            this.txtPOSListFilePath = new MetroFramework.Controls.MetroTextBox();
            this.lblPOSListFilePath = new MetroFramework.Controls.MetroLabel();
            this.txtDSSJsonFilePath = new MetroFramework.Controls.MetroTextBox();
            this.lblDSSJsonFilePath = new MetroFramework.Controls.MetroLabel();
            this.txtHOConnectionString = new MetroFramework.Controls.MetroTextBox();
            this.lblHOConnectionString = new MetroFramework.Controls.MetroLabel();
            this.txtDailyCheckConnectionString = new MetroFramework.Controls.MetroTextBox();
            this.lblDailyCheckConnectionString = new MetroFramework.Controls.MetroLabel();
            this.tabSQL = new MetroFramework.Controls.MetroTabPage();
            this.btnDeleteScheduleTasks = new MetroFramework.Controls.MetroButton();
            this.gridScheduleTasks = new MetroFramework.Controls.MetroGrid();
            this.btnUpdateScheduleTasks = new MetroFramework.Controls.MetroButton();
            this.btnAddScheduleTasks = new MetroFramework.Controls.MetroButton();
            this.chkScheduleTasks = new MetroFramework.Controls.MetroCheckBox();
            this.txtLocation = new MetroFramework.Controls.MetroTextBox();
            this.txtExcludeSites = new MetroFramework.Controls.MetroTextBox();
            this.txtTaskName = new MetroFramework.Controls.MetroTextBox();
            this.tabServices = new MetroFramework.Controls.MetroTabPage();
            this.txtMasterFiles_POSServer = new MetroFramework.Controls.MetroTextBox();
            this.lblMasterFiles_POSServer = new MetroFramework.Controls.MetroLabel();
            this.txtMasterFiles_BOSServer = new MetroFramework.Controls.MetroTextBox();
            this.lblMasterFiles_BOSServer = new MetroFramework.Controls.MetroLabel();
            this.txtMaster_SCO_SQLServer = new MetroFramework.Controls.MetroTextBox();
            this.lblMaster_SCO_SQLServer = new MetroFramework.Controls.MetroLabel();
            this.txtMaster_BOS_SQLServer = new MetroFramework.Controls.MetroTextBox();
            this.lblMaster_BOS_SQLServer = new MetroFramework.Controls.MetroLabel();
            this.txtSCOConnectionString = new MetroFramework.Controls.MetroTextBox();
            this.lblSCOConnectionString = new MetroFramework.Controls.MetroLabel();
            this.txtBOSConnectionString = new MetroFramework.Controls.MetroTextBox();
            this.lblBOSConnectionString = new MetroFramework.Controls.MetroLabel();
            this.txtPOSConnectionString = new MetroFramework.Controls.MetroTextBox();
            this.lblPOSConnectionString = new MetroFramework.Controls.MetroLabel();
            this.txtMasterFiles_SCOServer = new MetroFramework.Controls.MetroTextBox();
            this.lblMasterFiles_SCOServer = new MetroFramework.Controls.MetroLabel();
            this.btnUpdateConnection = new MetroFramework.Controls.MetroButton();
            this.txtMasterNamosSTN = new MetroFramework.Controls.MetroTextBox();
            this.lblMasterNamosSTN = new MetroFramework.Controls.MetroLabel();
            this.lblTaskName = new MetroFramework.Controls.MetroLabel();
            this.lblLocation = new MetroFramework.Controls.MetroLabel();
            this.lblExcludeSites = new MetroFramework.Controls.MetroLabel();
            this.lblServicesExcludeSites = new MetroFramework.Controls.MetroLabel();
            this.lblServiceName = new MetroFramework.Controls.MetroLabel();
            this.lblServiceDisplay = new MetroFramework.Controls.MetroLabel();
            this.btnDeteteServices = new MetroFramework.Controls.MetroButton();
            this.gridServices = new MetroFramework.Controls.MetroGrid();
            this.btnUpdateServices = new MetroFramework.Controls.MetroButton();
            this.btnAddServices = new MetroFramework.Controls.MetroButton();
            this.chkServicesEnable = new MetroFramework.Controls.MetroCheckBox();
            this.txtServiceName = new MetroFramework.Controls.MetroTextBox();
            this.txtServicesLocation = new MetroFramework.Controls.MetroTextBox();
            this.txtServiceDisplay = new MetroFramework.Controls.MetroTextBox();
            this.lblServicesLocaiton = new MetroFramework.Controls.MetroLabel();
            this.txtServicesExcludeSites = new MetroFramework.Controls.MetroTextBox();
            this.tabControlSettings.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.tabSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridScheduleTasks)).BeginInit();
            this.tabServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabConnection);
            this.tabControlSettings.Controls.Add(this.tabSQL);
            this.tabControlSettings.Controls.Add(this.tabServices);
            this.tabControlSettings.Location = new System.Drawing.Point(23, 63);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 2;
            this.tabControlSettings.Size = new System.Drawing.Size(840, 502);
            this.tabControlSettings.TabIndex = 0;
            this.tabControlSettings.UseSelectable = true;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.txtMasterNamosSTN);
            this.tabConnection.Controls.Add(this.lblMasterNamosSTN);
            this.tabConnection.Controls.Add(this.btnUpdateConnection);
            this.tabConnection.Controls.Add(this.txtMasterFiles_SCOServer);
            this.tabConnection.Controls.Add(this.lblMasterFiles_SCOServer);
            this.tabConnection.Controls.Add(this.txtPOSConnectionString);
            this.tabConnection.Controls.Add(this.lblPOSConnectionString);
            this.tabConnection.Controls.Add(this.txtSCOConnectionString);
            this.tabConnection.Controls.Add(this.lblSCOConnectionString);
            this.tabConnection.Controls.Add(this.txtBOSConnectionString);
            this.tabConnection.Controls.Add(this.lblBOSConnectionString);
            this.tabConnection.Controls.Add(this.txtMasterFiles_POSServer);
            this.tabConnection.Controls.Add(this.lblMasterFiles_POSServer);
            this.tabConnection.Controls.Add(this.txtMasterFiles_BOSServer);
            this.tabConnection.Controls.Add(this.lblMasterFiles_BOSServer);
            this.tabConnection.Controls.Add(this.txtMaster_SCO_SQLServer);
            this.tabConnection.Controls.Add(this.lblMaster_SCO_SQLServer);
            this.tabConnection.Controls.Add(this.txtMaster_BOS_SQLServer);
            this.tabConnection.Controls.Add(this.lblMaster_BOS_SQLServer);
            this.tabConnection.Controls.Add(this.txtMaxPOSCount);
            this.tabConnection.Controls.Add(this.lblMaxPOSCount);
            this.tabConnection.Controls.Add(this.txtReplicationArticleCount);
            this.tabConnection.Controls.Add(this.lblReplicationArticleCount);
            this.tabConnection.Controls.Add(this.txtPOSListFilePath);
            this.tabConnection.Controls.Add(this.lblPOSListFilePath);
            this.tabConnection.Controls.Add(this.txtDSSJsonFilePath);
            this.tabConnection.Controls.Add(this.lblDSSJsonFilePath);
            this.tabConnection.Controls.Add(this.txtHOConnectionString);
            this.tabConnection.Controls.Add(this.lblHOConnectionString);
            this.tabConnection.Controls.Add(this.txtDailyCheckConnectionString);
            this.tabConnection.Controls.Add(this.lblDailyCheckConnectionString);
            this.tabConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConnection.HorizontalScrollbarBarColor = true;
            this.tabConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.tabConnection.HorizontalScrollbarSize = 10;
            this.tabConnection.Location = new System.Drawing.Point(4, 38);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Size = new System.Drawing.Size(832, 460);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connection";
            this.tabConnection.VerticalScrollbarBarColor = true;
            this.tabConnection.VerticalScrollbarHighlightOnWheel = false;
            this.tabConnection.VerticalScrollbarSize = 10;
            // 
            // txtMaxPOSCount
            // 
            // 
            // 
            // 
            this.txtMaxPOSCount.CustomButton.Image = null;
            this.txtMaxPOSCount.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtMaxPOSCount.CustomButton.Name = "";
            this.txtMaxPOSCount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMaxPOSCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxPOSCount.CustomButton.TabIndex = 1;
            this.txtMaxPOSCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxPOSCount.CustomButton.UseSelectable = true;
            this.txtMaxPOSCount.CustomButton.Visible = false;
            this.txtMaxPOSCount.Lines = new string[0];
            this.txtMaxPOSCount.Location = new System.Drawing.Point(193, 220);
            this.txtMaxPOSCount.MaxLength = 32767;
            this.txtMaxPOSCount.Name = "txtMaxPOSCount";
            this.txtMaxPOSCount.PasswordChar = '\0';
            this.txtMaxPOSCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxPOSCount.SelectedText = "";
            this.txtMaxPOSCount.SelectionLength = 0;
            this.txtMaxPOSCount.SelectionStart = 0;
            this.txtMaxPOSCount.ShortcutsEnabled = true;
            this.txtMaxPOSCount.Size = new System.Drawing.Size(198, 25);
            this.txtMaxPOSCount.TabIndex = 13;
            this.txtMaxPOSCount.UseSelectable = true;
            this.txtMaxPOSCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxPOSCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMaxPOSCount
            // 
            this.lblMaxPOSCount.AutoSize = true;
            this.lblMaxPOSCount.Location = new System.Drawing.Point(3, 220);
            this.lblMaxPOSCount.Name = "lblMaxPOSCount";
            this.lblMaxPOSCount.Size = new System.Drawing.Size(103, 19);
            this.lblMaxPOSCount.TabIndex = 12;
            this.lblMaxPOSCount.Text = "Max POS Count";
            // 
            // txtReplicationArticleCount
            // 
            // 
            // 
            // 
            this.txtReplicationArticleCount.CustomButton.Image = null;
            this.txtReplicationArticleCount.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtReplicationArticleCount.CustomButton.Name = "";
            this.txtReplicationArticleCount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtReplicationArticleCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReplicationArticleCount.CustomButton.TabIndex = 1;
            this.txtReplicationArticleCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReplicationArticleCount.CustomButton.UseSelectable = true;
            this.txtReplicationArticleCount.CustomButton.Visible = false;
            this.txtReplicationArticleCount.Lines = new string[0];
            this.txtReplicationArticleCount.Location = new System.Drawing.Point(193, 179);
            this.txtReplicationArticleCount.MaxLength = 32767;
            this.txtReplicationArticleCount.Name = "txtReplicationArticleCount";
            this.txtReplicationArticleCount.PasswordChar = '\0';
            this.txtReplicationArticleCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReplicationArticleCount.SelectedText = "";
            this.txtReplicationArticleCount.SelectionLength = 0;
            this.txtReplicationArticleCount.SelectionStart = 0;
            this.txtReplicationArticleCount.ShortcutsEnabled = true;
            this.txtReplicationArticleCount.Size = new System.Drawing.Size(198, 25);
            this.txtReplicationArticleCount.TabIndex = 11;
            this.txtReplicationArticleCount.UseSelectable = true;
            this.txtReplicationArticleCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReplicationArticleCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblReplicationArticleCount
            // 
            this.lblReplicationArticleCount.AutoSize = true;
            this.lblReplicationArticleCount.Location = new System.Drawing.Point(3, 179);
            this.lblReplicationArticleCount.Name = "lblReplicationArticleCount";
            this.lblReplicationArticleCount.Size = new System.Drawing.Size(154, 19);
            this.lblReplicationArticleCount.TabIndex = 10;
            this.lblReplicationArticleCount.Text = "Replication Article Count";
            // 
            // txtPOSListFilePath
            // 
            // 
            // 
            // 
            this.txtPOSListFilePath.CustomButton.Image = null;
            this.txtPOSListFilePath.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtPOSListFilePath.CustomButton.Name = "";
            this.txtPOSListFilePath.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPOSListFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPOSListFilePath.CustomButton.TabIndex = 1;
            this.txtPOSListFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPOSListFilePath.CustomButton.UseSelectable = true;
            this.txtPOSListFilePath.CustomButton.Visible = false;
            this.txtPOSListFilePath.Lines = new string[0];
            this.txtPOSListFilePath.Location = new System.Drawing.Point(193, 139);
            this.txtPOSListFilePath.MaxLength = 32767;
            this.txtPOSListFilePath.Name = "txtPOSListFilePath";
            this.txtPOSListFilePath.PasswordChar = '\0';
            this.txtPOSListFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPOSListFilePath.SelectedText = "";
            this.txtPOSListFilePath.SelectionLength = 0;
            this.txtPOSListFilePath.SelectionStart = 0;
            this.txtPOSListFilePath.ShortcutsEnabled = true;
            this.txtPOSListFilePath.Size = new System.Drawing.Size(198, 25);
            this.txtPOSListFilePath.TabIndex = 9;
            this.txtPOSListFilePath.UseSelectable = true;
            this.txtPOSListFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPOSListFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPOSListFilePath
            // 
            this.lblPOSListFilePath.AutoSize = true;
            this.lblPOSListFilePath.Location = new System.Drawing.Point(3, 139);
            this.lblPOSListFilePath.Name = "lblPOSListFilePath";
            this.lblPOSListFilePath.Size = new System.Drawing.Size(110, 19);
            this.lblPOSListFilePath.TabIndex = 8;
            this.lblPOSListFilePath.Text = "POS List File Path";
            // 
            // txtDSSJsonFilePath
            // 
            // 
            // 
            // 
            this.txtDSSJsonFilePath.CustomButton.Image = null;
            this.txtDSSJsonFilePath.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtDSSJsonFilePath.CustomButton.Name = "";
            this.txtDSSJsonFilePath.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDSSJsonFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDSSJsonFilePath.CustomButton.TabIndex = 1;
            this.txtDSSJsonFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDSSJsonFilePath.CustomButton.UseSelectable = true;
            this.txtDSSJsonFilePath.CustomButton.Visible = false;
            this.txtDSSJsonFilePath.Lines = new string[0];
            this.txtDSSJsonFilePath.Location = new System.Drawing.Point(193, 103);
            this.txtDSSJsonFilePath.MaxLength = 32767;
            this.txtDSSJsonFilePath.Name = "txtDSSJsonFilePath";
            this.txtDSSJsonFilePath.PasswordChar = '\0';
            this.txtDSSJsonFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDSSJsonFilePath.SelectedText = "";
            this.txtDSSJsonFilePath.SelectionLength = 0;
            this.txtDSSJsonFilePath.SelectionStart = 0;
            this.txtDSSJsonFilePath.ShortcutsEnabled = true;
            this.txtDSSJsonFilePath.Size = new System.Drawing.Size(198, 25);
            this.txtDSSJsonFilePath.TabIndex = 7;
            this.txtDSSJsonFilePath.UseSelectable = true;
            this.txtDSSJsonFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDSSJsonFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDSSJsonFilePath
            // 
            this.lblDSSJsonFilePath.AutoSize = true;
            this.lblDSSJsonFilePath.Location = new System.Drawing.Point(3, 103);
            this.lblDSSJsonFilePath.Name = "lblDSSJsonFilePath";
            this.lblDSSJsonFilePath.Size = new System.Drawing.Size(114, 19);
            this.lblDSSJsonFilePath.TabIndex = 6;
            this.lblDSSJsonFilePath.Text = "DSS Json File Path";
            // 
            // txtHOConnectionString
            // 
            // 
            // 
            // 
            this.txtHOConnectionString.CustomButton.Image = null;
            this.txtHOConnectionString.CustomButton.Location = new System.Drawing.Point(601, 1);
            this.txtHOConnectionString.CustomButton.Name = "";
            this.txtHOConnectionString.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtHOConnectionString.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHOConnectionString.CustomButton.TabIndex = 1;
            this.txtHOConnectionString.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHOConnectionString.CustomButton.UseSelectable = true;
            this.txtHOConnectionString.CustomButton.Visible = false;
            this.txtHOConnectionString.Lines = new string[0];
            this.txtHOConnectionString.Location = new System.Drawing.Point(193, 65);
            this.txtHOConnectionString.MaxLength = 32767;
            this.txtHOConnectionString.Multiline = true;
            this.txtHOConnectionString.Name = "txtHOConnectionString";
            this.txtHOConnectionString.PasswordChar = '\0';
            this.txtHOConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHOConnectionString.SelectedText = "";
            this.txtHOConnectionString.SelectionLength = 0;
            this.txtHOConnectionString.SelectionStart = 0;
            this.txtHOConnectionString.ShortcutsEnabled = true;
            this.txtHOConnectionString.Size = new System.Drawing.Size(625, 25);
            this.txtHOConnectionString.TabIndex = 5;
            this.txtHOConnectionString.UseSelectable = true;
            this.txtHOConnectionString.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHOConnectionString.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblHOConnectionString
            // 
            this.lblHOConnectionString.AutoSize = true;
            this.lblHOConnectionString.Location = new System.Drawing.Point(3, 65);
            this.lblHOConnectionString.Name = "lblHOConnectionString";
            this.lblHOConnectionString.Size = new System.Drawing.Size(137, 19);
            this.lblHOConnectionString.TabIndex = 4;
            this.lblHOConnectionString.Text = "HO Connection String";
            // 
            // txtDailyCheckConnectionString
            // 
            // 
            // 
            // 
            this.txtDailyCheckConnectionString.CustomButton.Image = null;
            this.txtDailyCheckConnectionString.CustomButton.Location = new System.Drawing.Point(601, 1);
            this.txtDailyCheckConnectionString.CustomButton.Name = "";
            this.txtDailyCheckConnectionString.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDailyCheckConnectionString.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDailyCheckConnectionString.CustomButton.TabIndex = 1;
            this.txtDailyCheckConnectionString.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDailyCheckConnectionString.CustomButton.UseSelectable = true;
            this.txtDailyCheckConnectionString.CustomButton.Visible = false;
            this.txtDailyCheckConnectionString.Lines = new string[0];
            this.txtDailyCheckConnectionString.Location = new System.Drawing.Point(193, 25);
            this.txtDailyCheckConnectionString.MaxLength = 32767;
            this.txtDailyCheckConnectionString.Multiline = true;
            this.txtDailyCheckConnectionString.Name = "txtDailyCheckConnectionString";
            this.txtDailyCheckConnectionString.PasswordChar = '\0';
            this.txtDailyCheckConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDailyCheckConnectionString.SelectedText = "";
            this.txtDailyCheckConnectionString.SelectionLength = 0;
            this.txtDailyCheckConnectionString.SelectionStart = 0;
            this.txtDailyCheckConnectionString.ShortcutsEnabled = true;
            this.txtDailyCheckConnectionString.Size = new System.Drawing.Size(625, 25);
            this.txtDailyCheckConnectionString.TabIndex = 3;
            this.txtDailyCheckConnectionString.UseSelectable = true;
            this.txtDailyCheckConnectionString.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDailyCheckConnectionString.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDailyCheckConnectionString
            // 
            this.lblDailyCheckConnectionString.AutoSize = true;
            this.lblDailyCheckConnectionString.Location = new System.Drawing.Point(3, 25);
            this.lblDailyCheckConnectionString.Name = "lblDailyCheckConnectionString";
            this.lblDailyCheckConnectionString.Size = new System.Drawing.Size(184, 19);
            this.lblDailyCheckConnectionString.TabIndex = 2;
            this.lblDailyCheckConnectionString.Text = "Daily Check Connection String";
            // 
            // tabSQL
            // 
            this.tabSQL.Controls.Add(this.lblExcludeSites);
            this.tabSQL.Controls.Add(this.lblLocation);
            this.tabSQL.Controls.Add(this.lblTaskName);
            this.tabSQL.Controls.Add(this.btnDeleteScheduleTasks);
            this.tabSQL.Controls.Add(this.gridScheduleTasks);
            this.tabSQL.Controls.Add(this.btnUpdateScheduleTasks);
            this.tabSQL.Controls.Add(this.btnAddScheduleTasks);
            this.tabSQL.Controls.Add(this.chkScheduleTasks);
            this.tabSQL.Controls.Add(this.txtLocation);
            this.tabSQL.Controls.Add(this.txtExcludeSites);
            this.tabSQL.Controls.Add(this.txtTaskName);
            this.tabSQL.HorizontalScrollbarBarColor = true;
            this.tabSQL.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSQL.HorizontalScrollbarSize = 10;
            this.tabSQL.Location = new System.Drawing.Point(4, 38);
            this.tabSQL.Name = "tabSQL";
            this.tabSQL.Size = new System.Drawing.Size(832, 450);
            this.tabSQL.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabSQL.TabIndex = 1;
            this.tabSQL.Text = "Schedule Tasks";
            this.tabSQL.VerticalScrollbarBarColor = true;
            this.tabSQL.VerticalScrollbarHighlightOnWheel = false;
            this.tabSQL.VerticalScrollbarSize = 10;
            // 
            // btnDeleteScheduleTasks
            // 
            this.btnDeleteScheduleTasks.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteScheduleTasks.Location = new System.Drawing.Point(281, 175);
            this.btnDeleteScheduleTasks.Name = "btnDeleteScheduleTasks";
            this.btnDeleteScheduleTasks.Size = new System.Drawing.Size(99, 34);
            this.btnDeleteScheduleTasks.TabIndex = 11;
            this.btnDeleteScheduleTasks.Text = "Delete";
            this.btnDeleteScheduleTasks.UseCustomBackColor = true;
            this.btnDeleteScheduleTasks.UseCustomForeColor = true;
            this.btnDeleteScheduleTasks.UseSelectable = true;
            this.btnDeleteScheduleTasks.UseStyleColors = true;
            this.btnDeleteScheduleTasks.Click += new System.EventHandler(this.btnDeleteScheduleTasks_Click);
            // 
            // gridScheduleTasks
            // 
            this.gridScheduleTasks.AllowUserToResizeRows = false;
            this.gridScheduleTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridScheduleTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridScheduleTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridScheduleTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridScheduleTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.gridScheduleTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridScheduleTasks.DefaultCellStyle = dataGridViewCellStyle41;
            this.gridScheduleTasks.EnableHeadersVisualStyles = false;
            this.gridScheduleTasks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridScheduleTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridScheduleTasks.Location = new System.Drawing.Point(13, 235);
            this.gridScheduleTasks.Name = "gridScheduleTasks";
            this.gridScheduleTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridScheduleTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.gridScheduleTasks.RowHeadersWidth = 62;
            this.gridScheduleTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridScheduleTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridScheduleTasks.Size = new System.Drawing.Size(795, 186);
            this.gridScheduleTasks.TabIndex = 10;
            this.gridScheduleTasks.SelectionChanged += new System.EventHandler(this.gridScheduleTasks_SelectionChanged);
            // 
            // btnUpdateScheduleTasks
            // 
            this.btnUpdateScheduleTasks.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateScheduleTasks.Location = new System.Drawing.Point(147, 175);
            this.btnUpdateScheduleTasks.Name = "btnUpdateScheduleTasks";
            this.btnUpdateScheduleTasks.Size = new System.Drawing.Size(99, 34);
            this.btnUpdateScheduleTasks.TabIndex = 9;
            this.btnUpdateScheduleTasks.Text = "Update";
            this.btnUpdateScheduleTasks.UseCustomBackColor = true;
            this.btnUpdateScheduleTasks.UseCustomForeColor = true;
            this.btnUpdateScheduleTasks.UseSelectable = true;
            this.btnUpdateScheduleTasks.UseStyleColors = true;
            this.btnUpdateScheduleTasks.Click += new System.EventHandler(this.btnUpdateScheduleTasks_Click);
            // 
            // btnAddScheduleTasks
            // 
            this.btnAddScheduleTasks.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddScheduleTasks.Location = new System.Drawing.Point(13, 175);
            this.btnAddScheduleTasks.Name = "btnAddScheduleTasks";
            this.btnAddScheduleTasks.Size = new System.Drawing.Size(99, 34);
            this.btnAddScheduleTasks.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddScheduleTasks.TabIndex = 8;
            this.btnAddScheduleTasks.Text = "Add";
            this.btnAddScheduleTasks.UseCustomBackColor = true;
            this.btnAddScheduleTasks.UseCustomForeColor = true;
            this.btnAddScheduleTasks.UseSelectable = true;
            this.btnAddScheduleTasks.UseStyleColors = true;
            this.btnAddScheduleTasks.Click += new System.EventHandler(this.btnAddScheduleTasks_Click);
            // 
            // chkScheduleTasks
            // 
            this.chkScheduleTasks.AutoSize = true;
            this.chkScheduleTasks.Location = new System.Drawing.Point(147, 145);
            this.chkScheduleTasks.Name = "chkScheduleTasks";
            this.chkScheduleTasks.Size = new System.Drawing.Size(58, 15);
            this.chkScheduleTasks.TabIndex = 7;
            this.chkScheduleTasks.Text = "Enable";
            this.chkScheduleTasks.UseSelectable = true;
            // 
            // txtLocation
            // 
            // 
            // 
            // 
            this.txtLocation.CustomButton.Image = null;
            this.txtLocation.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtLocation.CustomButton.Name = "";
            this.txtLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocation.CustomButton.TabIndex = 1;
            this.txtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocation.CustomButton.UseSelectable = true;
            this.txtLocation.CustomButton.Visible = false;
            this.txtLocation.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLocation.Lines = new string[0];
            this.txtLocation.Location = new System.Drawing.Point(147, 60);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.ShortcutsEnabled = true;
            this.txtLocation.Size = new System.Drawing.Size(201, 23);
            this.txtLocation.TabIndex = 6;
            this.txtLocation.UseSelectable = true;
            this.txtLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtExcludeSites
            // 
            // 
            // 
            // 
            this.txtExcludeSites.CustomButton.Image = null;
            this.txtExcludeSites.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtExcludeSites.CustomButton.Name = "";
            this.txtExcludeSites.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtExcludeSites.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExcludeSites.CustomButton.TabIndex = 1;
            this.txtExcludeSites.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExcludeSites.CustomButton.UseSelectable = true;
            this.txtExcludeSites.CustomButton.Visible = false;
            this.txtExcludeSites.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtExcludeSites.Lines = new string[0];
            this.txtExcludeSites.Location = new System.Drawing.Point(147, 102);
            this.txtExcludeSites.MaxLength = 32767;
            this.txtExcludeSites.Name = "txtExcludeSites";
            this.txtExcludeSites.PasswordChar = '\0';
            this.txtExcludeSites.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExcludeSites.SelectedText = "";
            this.txtExcludeSites.SelectionLength = 0;
            this.txtExcludeSites.SelectionStart = 0;
            this.txtExcludeSites.ShortcutsEnabled = true;
            this.txtExcludeSites.Size = new System.Drawing.Size(201, 23);
            this.txtExcludeSites.TabIndex = 5;
            this.txtExcludeSites.UseSelectable = true;
            this.txtExcludeSites.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExcludeSites.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTaskName
            // 
            // 
            // 
            // 
            this.txtTaskName.CustomButton.Image = null;
            this.txtTaskName.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtTaskName.CustomButton.Name = "";
            this.txtTaskName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTaskName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTaskName.CustomButton.TabIndex = 1;
            this.txtTaskName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTaskName.CustomButton.UseSelectable = true;
            this.txtTaskName.CustomButton.Visible = false;
            this.txtTaskName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTaskName.Lines = new string[0];
            this.txtTaskName.Location = new System.Drawing.Point(147, 21);
            this.txtTaskName.MaxLength = 32767;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PasswordChar = '\0';
            this.txtTaskName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaskName.SelectedText = "";
            this.txtTaskName.SelectionLength = 0;
            this.txtTaskName.SelectionStart = 0;
            this.txtTaskName.ShortcutsEnabled = true;
            this.txtTaskName.Size = new System.Drawing.Size(201, 23);
            this.txtTaskName.TabIndex = 3;
            this.txtTaskName.UseSelectable = true;
            this.txtTaskName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTaskName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.lblServicesLocaiton);
            this.tabServices.Controls.Add(this.txtServicesExcludeSites);
            this.tabServices.Controls.Add(this.lblServicesExcludeSites);
            this.tabServices.Controls.Add(this.lblServiceName);
            this.tabServices.Controls.Add(this.lblServiceDisplay);
            this.tabServices.Controls.Add(this.btnDeteteServices);
            this.tabServices.Controls.Add(this.gridServices);
            this.tabServices.Controls.Add(this.btnUpdateServices);
            this.tabServices.Controls.Add(this.btnAddServices);
            this.tabServices.Controls.Add(this.chkServicesEnable);
            this.tabServices.Controls.Add(this.txtServiceName);
            this.tabServices.Controls.Add(this.txtServicesLocation);
            this.tabServices.Controls.Add(this.txtServiceDisplay);
            this.tabServices.HorizontalScrollbarBarColor = true;
            this.tabServices.HorizontalScrollbarHighlightOnWheel = false;
            this.tabServices.HorizontalScrollbarSize = 10;
            this.tabServices.Location = new System.Drawing.Point(4, 38);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(832, 460);
            this.tabServices.TabIndex = 2;
            this.tabServices.Text = "Services";
            this.tabServices.VerticalScrollbarBarColor = true;
            this.tabServices.VerticalScrollbarHighlightOnWheel = false;
            this.tabServices.VerticalScrollbarSize = 10;
            // 
            // txtMasterFiles_POSServer
            // 
            // 
            // 
            // 
            this.txtMasterFiles_POSServer.CustomButton.Image = null;
            this.txtMasterFiles_POSServer.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtMasterFiles_POSServer.CustomButton.Name = "";
            this.txtMasterFiles_POSServer.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMasterFiles_POSServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMasterFiles_POSServer.CustomButton.TabIndex = 1;
            this.txtMasterFiles_POSServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMasterFiles_POSServer.CustomButton.UseSelectable = true;
            this.txtMasterFiles_POSServer.CustomButton.Visible = false;
            this.txtMasterFiles_POSServer.Lines = new string[0];
            this.txtMasterFiles_POSServer.Location = new System.Drawing.Point(620, 220);
            this.txtMasterFiles_POSServer.MaxLength = 32767;
            this.txtMasterFiles_POSServer.Name = "txtMasterFiles_POSServer";
            this.txtMasterFiles_POSServer.PasswordChar = '\0';
            this.txtMasterFiles_POSServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasterFiles_POSServer.SelectedText = "";
            this.txtMasterFiles_POSServer.SelectionLength = 0;
            this.txtMasterFiles_POSServer.SelectionStart = 0;
            this.txtMasterFiles_POSServer.ShortcutsEnabled = true;
            this.txtMasterFiles_POSServer.Size = new System.Drawing.Size(198, 25);
            this.txtMasterFiles_POSServer.TabIndex = 21;
            this.txtMasterFiles_POSServer.UseSelectable = true;
            this.txtMasterFiles_POSServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMasterFiles_POSServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMasterFiles_POSServer
            // 
            this.lblMasterFiles_POSServer.AutoSize = true;
            this.lblMasterFiles_POSServer.Location = new System.Drawing.Point(451, 220);
            this.lblMasterFiles_POSServer.Name = "lblMasterFiles_POSServer";
            this.lblMasterFiles_POSServer.Size = new System.Drawing.Size(150, 19);
            this.lblMasterFiles_POSServer.TabIndex = 20;
            this.lblMasterFiles_POSServer.Text = "Master Files POS Server";
            // 
            // txtMasterFiles_BOSServer
            // 
            // 
            // 
            // 
            this.txtMasterFiles_BOSServer.CustomButton.Image = null;
            this.txtMasterFiles_BOSServer.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtMasterFiles_BOSServer.CustomButton.Name = "";
            this.txtMasterFiles_BOSServer.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMasterFiles_BOSServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMasterFiles_BOSServer.CustomButton.TabIndex = 1;
            this.txtMasterFiles_BOSServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMasterFiles_BOSServer.CustomButton.UseSelectable = true;
            this.txtMasterFiles_BOSServer.CustomButton.Visible = false;
            this.txtMasterFiles_BOSServer.Lines = new string[0];
            this.txtMasterFiles_BOSServer.Location = new System.Drawing.Point(620, 179);
            this.txtMasterFiles_BOSServer.MaxLength = 32767;
            this.txtMasterFiles_BOSServer.Name = "txtMasterFiles_BOSServer";
            this.txtMasterFiles_BOSServer.PasswordChar = '\0';
            this.txtMasterFiles_BOSServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasterFiles_BOSServer.SelectedText = "";
            this.txtMasterFiles_BOSServer.SelectionLength = 0;
            this.txtMasterFiles_BOSServer.SelectionStart = 0;
            this.txtMasterFiles_BOSServer.ShortcutsEnabled = true;
            this.txtMasterFiles_BOSServer.Size = new System.Drawing.Size(198, 25);
            this.txtMasterFiles_BOSServer.TabIndex = 19;
            this.txtMasterFiles_BOSServer.UseSelectable = true;
            this.txtMasterFiles_BOSServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMasterFiles_BOSServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMasterFiles_BOSServer
            // 
            this.lblMasterFiles_BOSServer.AutoSize = true;
            this.lblMasterFiles_BOSServer.Location = new System.Drawing.Point(451, 179);
            this.lblMasterFiles_BOSServer.Name = "lblMasterFiles_BOSServer";
            this.lblMasterFiles_BOSServer.Size = new System.Drawing.Size(150, 19);
            this.lblMasterFiles_BOSServer.TabIndex = 18;
            this.lblMasterFiles_BOSServer.Text = "Master Files BOS Server";
            // 
            // txtMaster_SCO_SQLServer
            // 
            // 
            // 
            // 
            this.txtMaster_SCO_SQLServer.CustomButton.Image = null;
            this.txtMaster_SCO_SQLServer.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtMaster_SCO_SQLServer.CustomButton.Name = "";
            this.txtMaster_SCO_SQLServer.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMaster_SCO_SQLServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaster_SCO_SQLServer.CustomButton.TabIndex = 1;
            this.txtMaster_SCO_SQLServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaster_SCO_SQLServer.CustomButton.UseSelectable = true;
            this.txtMaster_SCO_SQLServer.CustomButton.Visible = false;
            this.txtMaster_SCO_SQLServer.Lines = new string[0];
            this.txtMaster_SCO_SQLServer.Location = new System.Drawing.Point(620, 139);
            this.txtMaster_SCO_SQLServer.MaxLength = 32767;
            this.txtMaster_SCO_SQLServer.Name = "txtMaster_SCO_SQLServer";
            this.txtMaster_SCO_SQLServer.PasswordChar = '\0';
            this.txtMaster_SCO_SQLServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaster_SCO_SQLServer.SelectedText = "";
            this.txtMaster_SCO_SQLServer.SelectionLength = 0;
            this.txtMaster_SCO_SQLServer.SelectionStart = 0;
            this.txtMaster_SCO_SQLServer.ShortcutsEnabled = true;
            this.txtMaster_SCO_SQLServer.Size = new System.Drawing.Size(198, 25);
            this.txtMaster_SCO_SQLServer.TabIndex = 17;
            this.txtMaster_SCO_SQLServer.UseSelectable = true;
            this.txtMaster_SCO_SQLServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaster_SCO_SQLServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMaster_SCO_SQLServer
            // 
            this.lblMaster_SCO_SQLServer.AutoSize = true;
            this.lblMaster_SCO_SQLServer.Location = new System.Drawing.Point(451, 139);
            this.lblMaster_SCO_SQLServer.Name = "lblMaster_SCO_SQLServer";
            this.lblMaster_SCO_SQLServer.Size = new System.Drawing.Size(150, 19);
            this.lblMaster_SCO_SQLServer.TabIndex = 16;
            this.lblMaster_SCO_SQLServer.Text = "Master SCO SQL Server";
            // 
            // txtMaster_BOS_SQLServer
            // 
            // 
            // 
            // 
            this.txtMaster_BOS_SQLServer.CustomButton.Image = null;
            this.txtMaster_BOS_SQLServer.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtMaster_BOS_SQLServer.CustomButton.Name = "";
            this.txtMaster_BOS_SQLServer.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMaster_BOS_SQLServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaster_BOS_SQLServer.CustomButton.TabIndex = 1;
            this.txtMaster_BOS_SQLServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaster_BOS_SQLServer.CustomButton.UseSelectable = true;
            this.txtMaster_BOS_SQLServer.CustomButton.Visible = false;
            this.txtMaster_BOS_SQLServer.Lines = new string[0];
            this.txtMaster_BOS_SQLServer.Location = new System.Drawing.Point(620, 103);
            this.txtMaster_BOS_SQLServer.MaxLength = 32767;
            this.txtMaster_BOS_SQLServer.Name = "txtMaster_BOS_SQLServer";
            this.txtMaster_BOS_SQLServer.PasswordChar = '\0';
            this.txtMaster_BOS_SQLServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaster_BOS_SQLServer.SelectedText = "";
            this.txtMaster_BOS_SQLServer.SelectionLength = 0;
            this.txtMaster_BOS_SQLServer.SelectionStart = 0;
            this.txtMaster_BOS_SQLServer.ShortcutsEnabled = true;
            this.txtMaster_BOS_SQLServer.Size = new System.Drawing.Size(198, 25);
            this.txtMaster_BOS_SQLServer.TabIndex = 15;
            this.txtMaster_BOS_SQLServer.UseSelectable = true;
            this.txtMaster_BOS_SQLServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaster_BOS_SQLServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMaster_BOS_SQLServer
            // 
            this.lblMaster_BOS_SQLServer.AutoSize = true;
            this.lblMaster_BOS_SQLServer.Location = new System.Drawing.Point(451, 103);
            this.lblMaster_BOS_SQLServer.Name = "lblMaster_BOS_SQLServer";
            this.lblMaster_BOS_SQLServer.Size = new System.Drawing.Size(149, 19);
            this.lblMaster_BOS_SQLServer.TabIndex = 14;
            this.lblMaster_BOS_SQLServer.Text = "Master BOS SQL Server";
            // 
            // txtSCOConnectionString
            // 
            // 
            // 
            // 
            this.txtSCOConnectionString.CustomButton.Image = null;
            this.txtSCOConnectionString.CustomButton.Location = new System.Drawing.Point(601, 1);
            this.txtSCOConnectionString.CustomButton.Name = "";
            this.txtSCOConnectionString.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSCOConnectionString.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSCOConnectionString.CustomButton.TabIndex = 1;
            this.txtSCOConnectionString.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSCOConnectionString.CustomButton.UseSelectable = true;
            this.txtSCOConnectionString.CustomButton.Visible = false;
            this.txtSCOConnectionString.Lines = new string[0];
            this.txtSCOConnectionString.Location = new System.Drawing.Point(193, 336);
            this.txtSCOConnectionString.MaxLength = 32767;
            this.txtSCOConnectionString.Multiline = true;
            this.txtSCOConnectionString.Name = "txtSCOConnectionString";
            this.txtSCOConnectionString.PasswordChar = '\0';
            this.txtSCOConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSCOConnectionString.SelectedText = "";
            this.txtSCOConnectionString.SelectionLength = 0;
            this.txtSCOConnectionString.SelectionStart = 0;
            this.txtSCOConnectionString.ShortcutsEnabled = true;
            this.txtSCOConnectionString.Size = new System.Drawing.Size(625, 25);
            this.txtSCOConnectionString.TabIndex = 25;
            this.txtSCOConnectionString.UseSelectable = true;
            this.txtSCOConnectionString.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSCOConnectionString.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSCOConnectionString
            // 
            this.lblSCOConnectionString.AutoSize = true;
            this.lblSCOConnectionString.Location = new System.Drawing.Point(3, 336);
            this.lblSCOConnectionString.Name = "lblSCOConnectionString";
            this.lblSCOConnectionString.Size = new System.Drawing.Size(144, 19);
            this.lblSCOConnectionString.TabIndex = 24;
            this.lblSCOConnectionString.Text = "SCO Connection String";
            // 
            // txtBOSConnectionString
            // 
            // 
            // 
            // 
            this.txtBOSConnectionString.CustomButton.Image = null;
            this.txtBOSConnectionString.CustomButton.Location = new System.Drawing.Point(601, 1);
            this.txtBOSConnectionString.CustomButton.Name = "";
            this.txtBOSConnectionString.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBOSConnectionString.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBOSConnectionString.CustomButton.TabIndex = 1;
            this.txtBOSConnectionString.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBOSConnectionString.CustomButton.UseSelectable = true;
            this.txtBOSConnectionString.CustomButton.Visible = false;
            this.txtBOSConnectionString.Lines = new string[0];
            this.txtBOSConnectionString.Location = new System.Drawing.Point(193, 296);
            this.txtBOSConnectionString.MaxLength = 32767;
            this.txtBOSConnectionString.Multiline = true;
            this.txtBOSConnectionString.Name = "txtBOSConnectionString";
            this.txtBOSConnectionString.PasswordChar = '\0';
            this.txtBOSConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBOSConnectionString.SelectedText = "";
            this.txtBOSConnectionString.SelectionLength = 0;
            this.txtBOSConnectionString.SelectionStart = 0;
            this.txtBOSConnectionString.ShortcutsEnabled = true;
            this.txtBOSConnectionString.Size = new System.Drawing.Size(625, 25);
            this.txtBOSConnectionString.TabIndex = 23;
            this.txtBOSConnectionString.UseSelectable = true;
            this.txtBOSConnectionString.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBOSConnectionString.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBOSConnectionString
            // 
            this.lblBOSConnectionString.AutoSize = true;
            this.lblBOSConnectionString.Location = new System.Drawing.Point(3, 296);
            this.lblBOSConnectionString.Name = "lblBOSConnectionString";
            this.lblBOSConnectionString.Size = new System.Drawing.Size(143, 19);
            this.lblBOSConnectionString.TabIndex = 22;
            this.lblBOSConnectionString.Text = "BOS Connection String";
            // 
            // txtPOSConnectionString
            // 
            // 
            // 
            // 
            this.txtPOSConnectionString.CustomButton.Image = null;
            this.txtPOSConnectionString.CustomButton.Location = new System.Drawing.Point(601, 1);
            this.txtPOSConnectionString.CustomButton.Name = "";
            this.txtPOSConnectionString.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPOSConnectionString.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPOSConnectionString.CustomButton.TabIndex = 1;
            this.txtPOSConnectionString.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPOSConnectionString.CustomButton.UseSelectable = true;
            this.txtPOSConnectionString.CustomButton.Visible = false;
            this.txtPOSConnectionString.Lines = new string[0];
            this.txtPOSConnectionString.Location = new System.Drawing.Point(193, 381);
            this.txtPOSConnectionString.MaxLength = 32767;
            this.txtPOSConnectionString.Multiline = true;
            this.txtPOSConnectionString.Name = "txtPOSConnectionString";
            this.txtPOSConnectionString.PasswordChar = '\0';
            this.txtPOSConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPOSConnectionString.SelectedText = "";
            this.txtPOSConnectionString.SelectionLength = 0;
            this.txtPOSConnectionString.SelectionStart = 0;
            this.txtPOSConnectionString.ShortcutsEnabled = true;
            this.txtPOSConnectionString.Size = new System.Drawing.Size(625, 25);
            this.txtPOSConnectionString.TabIndex = 27;
            this.txtPOSConnectionString.UseSelectable = true;
            this.txtPOSConnectionString.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPOSConnectionString.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPOSConnectionString
            // 
            this.lblPOSConnectionString.AutoSize = true;
            this.lblPOSConnectionString.Location = new System.Drawing.Point(3, 381);
            this.lblPOSConnectionString.Name = "lblPOSConnectionString";
            this.lblPOSConnectionString.Size = new System.Drawing.Size(143, 19);
            this.lblPOSConnectionString.TabIndex = 26;
            this.lblPOSConnectionString.Text = "POS Connection String";
            // 
            // txtMasterFiles_SCOServer
            // 
            // 
            // 
            // 
            this.txtMasterFiles_SCOServer.CustomButton.Image = null;
            this.txtMasterFiles_SCOServer.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtMasterFiles_SCOServer.CustomButton.Name = "";
            this.txtMasterFiles_SCOServer.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMasterFiles_SCOServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMasterFiles_SCOServer.CustomButton.TabIndex = 1;
            this.txtMasterFiles_SCOServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMasterFiles_SCOServer.CustomButton.UseSelectable = true;
            this.txtMasterFiles_SCOServer.CustomButton.Visible = false;
            this.txtMasterFiles_SCOServer.Lines = new string[0];
            this.txtMasterFiles_SCOServer.Location = new System.Drawing.Point(620, 255);
            this.txtMasterFiles_SCOServer.MaxLength = 32767;
            this.txtMasterFiles_SCOServer.Name = "txtMasterFiles_SCOServer";
            this.txtMasterFiles_SCOServer.PasswordChar = '\0';
            this.txtMasterFiles_SCOServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasterFiles_SCOServer.SelectedText = "";
            this.txtMasterFiles_SCOServer.SelectionLength = 0;
            this.txtMasterFiles_SCOServer.SelectionStart = 0;
            this.txtMasterFiles_SCOServer.ShortcutsEnabled = true;
            this.txtMasterFiles_SCOServer.Size = new System.Drawing.Size(198, 25);
            this.txtMasterFiles_SCOServer.TabIndex = 29;
            this.txtMasterFiles_SCOServer.UseSelectable = true;
            this.txtMasterFiles_SCOServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMasterFiles_SCOServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMasterFiles_SCOServer
            // 
            this.lblMasterFiles_SCOServer.AutoSize = true;
            this.lblMasterFiles_SCOServer.Location = new System.Drawing.Point(451, 255);
            this.lblMasterFiles_SCOServer.Name = "lblMasterFiles_SCOServer";
            this.lblMasterFiles_SCOServer.Size = new System.Drawing.Size(151, 19);
            this.lblMasterFiles_SCOServer.TabIndex = 28;
            this.lblMasterFiles_SCOServer.Text = "Master Files SCO Server";
            // 
            // btnUpdateConnection
            // 
            this.btnUpdateConnection.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateConnection.Location = new System.Drawing.Point(10, 423);
            this.btnUpdateConnection.Name = "btnUpdateConnection";
            this.btnUpdateConnection.Size = new System.Drawing.Size(137, 34);
            this.btnUpdateConnection.TabIndex = 30;
            this.btnUpdateConnection.Text = "Update";
            this.btnUpdateConnection.UseCustomBackColor = true;
            this.btnUpdateConnection.UseCustomForeColor = true;
            this.btnUpdateConnection.UseSelectable = true;
            this.btnUpdateConnection.UseStyleColors = true;
            this.btnUpdateConnection.Click += new System.EventHandler(this.btnUpdateConnection_Click);
            // 
            // txtMasterNamosSTN
            // 
            // 
            // 
            // 
            this.txtMasterNamosSTN.CustomButton.Image = null;
            this.txtMasterNamosSTN.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtMasterNamosSTN.CustomButton.Name = "";
            this.txtMasterNamosSTN.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMasterNamosSTN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMasterNamosSTN.CustomButton.TabIndex = 1;
            this.txtMasterNamosSTN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMasterNamosSTN.CustomButton.UseSelectable = true;
            this.txtMasterNamosSTN.CustomButton.Visible = false;
            this.txtMasterNamosSTN.Lines = new string[0];
            this.txtMasterNamosSTN.Location = new System.Drawing.Point(193, 255);
            this.txtMasterNamosSTN.MaxLength = 32767;
            this.txtMasterNamosSTN.Name = "txtMasterNamosSTN";
            this.txtMasterNamosSTN.PasswordChar = '\0';
            this.txtMasterNamosSTN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasterNamosSTN.SelectedText = "";
            this.txtMasterNamosSTN.SelectionLength = 0;
            this.txtMasterNamosSTN.SelectionStart = 0;
            this.txtMasterNamosSTN.ShortcutsEnabled = true;
            this.txtMasterNamosSTN.Size = new System.Drawing.Size(198, 25);
            this.txtMasterNamosSTN.TabIndex = 32;
            this.txtMasterNamosSTN.UseSelectable = true;
            this.txtMasterNamosSTN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMasterNamosSTN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMasterNamosSTN
            // 
            this.lblMasterNamosSTN.AutoSize = true;
            this.lblMasterNamosSTN.Location = new System.Drawing.Point(3, 255);
            this.lblMasterNamosSTN.Name = "lblMasterNamosSTN";
            this.lblMasterNamosSTN.Size = new System.Drawing.Size(123, 19);
            this.lblMasterNamosSTN.TabIndex = 31;
            this.lblMasterNamosSTN.Text = "Master Namos STN";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(24, 21);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(72, 19);
            this.lblTaskName.TabIndex = 12;
            this.lblTaskName.Text = "Task Name";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(24, 60);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 19);
            this.lblLocation.TabIndex = 13;
            this.lblLocation.Text = "Location";
            // 
            // lblExcludeSites
            // 
            this.lblExcludeSites.AutoSize = true;
            this.lblExcludeSites.Location = new System.Drawing.Point(24, 102);
            this.lblExcludeSites.Name = "lblExcludeSites";
            this.lblExcludeSites.Size = new System.Drawing.Size(83, 19);
            this.lblExcludeSites.TabIndex = 14;
            this.lblExcludeSites.Text = "Exclude Sites";
            // 
            // lblServicesExcludeSites
            // 
            this.lblServicesExcludeSites.AutoSize = true;
            this.lblServicesExcludeSites.Location = new System.Drawing.Point(481, 64);
            this.lblServicesExcludeSites.Name = "lblServicesExcludeSites";
            this.lblServicesExcludeSites.Size = new System.Drawing.Size(83, 19);
            this.lblServicesExcludeSites.TabIndex = 25;
            this.lblServicesExcludeSites.Text = "Exclude Sites";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(30, 64);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(91, 19);
            this.lblServiceName.TabIndex = 24;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblServiceDisplay
            // 
            this.lblServiceDisplay.AutoSize = true;
            this.lblServiceDisplay.Location = new System.Drawing.Point(30, 25);
            this.lblServiceDisplay.Name = "lblServiceDisplay";
            this.lblServiceDisplay.Size = new System.Drawing.Size(96, 19);
            this.lblServiceDisplay.TabIndex = 23;
            this.lblServiceDisplay.Text = "Service Display";
            // 
            // btnDeteteServices
            // 
            this.btnDeteteServices.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeteteServices.Location = new System.Drawing.Point(287, 145);
            this.btnDeteteServices.Name = "btnDeteteServices";
            this.btnDeteteServices.Size = new System.Drawing.Size(99, 34);
            this.btnDeteteServices.TabIndex = 22;
            this.btnDeteteServices.Text = "Delete";
            this.btnDeteteServices.UseCustomBackColor = true;
            this.btnDeteteServices.UseCustomForeColor = true;
            this.btnDeteteServices.UseSelectable = true;
            this.btnDeteteServices.UseStyleColors = true;
            this.btnDeteteServices.Click += new System.EventHandler(this.btnDeteteServices_Click);
            // 
            // gridServices
            // 
            this.gridServices.AllowUserToResizeRows = false;
            this.gridServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.gridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridServices.DefaultCellStyle = dataGridViewCellStyle38;
            this.gridServices.EnableHeadersVisualStyles = false;
            this.gridServices.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridServices.Location = new System.Drawing.Point(19, 207);
            this.gridServices.Name = "gridServices";
            this.gridServices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.gridServices.RowHeadersWidth = 62;
            this.gridServices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridServices.Size = new System.Drawing.Size(795, 240);
            this.gridServices.TabIndex = 21;
            this.gridServices.SelectionChanged += new System.EventHandler(this.gridServices_SelectionChanged);
            // 
            // btnUpdateServices
            // 
            this.btnUpdateServices.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpdateServices.Location = new System.Drawing.Point(153, 145);
            this.btnUpdateServices.Name = "btnUpdateServices";
            this.btnUpdateServices.Size = new System.Drawing.Size(99, 34);
            this.btnUpdateServices.TabIndex = 20;
            this.btnUpdateServices.Text = "Update";
            this.btnUpdateServices.UseCustomBackColor = true;
            this.btnUpdateServices.UseCustomForeColor = true;
            this.btnUpdateServices.UseSelectable = true;
            this.btnUpdateServices.UseStyleColors = true;
            this.btnUpdateServices.Click += new System.EventHandler(this.btnUpdateServices_Click);
            // 
            // btnAddServices
            // 
            this.btnAddServices.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddServices.Location = new System.Drawing.Point(19, 145);
            this.btnAddServices.Name = "btnAddServices";
            this.btnAddServices.Size = new System.Drawing.Size(99, 34);
            this.btnAddServices.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAddServices.TabIndex = 19;
            this.btnAddServices.Text = "Add";
            this.btnAddServices.UseCustomBackColor = true;
            this.btnAddServices.UseCustomForeColor = true;
            this.btnAddServices.UseSelectable = true;
            this.btnAddServices.UseStyleColors = true;
            this.btnAddServices.Click += new System.EventHandler(this.btnAddServices_Click);
            // 
            // chkServicesEnable
            // 
            this.chkServicesEnable.AutoSize = true;
            this.chkServicesEnable.Location = new System.Drawing.Point(153, 108);
            this.chkServicesEnable.Name = "chkServicesEnable";
            this.chkServicesEnable.Size = new System.Drawing.Size(58, 15);
            this.chkServicesEnable.TabIndex = 18;
            this.chkServicesEnable.Text = "Enable";
            this.chkServicesEnable.UseSelectable = true;
            // 
            // txtServiceName
            // 
            // 
            // 
            // 
            this.txtServiceName.CustomButton.Image = null;
            this.txtServiceName.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtServiceName.CustomButton.Name = "";
            this.txtServiceName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServiceName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServiceName.CustomButton.TabIndex = 1;
            this.txtServiceName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServiceName.CustomButton.UseSelectable = true;
            this.txtServiceName.CustomButton.Visible = false;
            this.txtServiceName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtServiceName.Lines = new string[0];
            this.txtServiceName.Location = new System.Drawing.Point(153, 64);
            this.txtServiceName.MaxLength = 32767;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PasswordChar = '\0';
            this.txtServiceName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.SelectionLength = 0;
            this.txtServiceName.SelectionStart = 0;
            this.txtServiceName.ShortcutsEnabled = true;
            this.txtServiceName.Size = new System.Drawing.Size(277, 23);
            this.txtServiceName.TabIndex = 17;
            this.txtServiceName.UseSelectable = true;
            this.txtServiceName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServiceName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtServicesLocation
            // 
            // 
            // 
            // 
            this.txtServicesLocation.CustomButton.Image = null;
            this.txtServicesLocation.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtServicesLocation.CustomButton.Name = "";
            this.txtServicesLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServicesLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServicesLocation.CustomButton.TabIndex = 1;
            this.txtServicesLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServicesLocation.CustomButton.UseSelectable = true;
            this.txtServicesLocation.CustomButton.Visible = false;
            this.txtServicesLocation.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtServicesLocation.Lines = new string[0];
            this.txtServicesLocation.Location = new System.Drawing.Point(602, 25);
            this.txtServicesLocation.MaxLength = 32767;
            this.txtServicesLocation.Name = "txtServicesLocation";
            this.txtServicesLocation.PasswordChar = '\0';
            this.txtServicesLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServicesLocation.SelectedText = "";
            this.txtServicesLocation.SelectionLength = 0;
            this.txtServicesLocation.SelectionStart = 0;
            this.txtServicesLocation.ShortcutsEnabled = true;
            this.txtServicesLocation.Size = new System.Drawing.Size(201, 23);
            this.txtServicesLocation.TabIndex = 16;
            this.txtServicesLocation.UseSelectable = true;
            this.txtServicesLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServicesLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtServiceDisplay
            // 
            // 
            // 
            // 
            this.txtServiceDisplay.CustomButton.Image = null;
            this.txtServiceDisplay.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtServiceDisplay.CustomButton.Name = "";
            this.txtServiceDisplay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServiceDisplay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServiceDisplay.CustomButton.TabIndex = 1;
            this.txtServiceDisplay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServiceDisplay.CustomButton.UseSelectable = true;
            this.txtServiceDisplay.CustomButton.Visible = false;
            this.txtServiceDisplay.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtServiceDisplay.Lines = new string[0];
            this.txtServiceDisplay.Location = new System.Drawing.Point(153, 25);
            this.txtServiceDisplay.MaxLength = 32767;
            this.txtServiceDisplay.Name = "txtServiceDisplay";
            this.txtServiceDisplay.PasswordChar = '\0';
            this.txtServiceDisplay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServiceDisplay.SelectedText = "";
            this.txtServiceDisplay.SelectionLength = 0;
            this.txtServiceDisplay.SelectionStart = 0;
            this.txtServiceDisplay.ShortcutsEnabled = true;
            this.txtServiceDisplay.Size = new System.Drawing.Size(277, 23);
            this.txtServiceDisplay.TabIndex = 15;
            this.txtServiceDisplay.UseSelectable = true;
            this.txtServiceDisplay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServiceDisplay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblServicesLocaiton
            // 
            this.lblServicesLocaiton.AutoSize = true;
            this.lblServicesLocaiton.Location = new System.Drawing.Point(481, 25);
            this.lblServicesLocaiton.Name = "lblServicesLocaiton";
            this.lblServicesLocaiton.Size = new System.Drawing.Size(58, 19);
            this.lblServicesLocaiton.TabIndex = 27;
            this.lblServicesLocaiton.Text = "Location";
            // 
            // txtServicesExcludeSites
            // 
            // 
            // 
            // 
            this.txtServicesExcludeSites.CustomButton.Image = null;
            this.txtServicesExcludeSites.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.txtServicesExcludeSites.CustomButton.Name = "";
            this.txtServicesExcludeSites.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServicesExcludeSites.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServicesExcludeSites.CustomButton.TabIndex = 1;
            this.txtServicesExcludeSites.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServicesExcludeSites.CustomButton.UseSelectable = true;
            this.txtServicesExcludeSites.CustomButton.Visible = false;
            this.txtServicesExcludeSites.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtServicesExcludeSites.Lines = new string[0];
            this.txtServicesExcludeSites.Location = new System.Drawing.Point(602, 64);
            this.txtServicesExcludeSites.MaxLength = 32767;
            this.txtServicesExcludeSites.Name = "txtServicesExcludeSites";
            this.txtServicesExcludeSites.PasswordChar = '\0';
            this.txtServicesExcludeSites.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServicesExcludeSites.SelectedText = "";
            this.txtServicesExcludeSites.SelectionLength = 0;
            this.txtServicesExcludeSites.SelectionStart = 0;
            this.txtServicesExcludeSites.ShortcutsEnabled = true;
            this.txtServicesExcludeSites.Size = new System.Drawing.Size(201, 23);
            this.txtServicesExcludeSites.TabIndex = 26;
            this.txtServicesExcludeSites.UseSelectable = true;
            this.txtServicesExcludeSites.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServicesExcludeSites.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 574);
            this.Controls.Add(this.tabControlSettings);
            this.Name = "Form1";
            this.Text = "Json Tool For NAMOS";
            this.tabControlSettings.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            this.tabSQL.ResumeLayout(false);
            this.tabSQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridScheduleTasks)).EndInit();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControlSettings;
        private MetroFramework.Controls.MetroTabPage tabConnection;
        private MetroFramework.Controls.MetroTabPage tabSQL;
        private MetroFramework.Controls.MetroLabel lblDailyCheckConnectionString;
        private MetroFramework.Controls.MetroTextBox txtHOConnectionString;
        private MetroFramework.Controls.MetroLabel lblHOConnectionString;
        private MetroFramework.Controls.MetroTextBox txtDailyCheckConnectionString;
        private MetroFramework.Controls.MetroTextBox txtDSSJsonFilePath;
        private MetroFramework.Controls.MetroLabel lblDSSJsonFilePath;
        private MetroFramework.Controls.MetroTextBox txtMaxPOSCount;
        private MetroFramework.Controls.MetroLabel lblMaxPOSCount;
        private MetroFramework.Controls.MetroTextBox txtReplicationArticleCount;
        private MetroFramework.Controls.MetroLabel lblReplicationArticleCount;
        private MetroFramework.Controls.MetroTextBox txtPOSListFilePath;
        private MetroFramework.Controls.MetroLabel lblPOSListFilePath;
        private MetroFramework.Controls.MetroButton btnUpdateScheduleTasks;
        public MetroFramework.Controls.MetroButton btnAddScheduleTasks;
        private MetroFramework.Controls.MetroCheckBox chkScheduleTasks;
        private MetroFramework.Controls.MetroTextBox txtLocation;
        private MetroFramework.Controls.MetroTextBox txtExcludeSites;
        private MetroFramework.Controls.MetroTextBox txtTaskName;
        private MetroFramework.Controls.MetroGrid gridScheduleTasks;
        private MetroFramework.Controls.MetroButton btnDeleteScheduleTasks;
        private MetroFramework.Controls.MetroTabPage tabServices;
        private MetroFramework.Controls.MetroTextBox txtMasterFiles_POSServer;
        private MetroFramework.Controls.MetroLabel lblMasterFiles_POSServer;
        private MetroFramework.Controls.MetroTextBox txtMasterFiles_BOSServer;
        private MetroFramework.Controls.MetroLabel lblMasterFiles_BOSServer;
        private MetroFramework.Controls.MetroTextBox txtMaster_SCO_SQLServer;
        private MetroFramework.Controls.MetroLabel lblMaster_SCO_SQLServer;
        private MetroFramework.Controls.MetroTextBox txtMaster_BOS_SQLServer;
        private MetroFramework.Controls.MetroLabel lblMaster_BOS_SQLServer;
        private MetroFramework.Controls.MetroTextBox txtPOSConnectionString;
        private MetroFramework.Controls.MetroLabel lblPOSConnectionString;
        private MetroFramework.Controls.MetroTextBox txtSCOConnectionString;
        private MetroFramework.Controls.MetroLabel lblSCOConnectionString;
        private MetroFramework.Controls.MetroTextBox txtBOSConnectionString;
        private MetroFramework.Controls.MetroLabel lblBOSConnectionString;
        private MetroFramework.Controls.MetroTextBox txtMasterFiles_SCOServer;
        private MetroFramework.Controls.MetroLabel lblMasterFiles_SCOServer;
        private MetroFramework.Controls.MetroButton btnUpdateConnection;
        private MetroFramework.Controls.MetroTextBox txtMasterNamosSTN;
        private MetroFramework.Controls.MetroLabel lblMasterNamosSTN;
        private MetroFramework.Controls.MetroLabel lblExcludeSites;
        private MetroFramework.Controls.MetroLabel lblLocation;
        private MetroFramework.Controls.MetroLabel lblTaskName;
        private MetroFramework.Controls.MetroLabel lblServicesExcludeSites;
        private MetroFramework.Controls.MetroLabel lblServiceName;
        private MetroFramework.Controls.MetroLabel lblServiceDisplay;
        private MetroFramework.Controls.MetroButton btnDeteteServices;
        private MetroFramework.Controls.MetroGrid gridServices;
        private MetroFramework.Controls.MetroButton btnUpdateServices;
        public MetroFramework.Controls.MetroButton btnAddServices;
        private MetroFramework.Controls.MetroCheckBox chkServicesEnable;
        private MetroFramework.Controls.MetroTextBox txtServiceName;
        private MetroFramework.Controls.MetroTextBox txtServicesLocation;
        private MetroFramework.Controls.MetroTextBox txtServiceDisplay;
        private MetroFramework.Controls.MetroLabel lblServicesLocaiton;
        private MetroFramework.Controls.MetroTextBox txtServicesExcludeSites;
    }
}

