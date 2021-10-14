﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GPS_Resuce_Receiver_GUI
{
    public partial class mainForm : Form
    {
        private string googleMapHost = "https://www.google.com.tw/maps";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            /** Disable Other Bottons, Only Connect Enabled **/
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = btnAbout.Enabled = true;

            /** Add Ports Into ComboBox **/
            string[] ports = SerialPort.GetPortNames();

            foreach(string port in ports)
            {
                cbxComPort.Items.Add(port);
            }

            /** Set Baud to 9600 bps **/
            tbxBaud.Text = "9600";

            /** Set Container Visible to False **/
            splitContainer.Visible = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = !btnConnect.Enabled;
            btnDisconnect.Enabled = !btnDisconnect.Enabled;

            /** Set Container Visible to True **/
            splitContainer.Visible = true;

            /** Set Web Browser Pages to Google Map **/

            browserMap.Load(googleMapHost);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = !btnConnect.Enabled;
            btnDisconnect.Enabled = !btnDisconnect.Enabled;

            /** Set Container Visible to False **/
            splitContainer.Visible = false;
        }
    }
}
