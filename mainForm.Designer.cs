
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbxComPort = new System.Windows.Forms.ToolStripComboBox();
            this.tbxBaud = new System.Windows.Forms.ToolStripTextBox();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.btnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.serialGps = new System.IO.Ports.SerialPort(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browserMap = new CefSharp.WinForms.ChromiumWebBrowser();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbxComPort,
            this.tbxBaud,
            this.btnConnect,
            this.btnDisconnect,
            this.btnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(965, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbxComPort
            // 
            this.cbxComPort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxComPort.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
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
            this.btnConnect.ToolTipText = "與設備建立連線。";
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
            this.btnDisconnect.Text = "取消連線";
            this.btnDisconnect.ToolTipText = "與設備取消連線。";
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
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.splitContainer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 29);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer.Panel1.Controls.Add(this.gbConfig);
            this.splitContainer.Panel1.Controls.Add(this.gbInfo);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer.Panel2.Controls.Add(this.browserMap);
            this.splitContainer.Size = new System.Drawing.Size(965, 562);
            this.splitContainer.SplitterDistance = 262;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 2;
            // 
            // gbInfo
            // 
            this.gbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfo.Location = new System.Drawing.Point(0, 0);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(10);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbInfo.Size = new System.Drawing.Size(262, 146);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "資訊概要";
            // 
            // gbConfig
            // 
            this.gbConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbConfig.Location = new System.Drawing.Point(0, 146);
            this.gbConfig.Margin = new System.Windows.Forms.Padding(10);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbConfig.Size = new System.Drawing.Size(262, 148);
            this.gbConfig.TabIndex = 1;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "傳輸設定";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 294);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(262, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "歷史紀錄";
            // 
            // browserMap
            // 
            this.browserMap.ActivateBrowserOnCreation = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.browserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserMap.Location = new System.Drawing.Point(0, 0);
            this.browserMap.Name = "browserMap";
            this.browserMap.Size = new System.Drawing.Size(697, 562);
            this.browserMap.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(965, 591);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(981, 630);
            this.Name = "mainForm";
            this.Text = "登山救援系統V1.0";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
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
        private System.IO.Ports.SerialPort serialGps;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbConfig;
        private CefSharp.WinForms.ChromiumWebBrowser browserMap;
    }
}

