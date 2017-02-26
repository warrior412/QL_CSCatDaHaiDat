using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CATDAHAIDAT
{
    public partial class PrintProductList : Form
    {
        public int ma_kh;
        public PrintProductList()
        {
            

            InitializeComponent();
        }

        private void PrintProductList_Load(object sender, EventArgs e)
        {
            GetProductInfoForPrintingTableAdapter.Connection.ConnectionString = Common.GetInstance().CurrentShop;
            // TODO: This line of code loads data into the 'DB_QLCatDaHaiDatDataSet.GetProductInfoForPrinting' table. You can move, or remove it, as needed.
            this.GetProductInfoForPrintingTableAdapter.Fill(this.DB_QLCatDaHaiDatDataSet.GetProductInfoForPrinting,ma_kh);
            // TODO: This line of code loads data into the 'DB_QLCatDaHaiDatDataSet.M_SANPHAM' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
