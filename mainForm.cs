using System;
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
        private SerialPort serialGps { get; set; }
        private char[] indata { get; set; }

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            /** Disable Other Bottons, Only Connect Enabled **/
            btnDisconnect.Enabled = false;
            btnConnect.Enabled = btnAbout.Enabled = true;

            /** Create new Serial Object **/
            serialGps = new SerialPort();

            /** GPS Buffer **/
            indata = new char[64];

            serialGps.Parity = Parity.None;
            serialGps.DataBits = 8;
            serialGps.StopBits = StopBits.One;
            serialGps.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

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

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort se = (SerialPort)sender;

            Char[] indata = new Char[64];

            indata = se.ReadExisting().ToCharArray();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = !btnConnect.Enabled;
            btnDisconnect.Enabled = !btnDisconnect.Enabled;

            /**
             *  COM PORT:   Combo box Selected
             *  BAUD:       9600bps / TextBox User Defined
             *  PARITY:     NONE
             *  DATA BITS:  8 bits
             *  STOP BITS:  1 bit
             **/
            serialGps.PortName = cbxComPort.SelectedItem.ToString();
            serialGps.BaudRate = int.Parse(tbxBaud.Text);
            serialGps.Open();

            /** Set Container Visible to True **/
            splitContainer.Visible = true;

            /** Set Web Browser Pages to Google Map **/

            browserMap.Load(googleMapHost);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = !btnConnect.Enabled;
            btnDisconnect.Enabled = !btnDisconnect.Enabled;

            serialGps.Close();

            /** Set Container Visible to False **/
            splitContainer.Visible = false;
        }

        private void btnRefreshPort_Click(object sender, EventArgs e)
        {
            /** Clear Existing Port List**/
            cbxComPort.Items.Clear();

            /** Add Ports Into ComboBox **/
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cbxComPort.Items.Add(port);
            }
        }
    }
}
