﻿namespace Dead_Matter_Server_Manager
{
    partial class ServerManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerManager));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.steamCMDBrowse = new System.Windows.Forms.Button();
            this.serverFolderBrowse = new System.Windows.Forms.Button();
            this.steamCMDPath = new System.Windows.Forms.TextBox();
            this.serverFolderPath = new System.Windows.Forms.TextBox();
            this.updateSteamCMD = new System.Windows.Forms.Button();
            this.steamID = new System.Windows.Forms.TextBox();
            this.steamPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateServer = new System.Windows.Forms.Button();
            this.getConfig = new System.Windows.Forms.Button();
            this.saveConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maxServerMemory = new System.Windows.Forms.TextBox();
            this.startServer = new System.Windows.Forms.Button();
            this.memoryUsed = new System.Windows.Forms.Label();
            this.stopServer = new System.Windows.Forms.Button();
            this.serverStatus = new System.Windows.Forms.Label();
            this.memoryUsedProgressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.configSettings = new System.Windows.Forms.DataGridView();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Script = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IniFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.whitelistDGV = new System.Windows.Forms.DataGridView();
            this.whiteListPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDGV = new System.Windows.Forms.DataGridView();
            this.adminPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superAdminDGV = new System.Windows.Forms.DataGridView();
            this.superAdminPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverTagsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.serverTagsDGV = new System.Windows.Forms.DataGridView();
            this.serverTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.playersOnlineTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.playersOnlineDGV = new System.Windows.Forms.DataGridView();
            this.playerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshOnlinePlayerList = new System.Windows.Forms.Button();
            this.statisticsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.enableLogging = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.uptimeLbl = new System.Windows.Forms.Label();
            this.serverUptime = new System.Windows.Forms.Label();
            this.autoStartWithWindows = new System.Windows.Forms.CheckBox();
            this.autoStartServer = new System.Windows.Forms.CheckBox();
            this.updateSoftware = new System.Windows.Forms.LinkLabel();
            this.restartServerTimelbl = new System.Windows.Forms.Label();
            this.restartServerTime = new System.Windows.Forms.TextBox();
            this.restartServerTimeOption = new System.Windows.Forms.CheckBox();
            this.rememberSteamPass = new System.Windows.Forms.CheckBox();
            this.onlinePlayers = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.restartsThisSessionTxt = new System.Windows.Forms.Label();
            this.lastRestartTxt = new System.Windows.Forms.Label();
            this.checkUpdateOnStart = new System.Windows.Forms.CheckBox();
            this.changeLaunchParams = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.launchParameters = new System.Windows.Forms.TextBox();
            this.saveConfigOnStart = new System.Windows.Forms.CheckBox();
            this.restartServer = new System.Windows.Forms.Button();
            this.allTimeHighPlayersLbl = new System.Windows.Forms.Label();
            this.longestUptimeLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configSettings)).BeginInit();
            this.userTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whitelistDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superAdminDGV)).BeginInit();
            this.serverTagsTabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverTagsDGV)).BeginInit();
            this.playersOnlineTabPage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersOnlineDGV)).BeginInit();
            this.statisticsTabPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.steamCMDBrowse, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.serverFolderBrowse, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.steamCMDPath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.serverFolderPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.updateSteamCMD, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.steamID, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.steamPassword, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.updateServer, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.getConfig, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveConfig, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.maxServerMemory, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.startServer, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.stopServer, 7, 9);
            this.tableLayoutPanel1.Controls.Add(this.serverStatus, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.memoryUsedProgressBar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 7, 10);
            this.tableLayoutPanel1.Controls.Add(this.uptimeLbl, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.serverUptime, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.autoStartWithWindows, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.autoStartServer, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.updateSoftware, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.restartServerTimelbl, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.restartServerTime, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.restartServerTimeOption, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.rememberSteamPass, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel2, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.changeLaunchParams, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.launchParameters, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.saveConfigOnStart, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.restartServer, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.checkUpdateOnStart, 6, 10);
            this.tableLayoutPanel1.Controls.Add(this.onlinePlayers, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.restartsThisSessionTxt, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lastRestartTxt, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.memoryUsed, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.allTimeHighPlayersLbl, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.longestUptimeLbl, 4, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1145, 670);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Steam CMD Path";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server Folder Path";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // steamCMDBrowse
            // 
            this.steamCMDBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steamCMDBrowse.Location = new System.Drawing.Point(362, 28);
            this.steamCMDBrowse.Name = "steamCMDBrowse";
            this.steamCMDBrowse.Size = new System.Drawing.Size(143, 24);
            this.steamCMDBrowse.TabIndex = 3;
            this.steamCMDBrowse.Text = "Browse";
            this.steamCMDBrowse.UseVisualStyleBackColor = true;
            this.steamCMDBrowse.Click += new System.EventHandler(this.steamCMDBrowse_Click);
            // 
            // serverFolderBrowse
            // 
            this.serverFolderBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverFolderBrowse.Location = new System.Drawing.Point(362, 58);
            this.serverFolderBrowse.Name = "serverFolderBrowse";
            this.serverFolderBrowse.Size = new System.Drawing.Size(143, 24);
            this.serverFolderBrowse.TabIndex = 4;
            this.serverFolderBrowse.Text = "Browse";
            this.serverFolderBrowse.UseVisualStyleBackColor = true;
            this.serverFolderBrowse.Click += new System.EventHandler(this.serverFolderBrowse_Click);
            // 
            // steamCMDPath
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.steamCMDPath, 2);
            this.steamCMDPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steamCMDPath.Location = new System.Drawing.Point(121, 28);
            this.steamCMDPath.Name = "steamCMDPath";
            this.steamCMDPath.Size = new System.Drawing.Size(235, 20);
            this.steamCMDPath.TabIndex = 5;
            // 
            // serverFolderPath
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.serverFolderPath, 2);
            this.serverFolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverFolderPath.Location = new System.Drawing.Point(121, 58);
            this.serverFolderPath.Name = "serverFolderPath";
            this.serverFolderPath.Size = new System.Drawing.Size(235, 20);
            this.serverFolderPath.TabIndex = 6;
            // 
            // updateSteamCMD
            // 
            this.updateSteamCMD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateSteamCMD.Location = new System.Drawing.Point(511, 28);
            this.updateSteamCMD.Name = "updateSteamCMD";
            this.updateSteamCMD.Size = new System.Drawing.Size(148, 24);
            this.updateSteamCMD.TabIndex = 7;
            this.updateSteamCMD.Text = "Update SteamCMD";
            this.updateSteamCMD.UseVisualStyleBackColor = true;
            this.updateSteamCMD.Click += new System.EventHandler(this.updateSteamCMD_Click);
            // 
            // steamID
            // 
            this.steamID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steamID.Location = new System.Drawing.Point(954, 28);
            this.steamID.Name = "steamID";
            this.steamID.Size = new System.Drawing.Size(188, 20);
            this.steamID.TabIndex = 8;
            this.steamID.Leave += new System.EventHandler(this.steamID_Leave);
            // 
            // steamPassword
            // 
            this.steamPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steamPassword.Location = new System.Drawing.Point(954, 58);
            this.steamPassword.Name = "steamPassword";
            this.steamPassword.PasswordChar = '*';
            this.steamPassword.Size = new System.Drawing.Size(188, 20);
            this.steamPassword.TabIndex = 9;
            this.steamPassword.Leave += new System.EventHandler(this.steamPassword_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(807, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Steam ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(807, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Steam Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updateServer
            // 
            this.updateServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateServer.Location = new System.Drawing.Point(665, 28);
            this.updateServer.Name = "updateServer";
            this.updateServer.Size = new System.Drawing.Size(136, 24);
            this.updateServer.TabIndex = 13;
            this.updateServer.Text = "Update Server";
            this.updateServer.UseVisualStyleBackColor = true;
            this.updateServer.Click += new System.EventHandler(this.updateServer_Click);
            // 
            // getConfig
            // 
            this.getConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getConfig.Location = new System.Drawing.Point(511, 58);
            this.getConfig.Name = "getConfig";
            this.getConfig.Size = new System.Drawing.Size(148, 24);
            this.getConfig.TabIndex = 14;
            this.getConfig.Text = "Get Config";
            this.getConfig.UseVisualStyleBackColor = true;
            this.getConfig.Click += new System.EventHandler(this.getConfig_Click);
            // 
            // saveConfig
            // 
            this.saveConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveConfig.Location = new System.Drawing.Point(665, 58);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(136, 24);
            this.saveConfig.TabIndex = 17;
            this.saveConfig.Text = "Save Config";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(807, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Max Server Memory (GB)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxServerMemory
            // 
            this.maxServerMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxServerMemory.Location = new System.Drawing.Point(954, 519);
            this.maxServerMemory.Name = "maxServerMemory";
            this.maxServerMemory.Size = new System.Drawing.Size(188, 20);
            this.maxServerMemory.TabIndex = 19;
            this.maxServerMemory.Leave += new System.EventHandler(this.maxServerMemory_Leave);
            // 
            // startServer
            // 
            this.startServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startServer.Location = new System.Drawing.Point(954, 579);
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(188, 24);
            this.startServer.TabIndex = 20;
            this.startServer.Text = "Start Server";
            this.startServer.UseVisualStyleBackColor = true;
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // memoryUsed
            // 
            this.memoryUsed.AutoSize = true;
            this.memoryUsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryUsed.Location = new System.Drawing.Point(362, 516);
            this.memoryUsed.Name = "memoryUsed";
            this.memoryUsed.Size = new System.Drawing.Size(143, 30);
            this.memoryUsed.TabIndex = 21;
            this.memoryUsed.Text = "memused";
            this.memoryUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopServer
            // 
            this.stopServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopServer.Location = new System.Drawing.Point(954, 609);
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(188, 24);
            this.stopServer.TabIndex = 22;
            this.stopServer.Text = "Stop Server";
            this.stopServer.UseVisualStyleBackColor = true;
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // serverStatus
            // 
            this.serverStatus.AutoSize = true;
            this.serverStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStatus.ForeColor = System.Drawing.Color.Red;
            this.serverStatus.Location = new System.Drawing.Point(3, 516);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(112, 30);
            this.serverStatus.TabIndex = 23;
            this.serverStatus.Text = "SERVER OFFLINE";
            this.serverStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memoryUsedProgressBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.memoryUsedProgressBar, 2);
            this.memoryUsedProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryUsedProgressBar.Location = new System.Drawing.Point(121, 519);
            this.memoryUsedProgressBar.Name = "memoryUsedProgressBar";
            this.memoryUsedProgressBar.Size = new System.Drawing.Size(235, 24);
            this.memoryUsedProgressBar.TabIndex = 24;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 8);
            this.tabControl1.Controls.Add(this.settingsTabPage);
            this.tabControl1.Controls.Add(this.userTabPage);
            this.tabControl1.Controls.Add(this.serverTagsTabPage);
            this.tabControl1.Controls.Add(this.playersOnlineTabPage);
            this.tabControl1.Controls.Add(this.statisticsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 111);
            this.tabControl1.Name = "tabControl1";
            this.tableLayoutPanel1.SetRowSpan(this.tabControl1, 2);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 402);
            this.tabControl1.TabIndex = 25;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.settingsTabPage.Controls.Add(this.configSettings);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(1131, 376);
            this.settingsTabPage.TabIndex = 1;
            this.settingsTabPage.Text = "Settings";
            // 
            // configSettings
            // 
            this.configSettings.AllowUserToAddRows = false;
            this.configSettings.AllowUserToDeleteRows = false;
            this.configSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.configSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variable,
            this.Value,
            this.Script,
            this.IniFile,
            this.Info});
            this.configSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configSettings.Location = new System.Drawing.Point(3, 3);
            this.configSettings.Name = "configSettings";
            this.configSettings.Size = new System.Drawing.Size(1125, 370);
            this.configSettings.TabIndex = 16;
            // 
            // Variable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Variable.DefaultCellStyle = dataGridViewCellStyle1;
            this.Variable.HeaderText = "Variable";
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Script
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Script.DefaultCellStyle = dataGridViewCellStyle2;
            this.Script.HeaderText = "Script Location";
            this.Script.Name = "Script";
            this.Script.ReadOnly = true;
            // 
            // IniFile
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IniFile.DefaultCellStyle = dataGridViewCellStyle3;
            this.IniFile.HeaderText = "Ini File";
            this.IniFile.Name = "IniFile";
            this.IniFile.ReadOnly = true;
            // 
            // Info
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Info.DefaultCellStyle = dataGridViewCellStyle4;
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            // 
            // userTabPage
            // 
            this.userTabPage.BackColor = System.Drawing.Color.Transparent;
            this.userTabPage.Controls.Add(this.tableLayoutPanel2);
            this.userTabPage.Location = new System.Drawing.Point(4, 22);
            this.userTabPage.Name = "userTabPage";
            this.userTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userTabPage.Size = new System.Drawing.Size(1131, 380);
            this.userTabPage.TabIndex = 0;
            this.userTabPage.Text = "Admin/Whitelist";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.whitelistDGV, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.adminDGV, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.superAdminDGV, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 374F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1125, 374);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // whitelistDGV
            // 
            this.whitelistDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.whitelistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.whitelistDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.whiteListPlayers});
            this.whitelistDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whitelistDGV.Location = new System.Drawing.Point(3, 3);
            this.whitelistDGV.Name = "whitelistDGV";
            this.whitelistDGV.Size = new System.Drawing.Size(369, 368);
            this.whitelistDGV.TabIndex = 0;
            // 
            // whiteListPlayers
            // 
            this.whiteListPlayers.HeaderText = "Whitelist Players (Steam64 ID)";
            this.whiteListPlayers.Name = "whiteListPlayers";
            // 
            // adminDGV
            // 
            this.adminDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminPlayers});
            this.adminDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminDGV.Location = new System.Drawing.Point(378, 3);
            this.adminDGV.Name = "adminDGV";
            this.adminDGV.Size = new System.Drawing.Size(369, 368);
            this.adminDGV.TabIndex = 1;
            // 
            // adminPlayers
            // 
            this.adminPlayers.HeaderText = "Admin Players (Steam64 ID)";
            this.adminPlayers.Name = "adminPlayers";
            // 
            // superAdminDGV
            // 
            this.superAdminDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.superAdminDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.superAdminDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.superAdminPlayers});
            this.superAdminDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superAdminDGV.Location = new System.Drawing.Point(753, 3);
            this.superAdminDGV.Name = "superAdminDGV";
            this.superAdminDGV.Size = new System.Drawing.Size(369, 368);
            this.superAdminDGV.TabIndex = 2;
            // 
            // superAdminPlayers
            // 
            this.superAdminPlayers.HeaderText = "Super Admin Players (Steam64 ID)";
            this.superAdminPlayers.Name = "superAdminPlayers";
            // 
            // serverTagsTabPage
            // 
            this.serverTagsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.serverTagsTabPage.Controls.Add(this.tableLayoutPanel3);
            this.serverTagsTabPage.Location = new System.Drawing.Point(4, 22);
            this.serverTagsTabPage.Name = "serverTagsTabPage";
            this.serverTagsTabPage.Size = new System.Drawing.Size(1131, 380);
            this.serverTagsTabPage.TabIndex = 2;
            this.serverTagsTabPage.Text = "Server Tags";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.serverTagsDGV, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1131, 380);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // serverTagsDGV
            // 
            this.serverTagsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverTagsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serverTags});
            this.serverTagsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverTagsDGV.Location = new System.Drawing.Point(3, 3);
            this.serverTagsDGV.Name = "serverTagsDGV";
            this.tableLayoutPanel3.SetRowSpan(this.serverTagsDGV, 2);
            this.serverTagsDGV.Size = new System.Drawing.Size(842, 374);
            this.serverTagsDGV.TabIndex = 0;
            // 
            // serverTags
            // 
            this.serverTags.HeaderText = "Server Tags";
            this.serverTags.Name = "serverTags";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(851, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 190);
            this.label6.TabIndex = 1;
            this.label6.Text = "Server tags format example:\r\n\r\nPVP:No KOS\r\nRP:Casual\r\nCountry:GB";
            // 
            // playersOnlineTabPage
            // 
            this.playersOnlineTabPage.BackColor = System.Drawing.Color.Transparent;
            this.playersOnlineTabPage.Controls.Add(this.tableLayoutPanel4);
            this.playersOnlineTabPage.Location = new System.Drawing.Point(4, 22);
            this.playersOnlineTabPage.Name = "playersOnlineTabPage";
            this.playersOnlineTabPage.Size = new System.Drawing.Size(1131, 380);
            this.playersOnlineTabPage.TabIndex = 3;
            this.playersOnlineTabPage.Text = "Online Players";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.playersOnlineDGV, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.refreshOnlinePlayerList, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1131, 380);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // playersOnlineDGV
            // 
            this.playersOnlineDGV.AllowUserToAddRows = false;
            this.playersOnlineDGV.AllowUserToDeleteRows = false;
            this.playersOnlineDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playersOnlineDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersOnlineDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerName,
            this.connectionDuration});
            this.playersOnlineDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersOnlineDGV.Location = new System.Drawing.Point(3, 3);
            this.playersOnlineDGV.Name = "playersOnlineDGV";
            this.playersOnlineDGV.ReadOnly = true;
            this.tableLayoutPanel4.SetRowSpan(this.playersOnlineDGV, 2);
            this.playersOnlineDGV.Size = new System.Drawing.Size(559, 374);
            this.playersOnlineDGV.TabIndex = 0;
            // 
            // playerName
            // 
            this.playerName.HeaderText = "Player Name";
            this.playerName.Name = "playerName";
            this.playerName.ReadOnly = true;
            // 
            // connectionDuration
            // 
            this.connectionDuration.HeaderText = "Connection Duration";
            this.connectionDuration.Name = "connectionDuration";
            this.connectionDuration.ReadOnly = true;
            // 
            // refreshOnlinePlayerList
            // 
            this.refreshOnlinePlayerList.Location = new System.Drawing.Point(568, 3);
            this.refreshOnlinePlayerList.Name = "refreshOnlinePlayerList";
            this.refreshOnlinePlayerList.Size = new System.Drawing.Size(75, 23);
            this.refreshOnlinePlayerList.TabIndex = 1;
            this.refreshOnlinePlayerList.Text = "Refresh";
            this.refreshOnlinePlayerList.UseVisualStyleBackColor = true;
            this.refreshOnlinePlayerList.Click += new System.EventHandler(this.refreshOnlinePlayerList_Click);
            // 
            // statisticsTabPage
            // 
            this.statisticsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.statisticsTabPage.Controls.Add(this.tableLayoutPanel5);
            this.statisticsTabPage.Location = new System.Drawing.Point(4, 22);
            this.statisticsTabPage.Name = "statisticsTabPage";
            this.statisticsTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statisticsTabPage.Size = new System.Drawing.Size(1131, 380);
            this.statisticsTabPage.TabIndex = 4;
            this.statisticsTabPage.Text = "Logs";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.enableLogging, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.578948F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.42105F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1131, 380);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // enableLogging
            // 
            this.enableLogging.AutoSize = true;
            this.enableLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enableLogging.Location = new System.Drawing.Point(3, 3);
            this.enableLogging.Name = "enableLogging";
            this.enableLogging.Size = new System.Drawing.Size(559, 19);
            this.enableLogging.TabIndex = 0;
            this.enableLogging.Text = "Enable Logging";
            this.enableLogging.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel5.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(3, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1125, 349);
            this.textBox1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Location = new System.Drawing.Point(954, 636);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(188, 29);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Buy me a beer ;)";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // uptimeLbl
            // 
            this.uptimeLbl.AutoSize = true;
            this.uptimeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uptimeLbl.Location = new System.Drawing.Point(3, 546);
            this.uptimeLbl.Name = "uptimeLbl";
            this.uptimeLbl.Size = new System.Drawing.Size(112, 30);
            this.uptimeLbl.TabIndex = 27;
            this.uptimeLbl.Text = "Server Uptime:";
            this.uptimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // serverUptime
            // 
            this.serverUptime.AutoSize = true;
            this.serverUptime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverUptime.Location = new System.Drawing.Point(121, 546);
            this.serverUptime.Name = "serverUptime";
            this.serverUptime.Size = new System.Drawing.Size(86, 30);
            this.serverUptime.TabIndex = 28;
            this.serverUptime.Text = "00:00:00";
            this.serverUptime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoStartWithWindows
            // 
            this.autoStartWithWindows.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.autoStartWithWindows, 2);
            this.autoStartWithWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoStartWithWindows.Location = new System.Drawing.Point(3, 609);
            this.autoStartWithWindows.Name = "autoStartWithWindows";
            this.autoStartWithWindows.Size = new System.Drawing.Size(204, 24);
            this.autoStartWithWindows.TabIndex = 29;
            this.autoStartWithWindows.Text = "Auto Start with Windows";
            this.autoStartWithWindows.UseVisualStyleBackColor = true;
            this.autoStartWithWindows.CheckedChanged += new System.EventHandler(this.autoStartWithWindows_CheckedChanged);
            // 
            // autoStartServer
            // 
            this.autoStartServer.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.autoStartServer, 2);
            this.autoStartServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoStartServer.Location = new System.Drawing.Point(3, 639);
            this.autoStartServer.Name = "autoStartServer";
            this.autoStartServer.Size = new System.Drawing.Size(204, 23);
            this.autoStartServer.TabIndex = 30;
            this.autoStartServer.Text = "Auto Start Server on Launch";
            this.autoStartServer.UseVisualStyleBackColor = true;
            this.autoStartServer.CheckedChanged += new System.EventHandler(this.autoStartServer_CheckedChanged);
            // 
            // updateSoftware
            // 
            this.updateSoftware.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.updateSoftware, 2);
            this.updateSoftware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateSoftware.Location = new System.Drawing.Point(3, 0);
            this.updateSoftware.Name = "updateSoftware";
            this.updateSoftware.Size = new System.Drawing.Size(204, 25);
            this.updateSoftware.TabIndex = 31;
            this.updateSoftware.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateSoftware_LinkClicked);
            // 
            // restartServerTimelbl
            // 
            this.restartServerTimelbl.AutoSize = true;
            this.restartServerTimelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartServerTimelbl.Location = new System.Drawing.Point(807, 546);
            this.restartServerTimelbl.Name = "restartServerTimelbl";
            this.restartServerTimelbl.Size = new System.Drawing.Size(141, 30);
            this.restartServerTimelbl.TabIndex = 32;
            this.restartServerTimelbl.Text = "Restart Server Time (Mins)";
            this.restartServerTimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // restartServerTime
            // 
            this.restartServerTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartServerTime.Location = new System.Drawing.Point(954, 549);
            this.restartServerTime.Name = "restartServerTime";
            this.restartServerTime.Size = new System.Drawing.Size(188, 20);
            this.restartServerTime.TabIndex = 33;
            this.restartServerTime.Leave += new System.EventHandler(this.restartServerTime_Leave);
            // 
            // restartServerTimeOption
            // 
            this.restartServerTimeOption.AutoSize = true;
            this.restartServerTimeOption.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restartServerTimeOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartServerTimeOption.Location = new System.Drawing.Point(665, 549);
            this.restartServerTimeOption.Name = "restartServerTimeOption";
            this.restartServerTimeOption.Size = new System.Drawing.Size(136, 24);
            this.restartServerTimeOption.TabIndex = 34;
            this.restartServerTimeOption.Text = "Timed Restart";
            this.restartServerTimeOption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.restartServerTimeOption.UseVisualStyleBackColor = true;
            this.restartServerTimeOption.CheckedChanged += new System.EventHandler(this.restartServerTimeOption_CheckedChanged);
            // 
            // rememberSteamPass
            // 
            this.rememberSteamPass.AutoSize = true;
            this.rememberSteamPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rememberSteamPass.Location = new System.Drawing.Point(954, 88);
            this.rememberSteamPass.Name = "rememberSteamPass";
            this.rememberSteamPass.Size = new System.Drawing.Size(188, 17);
            this.rememberSteamPass.TabIndex = 35;
            this.rememberSteamPass.Text = "Remember Steam Password";
            this.rememberSteamPass.UseVisualStyleBackColor = true;
            this.rememberSteamPass.CheckedChanged += new System.EventHandler(this.rememberSteamPass_CheckedChanged);
            // 
            // onlinePlayers
            // 
            this.onlinePlayers.AutoSize = true;
            this.onlinePlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlinePlayers.Location = new System.Drawing.Point(511, 516);
            this.onlinePlayers.Name = "onlinePlayers";
            this.onlinePlayers.Size = new System.Drawing.Size(148, 30);
            this.onlinePlayers.TabIndex = 36;
            this.onlinePlayers.Text = "Online Players\r\n0/0";
            this.onlinePlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel2.Location = new System.Drawing.Point(954, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(188, 25);
            this.linkLabel2.TabIndex = 37;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Change log";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // restartsThisSessionTxt
            // 
            this.restartsThisSessionTxt.AutoSize = true;
            this.restartsThisSessionTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartsThisSessionTxt.Location = new System.Drawing.Point(362, 546);
            this.restartsThisSessionTxt.Name = "restartsThisSessionTxt";
            this.restartsThisSessionTxt.Size = new System.Drawing.Size(143, 30);
            this.restartsThisSessionTxt.TabIndex = 38;
            this.restartsThisSessionTxt.Text = "Restarts This Session\r\n0";
            this.restartsThisSessionTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastRestartTxt
            // 
            this.lastRestartTxt.AutoSize = true;
            this.lastRestartTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastRestartTxt.Location = new System.Drawing.Point(511, 546);
            this.lastRestartTxt.Name = "lastRestartTxt";
            this.lastRestartTxt.Size = new System.Drawing.Size(148, 30);
            this.lastRestartTxt.TabIndex = 39;
            this.lastRestartTxt.Text = "Last Restart\r\n00/00/0000 00:00:00";
            this.lastRestartTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkUpdateOnStart
            // 
            this.checkUpdateOnStart.AutoSize = true;
            this.checkUpdateOnStart.Location = new System.Drawing.Point(807, 639);
            this.checkUpdateOnStart.Name = "checkUpdateOnStart";
            this.checkUpdateOnStart.Size = new System.Drawing.Size(141, 17);
            this.checkUpdateOnStart.TabIndex = 15;
            this.checkUpdateOnStart.Text = "Check for Update on Server Start";
            this.checkUpdateOnStart.UseVisualStyleBackColor = true;
            this.checkUpdateOnStart.Visible = false;
            this.checkUpdateOnStart.CheckedChanged += new System.EventHandler(this.checkUpdateOnStart_CheckedChanged);
            // 
            // changeLaunchParams
            // 
            this.changeLaunchParams.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.changeLaunchParams, 2);
            this.changeLaunchParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeLaunchParams.Location = new System.Drawing.Point(362, 88);
            this.changeLaunchParams.Name = "changeLaunchParams";
            this.changeLaunchParams.Size = new System.Drawing.Size(297, 17);
            this.changeLaunchParams.TabIndex = 40;
            this.changeLaunchParams.Text = "Change Launch Parameters";
            this.changeLaunchParams.UseVisualStyleBackColor = true;
            this.changeLaunchParams.CheckedChanged += new System.EventHandler(this.changeLaunchParams_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Launch Parameters";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // launchParameters
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.launchParameters, 2);
            this.launchParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launchParameters.Location = new System.Drawing.Point(121, 88);
            this.launchParameters.Name = "launchParameters";
            this.launchParameters.ReadOnly = true;
            this.launchParameters.Size = new System.Drawing.Size(235, 20);
            this.launchParameters.TabIndex = 42;
            this.launchParameters.Text = "-USEALLAVAILABLECORES -log";
            this.launchParameters.Leave += new System.EventHandler(this.launchParameters_Leave);
            // 
            // saveConfigOnStart
            // 
            this.saveConfigOnStart.AutoSize = true;
            this.saveConfigOnStart.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveConfigOnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveConfigOnStart.Location = new System.Drawing.Point(807, 579);
            this.saveConfigOnStart.Name = "saveConfigOnStart";
            this.saveConfigOnStart.Size = new System.Drawing.Size(141, 24);
            this.saveConfigOnStart.TabIndex = 43;
            this.saveConfigOnStart.Text = "Save Config on Start";
            this.saveConfigOnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveConfigOnStart.UseVisualStyleBackColor = true;
            this.saveConfigOnStart.CheckedChanged += new System.EventHandler(this.saveConfigOnStart_CheckedChanged);
            // 
            // restartServer
            // 
            this.restartServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartServer.Location = new System.Drawing.Point(807, 609);
            this.restartServer.Name = "restartServer";
            this.restartServer.Size = new System.Drawing.Size(141, 24);
            this.restartServer.TabIndex = 44;
            this.restartServer.Text = "Restart Server";
            this.restartServer.UseVisualStyleBackColor = true;
            this.restartServer.Click += new System.EventHandler(this.restartServer_Click);
            // 
            // allTimeHighPlayersLbl
            // 
            this.allTimeHighPlayersLbl.AutoSize = true;
            this.allTimeHighPlayersLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allTimeHighPlayersLbl.Location = new System.Drawing.Point(362, 576);
            this.allTimeHighPlayersLbl.Name = "allTimeHighPlayersLbl";
            this.allTimeHighPlayersLbl.Size = new System.Drawing.Size(143, 30);
            this.allTimeHighPlayersLbl.TabIndex = 45;
            this.allTimeHighPlayersLbl.Text = "All Time High Players\r\n0";
            this.allTimeHighPlayersLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // longestUptimeLbl
            // 
            this.longestUptimeLbl.AutoSize = true;
            this.longestUptimeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longestUptimeLbl.Location = new System.Drawing.Point(511, 576);
            this.longestUptimeLbl.Name = "longestUptimeLbl";
            this.longestUptimeLbl.Size = new System.Drawing.Size(148, 30);
            this.longestUptimeLbl.TabIndex = 46;
            this.longestUptimeLbl.Text = "Longest Uptime\r\n00:00:00";
            this.longestUptimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 670);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerManager";
            this.Text = "Dead Matter Server Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configSettings)).EndInit();
            this.userTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.whitelistDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superAdminDGV)).EndInit();
            this.serverTagsTabPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverTagsDGV)).EndInit();
            this.playersOnlineTabPage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersOnlineDGV)).EndInit();
            this.statisticsTabPage.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button steamCMDBrowse;
        private System.Windows.Forms.Button serverFolderBrowse;
        private System.Windows.Forms.TextBox steamCMDPath;
        private System.Windows.Forms.TextBox serverFolderPath;
        private System.Windows.Forms.Button updateSteamCMD;
        private System.Windows.Forms.TextBox steamID;
        private System.Windows.Forms.TextBox steamPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateServer;
        private System.Windows.Forms.Button getConfig;
        private System.Windows.Forms.CheckBox checkUpdateOnStart;
        private System.Windows.Forms.DataGridView configSettings;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxServerMemory;
        private System.Windows.Forms.Button startServer;
        private System.Windows.Forms.Label memoryUsed;
        private System.Windows.Forms.Button stopServer;
        private System.Windows.Forms.Label serverStatus;
        private System.Windows.Forms.ProgressBar memoryUsedProgressBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.TabPage userTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView whitelistDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn whiteListPlayers;
        private System.Windows.Forms.DataGridView adminDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminPlayers;
        private System.Windows.Forms.DataGridView superAdminDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn superAdminPlayers;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label uptimeLbl;
        private System.Windows.Forms.Label serverUptime;
        private System.Windows.Forms.CheckBox autoStartWithWindows;
        private System.Windows.Forms.CheckBox autoStartServer;
        private System.Windows.Forms.LinkLabel updateSoftware;
        private System.Windows.Forms.Label restartServerTimelbl;
        private System.Windows.Forms.TextBox restartServerTime;
        private System.Windows.Forms.CheckBox restartServerTimeOption;
        private System.Windows.Forms.CheckBox rememberSteamPass;
        private System.Windows.Forms.TabPage serverTagsTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView serverTagsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverTags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label onlinePlayers;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label restartsThisSessionTxt;
        private System.Windows.Forms.Label lastRestartTxt;
        private System.Windows.Forms.TabPage playersOnlineTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView playersOnlineDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionDuration;
        private System.Windows.Forms.Button refreshOnlinePlayerList;
        private System.Windows.Forms.CheckBox changeLaunchParams;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox launchParameters;
        private System.Windows.Forms.CheckBox saveConfigOnStart;
        private System.Windows.Forms.Button restartServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Script;
        private System.Windows.Forms.DataGridViewTextBoxColumn IniFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.TabPage statisticsTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox enableLogging;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label allTimeHighPlayersLbl;
        private System.Windows.Forms.Label longestUptimeLbl;
    }
}

