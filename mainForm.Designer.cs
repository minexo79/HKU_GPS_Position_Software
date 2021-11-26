﻿
namespace GPS_Resuce_Receiver_GUI
{
    partial class mainForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbxComPort = new System.Windows.Forms.ToolStripComboBox();
            this.tbxBaud = new System.Windows.Forms.ToolStripTextBox();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.btnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshPort = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLongtitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browserMap = new CefSharp.WinForms.ChromiumWebBrowser();
            this.tbSelectDeviceID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeviceID = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.gbConfig.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbxComPort,
            this.tbxBaud,
            this.btnConnect,
            this.btnDisconnect,
            this.btnAbout,
            this.btnRefreshPort});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(964, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbxComPort
            // 
            this.cbxComPort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxComPort.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.Size = new System.Drawing.Size(159, 29);
            this.cbxComPort.Text = "端口選擇...";
            this.cbxComPort.ToolTipText = "與接收器的傳輸端口，可至設備管理器查看。";
            // 
            // tbxBaud
            // 
            this.tbxBaud.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbxBaud.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.tbxBaud.Name = "tbxBaud";
            this.tbxBaud.Size = new System.Drawing.Size(100, 29);
            this.tbxBaud.Text = "9600";
            this.tbxBaud.ToolTipText = "與接收器的傳輸速率，一般皆設9600bps。";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnConnect.Image = global::GPS_Resuce_Receiver_GUI.Properties.Resources.link;
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(57, 26);
            this.btnConnect.Text = "連線";
            this.btnConnect.ToolTipText = "與接收器建立連線。";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDisconnect.Image = global::GPS_Resuce_Receiver_GUI.Properties.Resources.unlink;
            this.btnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(85, 26);
            this.btnDisconnect.Text = "中斷連線";
            this.btnDisconnect.ToolTipText = "與接收器斷開連線。";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAbout.Image = global::GPS_Resuce_Receiver_GUI.Properties.Resources.info;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(66, 26);
            this.btnAbout.Text = "關於...";
            // 
            // btnRefreshPort
            // 
            this.btnRefreshPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefreshPort.Image = global::GPS_Resuce_Receiver_GUI.Properties.Resources.refresh;
            this.btnRefreshPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshPort.Name = "btnRefreshPort";
            this.btnRefreshPort.Size = new System.Drawing.Size(85, 26);
            this.btnRefreshPort.Text = "重新整理";
            this.btnRefreshPort.Click += new System.EventHandler(this.btnRefreshPort_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.splitContainer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 33);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gbHistory);
            this.splitContainer.Panel1.Controls.Add(this.gbConfig);
            this.splitContainer.Panel1.Controls.Add(this.gbInfo);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer.Panel2.Controls.Add(this.browserMap);
            this.splitContainer.Size = new System.Drawing.Size(964, 558);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 2;
            // 
            // gbHistory
            // 
            this.gbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHistory.Location = new System.Drawing.Point(0, 382);
            this.gbHistory.Margin = new System.Windows.Forms.Padding(10);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbHistory.Size = new System.Drawing.Size(200, 176);
            this.gbHistory.TabIndex = 2;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "歷史紀錄";
            // 
            // gbConfig
            // 
            this.gbConfig.BackColor = System.Drawing.SystemColors.Control;
            this.gbConfig.Controls.Add(this.btnDeviceID);
            this.gbConfig.Controls.Add(this.label5);
            this.gbConfig.Controls.Add(this.tbSelectDeviceID);
            this.gbConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbConfig.Location = new System.Drawing.Point(0, 252);
            this.gbConfig.Margin = new System.Windows.Forms.Padding(10);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbConfig.Size = new System.Drawing.Size(200, 130);
            this.gbConfig.TabIndex = 1;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "傳輸設定";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.tbTime);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.tbLatitude);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.tbLongtitude);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.tbClientID);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfo.Location = new System.Drawing.Point(0, 0);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(10);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfo.Size = new System.Drawing.Size(200, 252);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "資訊概要";
            // 
            // tbTime
            // 
            this.tbTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.tbTime.Location = new System.Drawing.Point(9, 98);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(185, 33);
            this.tbTime.TabIndex = 8;
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "裝置時間";
            // 
            // tbLatitude
            // 
            this.tbLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLatitude.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.tbLatitude.Location = new System.Drawing.Point(9, 212);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(185, 33);
            this.tbLatitude.TabIndex = 5;
            this.tbLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "緯度";
            // 
            // tbLongtitude
            // 
            this.tbLongtitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLongtitude.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.tbLongtitude.Location = new System.Drawing.Point(9, 155);
            this.tbLongtitude.Name = "tbLongtitude";
            this.tbLongtitude.Size = new System.Drawing.Size(185, 33);
            this.tbLongtitude.TabIndex = 3;
            this.tbLongtitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "經度";
            // 
            // tbClientID
            // 
            this.tbClientID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.tbClientID.Location = new System.Drawing.Point(9, 42);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(185, 33);
            this.tbClientID.TabIndex = 1;
            this.tbClientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "裝置ID";
            // 
            // browserMap
            // 
            this.browserMap.ActivateBrowserOnCreation = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.browserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserMap.Location = new System.Drawing.Point(0, 0);
            this.browserMap.Name = "browserMap";
            this.browserMap.Size = new System.Drawing.Size(758, 558);
            this.browserMap.TabIndex = 2;
            // 
            // tbSelectDeviceID
            // 
            this.tbSelectDeviceID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectDeviceID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.tbSelectDeviceID.Location = new System.Drawing.Point(9, 42);
            this.tbSelectDeviceID.Name = "tbSelectDeviceID";
            this.tbSelectDeviceID.Size = new System.Drawing.Size(185, 33);
            this.tbSelectDeviceID.TabIndex = 6;
            this.tbSelectDeviceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "指定裝置編號";
            // 
            // btnDeviceID
            // 
            this.btnDeviceID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeviceID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeviceID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeviceID.Location = new System.Drawing.Point(9, 85);
            this.btnDeviceID.Name = "btnDeviceID";
            this.btnDeviceID.Size = new System.Drawing.Size(185, 32);
            this.btnDeviceID.TabIndex = 10;
            this.btnDeviceID.Text = "裝置編號確認";
            this.btnDeviceID.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::GPS_Resuce_Receiver_GUI.Properties.Resources.tutorial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 591);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(980, 630);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登山救援系統V1.0";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbxComPort;
        private System.Windows.Forms.ToolStripTextBox tbxBaud;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.Windows.Forms.ToolStripButton btnDisconnect;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbHistory;
        private System.Windows.Forms.ToolStripButton btnRefreshPort;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLongtitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.Label label1;
        private CefSharp.WinForms.ChromiumWebBrowser browserMap;
        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeviceID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSelectDeviceID;
    }
}

