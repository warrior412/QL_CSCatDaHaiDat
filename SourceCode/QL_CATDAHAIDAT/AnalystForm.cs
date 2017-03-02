using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_CATDAHAIDAT
{
    public partial class AnalystForm : Form
    {
        public AnalystForm()
        {
            InitializeComponent();
        }

        private void AnalystForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.M_KHACHHANG' table. You can move, or remove it, as needed.

            this.m_KHACHHANGTableAdapter.Connection.ConnectionString = Common.GetInstance().CurrentShop;
            this.sp_GetDataForAnalystGraphTableAdapter.Connection.ConnectionString = Common.GetInstance().CurrentShop;
            this.sp_AnalystByTimeAndCustomerTableAdapter.Connection.ConnectionString = Common.GetInstance().CurrentShop;

            numericUpDown1.Value = DateTime.Now.Year;

            this.m_KHACHHANGTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);
            this.sp_GetDataForAnalystGraphTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph,int.Parse(numericUpDown1.Value.ToString()));
            drawGraph();

        }
        void drawGraph()
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart1.Series["Doanh thu"].Points.AddXY("Tháng 1", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][0]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 2", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][1]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 3", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][2]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 4", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][3]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 5", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][4]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 6", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][5]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 7", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][6]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 8", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][7]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 9", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][8]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 10", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][9]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 11", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][10]);
            chart1.Series["Doanh thu"].Points.AddXY("Tháng 12", dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph[0][11]);

            chart1.DataBind();
            chart1.Visible = true;

        }

        private void btnAnalyst_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_AnalystByTimeAndCustomerTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.sp_AnalystByTimeAndCustomer,
                    Common.GetInstance().getStartDate(dateTimePicker1.Value),
                    Common.GetInstance().getEndDate(dateTimePicker2.Value), 
                    int.Parse(comboBox3.SelectedValue.ToString()));
                double total = 0;
                foreach (DB_QLCatDaHaiDatDataSet.sp_AnalystByTimeAndCustomerRow row in this.dB_QLCatDaHaiDatDataSet.sp_AnalystByTimeAndCustomer)
                {
                    total += row.IsTotalNull()?0:row.Total;
                }
                lblTotal.Text = Common.GetInstance().getMoneyFormatByDouble(total);
            }catch(Exception ex)
            {
                MessageBox.Show("Không thể thực hiện thống kê");
            }
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.sp_GetDataForAnalystGraphTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.sp_GetDataForAnalystGraph, int.Parse(numericUpDown1.Value.ToString()));
            drawGraph();
        }
    }
}
