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
    public partial class AddOrder : Form
    {
        DataTable dtOrder = new DataTable();
        public AddOrder()
        {
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.M_SANPHAM' table. You can move, or remove it, as needed.
            this.m_SANPHAMTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_SANPHAM);
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.M_KHACHHANG' table. You can move, or remove it, as needed.
            this.m_KHACHHANGTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);

        }

        private void dgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgProduct.SelectedRows[0];
            dtOrder.Columns.Add("Tên sản phẩm", typeof(string));
            dtOrder.Columns.Add("Giá", typeof(double));
            dtOrder.Columns.Add("Số lượng", typeof(string));
            dtOrder.Rows.Add(dgProduct.SelectedRows[0].Cells[1].Value.ToString(),
                double.Parse(dgProduct.SelectedRows[0].Cells[2].Value.ToString()));
            dgOrder.DataSource = dtOrder;
        }
    }
}
