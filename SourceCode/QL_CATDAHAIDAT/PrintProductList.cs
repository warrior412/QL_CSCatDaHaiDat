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
    public partial class PrintProductList : Form
    {
        public int ma_kh;

        public string contact1;
        public string contact2;
        public string contact3;


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


            if (Common.GetInstance().CurrentShop.Equals(ConfigurationManager.ConnectionStrings["QL_CATDAHAIDAT.Properties.Settings.DB_QLCatDaHaiDatConnectionString"].ConnectionString))
            {
                this.contact1 = "0977.209.709 (Đạt)";
                //this.contact2 = "0978.283.939 (A.Đạt)";
                this.contact2 = "0967.209.709 (Trinh)";
                this.contact3 = "";
            }
            else
            {
                this.contact1 = "0907.768.768 (Ba Ơn)";
                this.contact2 = "0977.209.709 (Đạt)";
                //this.contact3 = "0978.283.939 (A.Đạt)";
                this.contact3 = "";
            }

            Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("contact1",contact1),
                new Microsoft.Reporting.WinForms.ReportParameter("contact2",contact2),
                new Microsoft.Reporting.WinForms.ReportParameter("contact3",contact3)
            };
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
