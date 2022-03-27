
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbxComPort = new System.Windows.Forms.ToolStripComboBox();
            this.tbxBaud = new System.Windows.Forms.ToolStripTextBox();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.btnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshPort = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbxComPort,
            this.tbxBaud,
            this.btnConnect,
            this.btnDisconnect,
            this.btnAbout,
            this.btnRefreshPort,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(964, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbxComPort
            // 
            this.cbxComPort.Font = new System.Drawing.Font("Microsoft JhengHei", 11F);
            this.cbxComPort.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.Size = new System.Drawing.Size(159, 27);
            this.cbxComPort.Text = "端口選擇...";
            this.cbxComPort.ToolTipText = "與接收器的傳輸端口，可至設備管理器查看。";
            // 
            // tbxBaud
            // 
            this.tbxBaud.Font = new System.Drawing.Font("Microsoft JhengHei", 11F);
            this.tbxBaud.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.tbxBaud.Name = "tbxBaud";
            this.tbxBaud.Size = new System.Drawing.Size(100, 27);
            this.tbxBaud.Text = "9600";
            this.tbxBaud.ToolTipText = "與接收器的傳輸速率，一般皆設9600bps。";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnect.Image = global::GPS_Resuce_Receiver.Properties.Resources.link;
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(59, 24);
            this.btnConnect.Text = "連線";
            this.btnConnect.ToolTipText = "與接收器建立連線。";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisconnect.Image = global::GPS_Resuce_Receiver.Properties.Resources.unlink;
            this.btnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(89, 24);
            this.btnDisconnect.Text = "中斷連線";
            this.btnDisconnect.ToolTipText = "與接收器斷開連線。";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = global::GPS_Resuce_Receiver.Properties.Resources.info;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(68, 24);
            this.btnAbout.Text = "關於...";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnRefreshPort
            // 
            this.btnRefreshPort.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefreshPort.Image = global::GPS_Resuce_Receiver.Properties.Resources.refresh;
            this.btnRefreshPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshPort.Name = "btnRefreshPort";
            this.btnRefreshPort.Size = new System.Drawing.Size(89, 24);
            this.btnRefreshPort.Text = "重新整理";
            this.btnRefreshPort.Click += new System.EventHandler(this.btnRefreshPort_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F);
            this.toolStripButton1.Image = global::GPS_Resuce_Receiver.Properties.Resources.pakcet;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 24);
            this.toolStripButton1.Text = "封包測試";
            this.toolStripButton1.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 31);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(964, 560);
            this.dockPanel1.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 591);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(980, 630);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登山救援系統V1.0";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton btnRefreshPort;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

