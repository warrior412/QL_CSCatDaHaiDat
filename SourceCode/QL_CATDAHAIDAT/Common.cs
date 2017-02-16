using System;
using System.Collections.Generic;
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

    }
}
