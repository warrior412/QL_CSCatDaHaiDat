using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CATDAHAIDAT
{
    public partial class ListOrder : Form
    {

        DB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfoRow currentRow;

        public ListOrder()
        {
            InitializeComponent();
        }

        private void ListOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfo' table. You can move, or remove it, as needed.
            this.selectListOrderWithCustomerInfoTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfo);
            Binding b = new Binding("Text", this.selectListOrderWithCustomerInfoBindingSource, "TRANG_THAI", true);
            b.Format += b_Format;
            lblStatus.DataBindings.Add(b);
        }

        private void setBindingSourceControl()
        {
            if (selectListOrderWithCustomerInfoBindingSource.Current == null)
                return;
            currentRow = (DB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfoRow)
                ((DataRowView)selectListOrderWithCustomerInfoBindingSource.Current).Row;

            double total = currentRow.IsTONG_TIENNull() ? 0 :currentRow.TONG_TIEN;
            double paid = currentRow.IsTIEN_TRANull() ? 0 :currentRow.TIEN_TRA;

            lblTotal.Text = Common.GetInstance().getMoneyFormatByDouble(total);
            lblPaid.Text = Common.GetInstance().getMoneyFormatByDouble(paid);
            lblDebt.Text = Common.GetInstance().getMoneyFormatByDouble(total - paid);

            if(currentRow.TRANG_THAI == 1)
            {
                BtnCloseOrder.Enabled = false;
            }
            else
            {
                BtnCloseOrder.Enabled = true;
            }

            this.getOrderDetailByOrderIDTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.GetOrderDetailByOrderID, currentRow.MA_HD);

        }

        void b_Format(object sender, ConvertEventArgs e)
        {
            if (e.Value == null || e.Value.ToString().Equals(""))
                return;
            if (int.Parse(e.Value.ToString()) == 1)
                e.Value = "Đã thanh toán";
            else
                e.Value = "Chưa thanh toán";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboBox1.SelectedIndex == 0)
            //{
            //    getOrderListBindingSource1.Filter = string.Format("TRANG_THAI < 100");
            //}
            //else if (comboBox1.SelectedIndex == 1)
            //{
            //    getOrderListBindingSource1.Filter = string.Format("TRANG_THAI = 1");
            //}
            //else
            //{
            //    getOrderListBindingSource1.Filter = string.Format("TRANG_THAI = 0");
            //}
        }

        private void BtnCloseOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thực hiện chốt hóa đơn này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                t_HOADONTableAdapter1.DoPaymentQuery(currentRow.MA_HD);
                this.selectListOrderWithCustomerInfoTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfo);
            }
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thực hiện thanh toán cho hóa đơn này ?","Xác nhận",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                //int ma_hd = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //getOrderListTableAdapter.DoPaymentQuery(ma_hd);
                //getOrderListTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.GetOrderList);

                PaymentInput dialog = new PaymentInput();
                double total = currentRow.IsTONG_TIENNull() ? 0 : currentRow.TONG_TIEN;
                double paid = currentRow.IsTIEN_TRANull() ? 0 : currentRow.TIEN_TRA;

                dialog.debt = total - paid;
                if(dialog.ShowDialog()==DialogResult.OK)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[0].Value != null && !dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Equals(""))
            {
                //int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //float totalAmount = float.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                //CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                //string stotal = totalAmount.ToString("#,###", cul.NumberFormat);
                //PrintOrder printpreviewer = new PrintOrder(lblCustomerName.Text, lblAddress.Text, lblPhone.Text, stotal);
                //printpreviewer.ma_hd = id;
                //printpreviewer.ShowDialog();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (dataGridView1.CurrentRow !=null
            //    &&dataGridView1.CurrentRow.Cells.Count>0
            //    && dataGridView1.CurrentRow.Cells[0].Value != null
            //    && !dataGridView1.CurrentRow.Cells[0].Value.ToString().Equals(""))
            //{
            //    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //    // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.GetOrderDetailByOrderID' table. You can move, or remove it, as needed.
            //    this.getOrderDetailByOrderIDTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.GetOrderDetailByOrderID, id);
            //    if (int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString()) == 1)
            //        btnCheckOut.Enabled = false;
            //    else
            //        btnCheckOut.Enabled = true;
            //}
        }

        private void selectListOrderWithCustomerInfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.setBindingSourceControl();
            
        }

       



    }
}
