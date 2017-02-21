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
        public PrintOrder(string ten,string diachi,string sdt, string total)
        {
            this.ten = ten;
            this.diachi = diachi;
            this.sodt = sdt;
            this.total = total;
            InitializeComponent();
        }

        private void PrintOrder_Load(object sender, EventArgs e)
        {
             //TODO: This line of code loads data into the 'DB_QLCatDaHaiDatDataSet.SELECTDETAILORDER' table. You can move, or remove it, as needed.
            //this.SELECTDETAILORDERTableAdapter.Fill(this.DB_QLCatDaHaiDatDataSet.SELECTDETAILORDER,ma_hd);

            foreach(DataRow row in DtReport.Rows)
            {
                DB_QLCatDaHaiDatDataSet.SELECTDETAILORDERRow item = this.DB_QLCatDaHaiDatDataSet.SELECTDETAILORDER.NewSELECTDETAILORDERRow();
                item.TEN_SP = row[1].ToString();
                item.GIA = double.Parse(row[2].ToString());
                item.SO_LUONG = double.Parse(row[4].ToString());
                item.DON_VI_TINH = row[6].ToString();
                DB_QLCatDaHaiDatDataSet.SELECTDETAILORDER.AddSELECTDETAILORDERRow(item);
            }

            Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("customer_name",ten),
                new Microsoft.Reporting.WinForms.ReportParameter("address",diachi),
                new Microsoft.Reporting.WinForms.ReportParameter("phone",sodt),
                new Microsoft.Reporting.WinForms.ReportParameter("total",total)
            };
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
