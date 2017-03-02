using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CATDAHAIDAT
{
    public class Common
    {
        private static Common _instance = null;
        public static Common GetInstance()
        {
            if (_instance == null)
                _instance = new Common();
            return _instance;
        }
        private string currentShop;

        public string CurrentShop
        {
            get { return currentShop; }
            set { currentShop = value; }
        }

        public string getMoneyFormatByDouble (double value)
        {
            if (value == 0)
                return "0.0 VND";
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            string stotal = value.ToString("#,###", cul.NumberFormat) + " VND";
            return stotal;
        }

        public DateTime getStartDate(DateTime value)
        {
            DateTime rs = DateTime.Parse(value.ToShortDateString() + " 00:00:00");
            return rs;
        }
        public DateTime getEndDate(DateTime value)
        {
            DateTime rs = DateTime.Parse(value.ToShortDateString() + " 23:59:59");
            return rs;
        }



    }
}
