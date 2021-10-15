﻿using System;
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
    }
}