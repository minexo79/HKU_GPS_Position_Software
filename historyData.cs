using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS_Resuce_Receiver_GUI
{
    class historyData
    {
        public string clientID { get; set; }
        public string clientLongtitude { get; set; }
        public string clientLatitude { get; set; }
        public string clientUtcTime { get; set; }
        public string clientErrCode { get; set; }
        public string sysTime { get; set; }
        public historyData(string _clientID, string _clientLo, string _clientLa, string _utcTime, string _errCode, string _sysTime)
        {
            this.clientID = _clientID;
            this.clientLongtitude = _clientLo;
            this.clientLatitude = _clientLa;
            this.clientUtcTime = _utcTime;
            this.clientErrCode = _errCode;
            this.sysTime = _sysTime;
        }
    }

    class historyList
    {
        public List<historyData> historyDatas { get; set; }

        public historyList()
        {
            this.historyDatas = new List<historyData>();
        }

        public void clearList()
        {
            this.historyDatas.Clear();
            this.historyDatas = null;
        }

        public void addList(string clientID, string clientLo, string clientLa, string utc, string errCode, string time)
        {
            this.historyDatas.Add(new historyData(clientID, clientLo, clientLa, utc, errCode, time));
        }
    }
}
