using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CATDAHAIDAT
{
    public partial class ShopSelect : Form
    {
        public ShopSelect()
        {
            InitializeComponent();


            if(Common.GetInstance().CurrentShop == null || Common.GetInstance().CurrentShop.Equals(""))
            {
                Common.GetInstance().CurrentShop = ConfigurationManager.
                    ConnectionStrings["QL_CATDAHAIDAT.Properties.Settings.DB_QLCatDaHaiDatConnectionString"].ConnectionString;
            }
            if (Common.GetInstance().CurrentShop.Equals(ConfigurationManager.
                    ConnectionStrings["QL_CATDAHAIDAT.Properties.Settings.DB_QLCatDaHaiDatConnectionString"].ConnectionString))
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main parent = this.MdiParent as Main;
            
            if(comboBox1.SelectedIndex == 0)
            {
                Common.GetInstance().CurrentShop = ConfigurationManager.
                    ConnectionStrings["QL_CATDAHAIDAT.Properties.Settings.DB_QLCatDaHaiDatConnectionString"].ConnectionString;
                parent.changeShopName("QUẢN LÝ CÁT ĐÁ HAI ĐẠT");
            }
            else
            {
                Common.GetInstance().CurrentShop = ConfigurationManager.
                    ConnectionStrings["QL_CATDAHAIDAT.Properties.Settings.DB_QLCatDaConnectionString"].ConnectionString;
                parent.changeShopName("QUẢN LÝ CÁT ĐÁ HAI ƠN");
            }


            this.Close();
        }
    }
}
