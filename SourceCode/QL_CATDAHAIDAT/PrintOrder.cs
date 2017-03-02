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
    public partial class PrintOrder : Form
    {
        private DataTable dtReport;

        public DataTable DtReport
        {
            get { return dtReport; }
            set { dtReport = value; }
        }
        public string ma_hd;
        public string ten;
        public string diachi;
        public string sodt;
        public string total;
        public string paid;
        public string debt;

        public string contact1;
        public string contact2;
        public string contact3;

        public PrintOrder(string ten,string diachi,string sdt, string total,string paid,string debt)
        {
            

            this.ten = ten;
            this.diachi = diachi;
            this.sodt = sdt;
            this.total = total;
            this.paid = paid;
            this.debt = debt;

            if (Common.GetInstance().CurrentShop.Equals(ConfigurationManager.ConnectionStrings["QL_CATDAHAIDAT.Properties.Settings.DB_QLCatDaHaiDatConnectionString"].ConnectionString))
            {
                this.contact1 = "0977.209.709 (Đạt)";
                this.contact2 = "0978.283.939 (Đạt)";
                this.contact3 = "0967.209.709 (Chinh)";
            }
            else
            {
                this.contact1 = "0907.768.768 (Ba Ơn)";
                this.contact2 = "0977.209.709 (Đạt)";
                this.contact3 = "0978.283.939 (Đạt)";
            }
            InitializeComponent();
        }

        private void PrintOrder_Load(object sender, EventArgs e)
        {
            SELECTDETAILORDERTableAdapter.Connection.ConnectionString = Common.GetInstance().CurrentShop;
             //TODO: This line of code loads data into the 'DB_QLCatDaHaiDatDataSet.SELECTDETAILORDER' table. You can move, or remove it, as needed.
            if(DtReport == null)
                this.SELECTDETAILORDERTableAdapter.Fill(this.DB_QLCatDaHaiDatDataSet.SELECTDETAILORDER, ma_hd);
            else
            {
                foreach (DataRow row in DtReport.Rows)
                {
                    DB_QLCatDaHaiDatDataSet.SELECTDETAILORDERRow item = this.DB_QLCatDaHaiDatDataSet.SELECTDETAILORDER.NewSELECTDETAILORDERRow();
                    item.TEN_SP = row[1].ToString();
                    item.GIA = double.Parse(row[2].ToString());
                    item.SO_LUONG = double.Parse(row[4].ToString());
                    item.DON_VI_TINH = row[6].ToString();
                    item.THOI_GIAN_TAO = DateTime.Now;
                    item.THANH_TIEN = item.GIA * item.SO_LUONG;
                    item.GHI_CHU = row[7].ToString();
                    DB_QLCatDaHaiDatDataSet.SELECTDETAILORDER.AddSELECTDETAILORDERRow(item);
                }

            }
            
            Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("customer_name",ten),
                new Microsoft.Reporting.WinForms.ReportParameter("address",diachi),
                new Microsoft.Reporting.WinForms.ReportParameter("phone",sodt),
                new Microsoft.Reporting.WinForms.ReportParameter("total",total),
                new Microsoft.Reporting.WinForms.ReportParameter("debt",debt),
                new Microsoft.Reporting.WinForms.ReportParameter("paid_amount",paid),
                new Microsoft.Reporting.WinForms.ReportParameter("ma_hd",ma_hd),
                new Microsoft.Reporting.WinForms.ReportParameter("remark",""),
                new Microsoft.Reporting.WinForms.ReportParameter("contact1",contact1),
                new Microsoft.Reporting.WinForms.ReportParameter("contact2",contact2),
                new Microsoft.Reporting.WinForms.ReportParameter("contact3",contact3)
            };
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
