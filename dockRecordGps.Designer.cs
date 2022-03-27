namespace GPS_Resuce_Receiver_GUI
{
    partial class dockRecordGps
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
            this.dataHistoryGps = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longtitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsErrCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryGps)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataHistoryGps
            // 
            this.dataHistoryGps.AllowUserToAddRows = false;
            this.dataHistoryGps.AllowUserToDeleteRows = false;
            this.dataHistoryGps.AllowUserToResizeColumns = false;
            this.dataHistoryGps.AllowUserToResizeRows = false;
            this.dataHistoryGps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistoryGps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Longtitude,
            this.Latitude,
            this.gpsTime,
            this.gpsErrCode,
            this.sysTime});
            this.dataHistoryGps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHistoryGps.Location = new System.Drawing.Point(0, 3);
            this.dataHistoryGps.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.dataHistoryGps.MultiSelect = false;
            this.dataHistoryGps.Name = "dataHistoryGps";
            this.dataHistoryGps.ReadOnly = true;
            this.dataHistoryGps.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataHistoryGps.Size = new System.Drawing.Size(566, 624);
            this.dataHistoryGps.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataHistoryGps, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 617);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "編號";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 56;
            // 
            // Longtitude
            // 
            this.Longtitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Longtitude.HeaderText = "經度";
            this.Longtitude.Name = "Longtitude";
            this.Longtitude.ReadOnly = true;
            // 
            // Latitude
            // 
            this.Latitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Latitude.HeaderText = "緯度";
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            // 
            // gpsTime
            // 
            this.gpsTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gpsTime.HeaderText = "GPS時間";
            this.gpsTime.Name = "gpsTime";
            this.gpsTime.ReadOnly = true;
            // 
            // gpsErrCode
            // 
            this.gpsErrCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gpsErrCode.HeaderText = "代碼";
            this.gpsErrCode.Name = "gpsErrCode";
            this.gpsErrCode.ReadOnly = true;
            this.gpsErrCode.Width = 56;
            // 
            // sysTime
            // 
            this.sysTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sysTime.HeaderText = "系統時間";
            this.sysTime.Name = "sysTime";
            this.sysTime.ReadOnly = true;
            // 
            // dockRecordGps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 617);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "dockRecordGps";
            this.Text = "dockRecordGps";
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryGps)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataHistoryGps;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longtitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsErrCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysTime;
    }
}