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
using WeifenLuo.WinFormsUI.Docking;
using CefSharp.WinForms;

namespace GPS_Resuce_Receiver_GUI
{
    public partial class mainForm : Form
    {
        private string googleMapHost = "https://www.google.com.tw/maps";
        private SerialPort serialGps { get; set; }
        private char[] indata { get; set; }
        //private historyList history { get; set; }

        private dockDisplayGps _dockDisplayGps;
        private dockControlGps _dockControlGps;
        private dockBrowserMap _dockBrowserMap;
        private dockTutorial _dockTutorial;
        private dockRecordGps _dockRecordGps; 

        public mainForm()
        {
            InitializeComponent();

            dockPanel1.Dock = DockStyle.Fill;

            dockPanel1.Theme = new VS2015LightTheme();

            _dockDisplayGps = new dockDisplayGps() { TabText = "GPS資訊概覽" };
            _dockControlGps = new dockControlGps() { TabText = "GPS裝置控制" };
            _dockBrowserMap = new dockBrowserMap() { TabText = "GPS位置顯示" };
            _dockTutorial = new dockTutorial() { TabText = "Welcome And Tutorial" };
            _dockRecordGps = new dockRecordGps() { TabText = "歷史記錄" };

            _dockTutorial.Show(this.dockPanel1, DockState.Document);

            //history = new historyList();

            //_dockRecordGps.dataHistoryGps.DataSource = history.historyDatas;
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

            serialGps.NewLine = "\x0D\x0A";

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
            //splitContainer.Visible = false;
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort se = (SerialPort)sender;

            //char[] _indata = new char[41];

            //for (int i = 0; i < _indata.Length;)
            //    i += se.Read(_indata, i, _indata.Length - i);

            string indata = se.ReadLine();

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
                    //splitContainer.Visible = true;

                    /** Change Button Enable **/
                    btnConnect.Enabled = !btnConnect.Enabled;
                    btnDisconnect.Enabled = !btnDisconnect.Enabled;

                    _dockTutorial.Hide();

                    _dockRecordGps.Show(this.dockPanel1, DockState.Document);

                    _dockBrowserMap.Show(this.dockPanel1, DockState.Document);

                    _dockDisplayGps.Show(this.dockPanel1, DockState.DockLeft);

                    _dockControlGps.Show(_dockDisplayGps.Pane, DockAlignment.Bottom, 0.5);

                    /** Set Web Browser Pages to Google Map **/
                    ChromiumWebBrowser browserMap = (ChromiumWebBrowser)_dockBrowserMap.Controls[0];

                    browserMap.LoadUrlAsync(googleMapHost).GetAwaiter();
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

            _dockControlGps.resetFilter();  // reset Filter
            serialGps.Close();
            _dockRecordGps.dataHistoryGps.Rows.Clear();

            _dockDisplayGps.Hide();

            _dockBrowserMap.Hide();

            _dockControlGps.Hide();

            _dockRecordGps.Hide();

            _dockTutorial.Show(this.dockPanel1, DockState.Document);
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

            // get Device ID
            UInt16 deviceID = (ushort)((array[0] << 8) + array[1]);

            // get systemTime
            string systemTime = DateTime.Now.ToString("HH:mm:ss");

            if (locationStr.StartsWith("00000"))
            {
                _dockRecordGps.dataHistoryGps.Rows.Add
                    (new string[] { deviceID.ToString(), "00.00000" + "E", "00.00000" + "N", "00:00:00", "1", systemTime});
            }

            else if (deviceID == _dockControlGps.id || _dockControlGps.id == 0)
            {
                try
                {
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
                    gpsLatitude = gpsConvert.convertToDMS(LatitudeWithoutN);
                    gpsLongtitude = gpsConvert.convertToDMS(LongtitudeWithoutE);
                    // convert UTC TO CST
                    gpsTime = gpsConvert.convertToCST(gpsTime);
                    // Display in TextBox
                    foreach (Control c in _dockDisplayGps.Controls)
                    {
                        foreach (Control _c in c.Controls)
                        {
                            switch (_c.Name)
                            {
                                case "tbClientID":
                                    _c.Text = deviceID.ToString();
                                    break;
                                case "tbTime":
                                    _c.Text = gpsTime;
                                    break;
                                case "tbLatitude":
                                    _c.Text = gpsLatitude + "N";
                                    break;
                                case "tbLongtitude":
                                    _c.Text = gpsLongtitude + "E";
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    _dockRecordGps.dataHistoryGps.Rows.Add
                    ( new string[] { deviceID.ToString(), gpsLongtitude + "E", gpsLatitude + "N", gpsTime, "0", systemTime } );

                    // Browser Display
                    ChromiumWebBrowser browserMap = (ChromiumWebBrowser)_dockBrowserMap.Controls[0];
                    browserMap.LoadUrlAsync(googleMapHost + "/place/" + gpsLatitude + "N+" + gpsLongtitude + "E").GetAwaiter();
                } 
                // String length Error
                catch (Exception ex)
                {
                    // pass
                }
            }

            if (_dockRecordGps.dataHistoryGps.Rows.Count == 101)
                _dockRecordGps.dataHistoryGps.Rows.RemoveAt(0);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ShowGpsAddress("\x00\x01\x00\x01\x27\x0F" + "00000" + "\x0D\x0A");   
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutForm _aboutForm = new aboutForm();
            _aboutForm.ShowDialog();
        }
    }
}
