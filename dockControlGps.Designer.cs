namespace GPS_Resuce_Receiver_GUI
{
    partial class dockControlGps
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbFilterIdDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilterSet = new System.Windows.Forms.Button();
            this.tbFilterReset = new System.Windows.Forms.Button();
            this.tbFilterID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbFilterIdDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbFilterSet, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbFilterReset, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbFilterID, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 207);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tbFilterIdDisplay
            // 
            this.tbFilterIdDisplay.AutoSize = true;
            this.tbFilterIdDisplay.BackColor = System.Drawing.Color.PowderBlue;
            this.tbFilterIdDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFilterIdDisplay.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.tbFilterIdDisplay.Location = new System.Drawing.Point(0, 3);
            this.tbFilterIdDisplay.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tbFilterIdDisplay.Name = "tbFilterIdDisplay";
            this.tbFilterIdDisplay.Size = new System.Drawing.Size(168, 21);
            this.tbFilterIdDisplay.TabIndex = 15;
            this.tbFilterIdDisplay.Text = "目前過濾編號：無";
            this.tbFilterIdDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "裝置編號";
            // 
            // tbFilterSet
            // 
            this.tbFilterSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFilterSet.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.tbFilterSet.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbFilterSet.Location = new System.Drawing.Point(0, 82);
            this.tbFilterSet.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tbFilterSet.Name = "tbFilterSet";
            this.tbFilterSet.Size = new System.Drawing.Size(168, 30);
            this.tbFilterSet.TabIndex = 13;
            this.tbFilterSet.Text = "指定裝置";
            this.tbFilterSet.UseVisualStyleBackColor = true;
            this.tbFilterSet.Click += new System.EventHandler(this.tbFilterSet_Click);
            // 
            // tbFilterReset
            // 
            this.tbFilterReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFilterReset.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Bold);
            this.tbFilterReset.ForeColor = System.Drawing.Color.IndianRed;
            this.tbFilterReset.Location = new System.Drawing.Point(0, 115);
            this.tbFilterReset.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tbFilterReset.Name = "tbFilterReset";
            this.tbFilterReset.Size = new System.Drawing.Size(168, 30);
            this.tbFilterReset.TabIndex = 16;
            this.tbFilterReset.Text = "回復預設值";
            this.tbFilterReset.UseVisualStyleBackColor = true;
            this.tbFilterReset.Click += new System.EventHandler(this.tbFilterReset_Click);
            // 
            // tbFilterID
            // 
            this.tbFilterID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.tbFilterID.Location = new System.Drawing.Point(0, 48);
            this.tbFilterID.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tbFilterID.Name = "tbFilterID";
            this.tbFilterID.Size = new System.Drawing.Size(168, 31);
            this.tbFilterID.TabIndex = 11;
            this.tbFilterID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dockControlGps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 207);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "dockControlGps";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Text = "dockControlGps";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button tbFilterSet;
        private System.Windows.Forms.Button tbFilterReset;
        private System.Windows.Forms.Label tbFilterIdDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilterID;
    }
}