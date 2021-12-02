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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gps_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gps_la = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gps_long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gps_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gps_id,
            this.gps_la,
            this.gps_long,
            this.gps_time});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // gps_id
            // 
            this.gps_id.HeaderText = "裝置ID";
            this.gps_id.Name = "gps_id";
            // 
            // gps_la
            // 
            this.gps_la.HeaderText = "經度";
            this.gps_la.Name = "gps_la";
            // 
            // gps_long
            // 
            this.gps_long.HeaderText = "緯度";
            this.gps_long.Name = "gps_long";
            // 
            // gps_time
            // 
            this.gps_time.HeaderText = "時間";
            this.gps_time.Name = "gps_time";
            // 
            // dockRecordGps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dockRecordGps";
            this.Text = "dockRecordGps";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gps_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gps_la;
        private System.Windows.Forms.DataGridViewTextBoxColumn gps_long;
        private System.Windows.Forms.DataGridViewTextBoxColumn gps_time;
    }
}