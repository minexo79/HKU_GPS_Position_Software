using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS_Resuce_Receiver_GUI
{
    public static class GpsConvert
    {
        public static string convertToDMS(float src)
        {
            // XXYY.ZZZZZ => XX YY 0.ZZ

            int degree = (int)(src / 100);                      // XX

            int minute = (int)(((src / 100.0) - degree) * 100); // YY

            float second = (src - (int)(src)) * 60;             // 0.ZZ

            string res = $"{degree}°{minute}'{second.ToString("00.0")}\x34";

            return res;
        }

        public static string convertToCST(string time)
        {
            // XXYYZZ->XX+8:YY:ZZ
            int hours, minute, second;

            hours = int.Parse(time.Substring(0, 2));
            minute = int.Parse(time.Substring(2, 2));
            second = int.Parse(time.Substring(4, 2));

            if ((hours + 8) > 24)           // Over 24
                hours = (hours + 8) - 24;
            else
                hours = (hours + 8);

            string cstTime = $"{hours.ToString("00")}:{minute.ToString("00")}:{second.ToString("00")}";

            return cstTime;
        }
    }
}
