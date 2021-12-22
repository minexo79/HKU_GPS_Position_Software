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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longtitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryGps)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataHistoryGps
            // 
            this.dataHistoryGps.AllowUserToAddRows = false;
            this.dataHistoryGps.AllowUserToDeleteRows = false;
            this.dataHistoryGps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistoryGps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Longtitude,
            this.Latitude,
            this.gpsTime});
            this.dataHistoryGps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHistoryGps.Location = new System.Drawing.Point(0, 29);
            this.dataHistoryGps.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.dataHistoryGps.Name = "dataHistoryGps";
            this.dataHistoryGps.ReadOnly = true;
            this.dataHistoryGps.Size = new System.Drawing.Size(800, 421);
            this.dataHistoryGps.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "裝置編號";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Longtitude
            // 
            this.Longtitude.HeaderText = "經度";
            this.Longtitude.Name = "Longtitude";
            this.Longtitude.ReadOnly = true;
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "緯度";
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            // 
            // gpsTime
            // 
            this.gpsTime.HeaderText = "GPS時間";
            this.gpsTime.Name = "gpsTime";
            this.gpsTime.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataHistoryGps, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.btnExport.Location = new System.Drawing.Point(0, 3);
            this.btnExport.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(800, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "匯出紀錄";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // dockRecordGps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "dockRecordGps";
            this.Text = "dockRecordGps";
            ((System.ComponentModel.ISupportInitialize)(this.dataHistoryGps)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataHistoryGps;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longtitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExport;
    }
}