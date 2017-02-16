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
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.T_CHITIETHOADON' table. You can move, or remove it, as needed.
            this.t_CHITIETHOADONTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.T_CHITIETHOADON);
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.T_HOADON' table. You can move, or remove it, as needed.
            this.t_HOADONTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.T_HOADON);
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.M_SANPHAM' table. You can move, or remove it, as needed.
            this.m_SANPHAMTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_SANPHAM);
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.M_KHACHHANG' table. You can move, or remove it, as needed.
            this.m_KHACHHANGTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);

        }

        private void dgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgOrder.RowCount==0)
            {
                dtOrder.Columns.Clear();
                dtOrder.Columns.Add("Mã sản phẩm", typeof(int));
                dtOrder.Columns.Add("Tên sản phẩm", typeof(string));
                dtOrder.Columns.Add("Giá", typeof(double));
                dtOrder.Columns.Add("Số lượng", typeof(string));
            }
            DataGridViewRow row = dgProduct.SelectedRows[0];
            
            foreach(DataGridViewRow item in dgOrder.Rows)
            {
                if(item.Cells[0].Value!=null&& item.Cells[0].Value.ToString().Equals(dgProduct.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    return;
                }
            }
            dtOrder.Rows.Add(dgProduct.SelectedRows[0].Cells[0].Value.ToString(),
                dgProduct.SelectedRows[0].Cells[1].Value.ToString(),
                double.Parse(dgProduct.SelectedRows[0].Cells[2].Value.ToString()));
            dgOrder.DataSource = dtOrder;
            dgOrder.Columns[0].Visible = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            float totalAmount = 0;
            foreach(DataRow row in dtOrder.Rows)
            {
                totalAmount += float.Parse(row.ItemArray[2].ToString()) * float.Parse(row.ItemArray[3].ToString());
            }

            DB_QLCatDaHaiDatDataSet.T_HOADONRow newRow = dB_QLCatDaHaiDatDataSet.T_HOADON.NewT_HOADONRow();
            newRow.NGAY_LAP = DateTime.Now;
            newRow.GHI_CHU = "";
            newRow.TONG_TIEN = totalAmount;
            newRow.TRANG_THAI = 0;
            newRow.KHACH_HANG = int.Parse( dgCustomer.SelectedRows[0].Cells[0].Value.ToString());

            this.dB_QLCatDaHaiDatDataSet.T_HOADON.Rows.Add(newRow);

            int insertedID =int.Parse(t_HOADONTableAdapter.InsertQuery(newRow.NGAY_LAP, newRow.GHI_CHU, newRow.TONG_TIEN, newRow.TRANG_THAI, newRow.KHACH_HANG).ToString());
            foreach (DataRow row in dtOrder.Rows)
            {
                t_CHITIETHOADONTableAdapter.Insert(insertedID, int.Parse(row.ItemArray[0].ToString()), double.Parse(row.ItemArray[3].ToString()),"",1);
            }

        }

        private void dgOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
