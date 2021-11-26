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

            char[] _indata = new char[41];

            for (int i = 0; i < _indata.Length;)
                i += se.Read(_indata, i, _indata.Length - i);

            string indata = new string(_indata);

            this.BeginInvoke(new showGpsAddress(ShowGpsAddress), new object[] { indata });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            /**
             *  COM PORT:   Combo box Selected
             *  BAUD:       9600bps / TextBox User Defined
             *  PARITY:     NONE
             *  DATA BITS:  8 bits
             *  STOP BITS:  1 bit
             **/

            try
            {
                serialGps.PortName = cbxComPort.SelectedItem.ToString();
                serialGps.BaudRate = int.Parse(tbxBaud.Text);

                if (!serialGps.IsOpen)
                {
                    serialGps.Open();
                    /** Set Container Visible to True **/
                    splitContainer.Visible = true;

                    /** Change Button Enable **/
                    btnConnect.Enabled = !btnConnect.Enabled;
                    btnDisconnect.Enabled = !btnDisconnect.Enabled;

                    /** Set Web Browser Pages to Google Map **/
                    browserMap.Load(googleMapHost);
                }
            }
            catch (Exception ex)
            {
                string errorMsg = "請檢查設定是否正確。\n"
                    + "1. 是否有選擇到正確的Port？\n"
                    + "2. 檢查傳輸速率是否有填入？（一般均9600）\n\n"
                    + $"錯誤訊息：{ex.Message}";

                MessageBox.Show(errorMsg,
                "歐歐，發現錯誤",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private delegate void showGpsAddress(string srcStr);
        private void ShowGpsAddress(string srcStr)
        {
            //string testStr = "\x00\x01\x27\x0F" + "2413.00710,N,12035.05815,E,111520" + "\x0D\x0A";

            // remove head count
            char[] array = srcStr.Remove(0, 2).ToCharArray();
            string locationStr = srcStr.Remove(0, 6);

            string[]

            // get Device ID
            UInt16 deviceID = (ushort)((array[0] << 8) + array[1]);

            // 緯度
            string gpsLatitude = locationStr.Substring(0, locationStr.IndexOf('N') + 1);
            // 經度
            string gpsLongtitude = locationStr.Substring(locationStr.IndexOf('N') + 2,
                                                         locationStr.IndexOf('E') - (gpsLatitude.Length));
            // UTC時間
            string gpsTime = locationStr.Substring(locationStr.IndexOf('E') + 2, 6);

            // convert To Float
            float LatitudeWithoutN = float.Parse(gpsLatitude.Replace(",N", ""));
            float LongtitudeWithoutE = float.Parse(gpsLongtitude.Replace(",E", ""));

            // convert DMM TO DMS
            gpsLatitude = GpsConvert.convertToDMS(LatitudeWithoutN);
            gpsLongtitude = GpsConvert.convertToDMS(LongtitudeWithoutE);
            // convert UTC TO CST
            gpsTime = GpsConvert.convertToCST(gpsTime);

            // Display in TextBox
            tbClientID.Text = deviceID.ToString();
            tbLatitude.Text = gpsLatitude + "N";
            tbLongtitude.Text = gpsLongtitude + "E";
            tbTime.Text = gpsTime;

            // Browser Display
            browserMap.Load(googleMapHost + "/place/" + gpsLatitude + "N+" + gpsLongtitude + "E");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ShowGpsAddress("\x00\x01\x00\x01\x27\x0F" + "2413.00710,N,12035.05815,E,111520" + "\x0D\x0A");   
        }
    }
}
