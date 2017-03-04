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
            selectListOrderWithCustomerInfoTableAdapter.Connection.ConnectionString = Common.GetInstance().CurrentShop;
            getOrderDetailByOrderIDTableAdapter.Connection.ConnectionString = Common.GetInstance().CurrentShop;
            t_CHITIETHOADONTableAdapter1.Connection.ConnectionString = Common.GetInstance().CurrentShop;
            t_HOADONTableAdapter1.Connection.ConnectionString = Common.GetInstance().CurrentShop;

            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfo' table. You can move, or remove it, as needed.
            this.selectListOrderWithCustomerInfoTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfo);
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

            if(!currentRow.IsTRANG_THAINull())
            {
                if(currentRow.TRANG_THAI == 0)
                {
                    lblStatus.Text = "Hóa đơn đang mở";
                }
                else if(currentRow.TRANG_THAI == 1)
                {
                    if (total > paid)
                    {
                        lblStatus.Text = "Đã chốt hóa đơn";
                    }
                    else if (total == paid)
                    {
                        lblStatus.Text = "Đã thanh toán";
                    }
                }
            }

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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                selectListOrderWithCustomerInfoBindingSource.Filter = string.Format("TRANG_THAI < 100");
            }
            else if (comboBox1.SelectedIndex == 1) //Đã thanh toán
            {
                selectListOrderWithCustomerInfoBindingSource.Filter = string.Format("TRANG_THAI = 1 and TONG_TIEN = TIEN_TRA");
            }
            else if(comboBox1.SelectedIndex == 2) //Đã chốt
            {
                selectListOrderWithCustomerInfoBindingSource.Filter = string.Format("TRANG_THAI = 1 and TONG_TIEN > TIEN_TRA");
            }else //đang mở
            {
                selectListOrderWithCustomerInfoBindingSource.Filter = string.Format("TRANG_THAI = 0");
            }
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
                    try
                    {
                        double payAmount = dialog.payAmount;
                        t_HOADONTableAdapter1.DoPaymentWithAmount(payAmount, currentRow.MA_HD);
                        this.selectListOrderWithCustomerInfoTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfo);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Không thể thực hiện thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
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

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(currentRow.TRANG_THAI == 1)
            {
                if (MessageBox.Show("Hóa đơn đã được chốt. Bạn có chắc vẫn muốn thực hiện việc hủy đặt hàng ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                    return;
            }


            DB_QLCatDaHaiDatDataSet.GetOrderDetailByOrderIDRow selectedRow = (DB_QLCatDaHaiDatDataSet.GetOrderDetailByOrderIDRow)
                ((DataRowView)getOrderDetailByOrderIDBindingSource.Current).Row;
            if (selectedRow == null)
                return;
            EditOrderDetail dialog = new EditOrderDetail();
            dialog.setDetailOrder(selectedRow.THOI_GIAN_TAO.ToString(),
                currentRow.TEN_KH,
                Common.GetInstance().getMoneyFormatByDouble(selectedRow.GIA),
                selectedRow.TEN_SP,
                selectedRow.SO_LUONG.ToString(),
                Common.GetInstance().getMoneyFormatByDouble(selectedRow.SO_LUONG * selectedRow.GIA));
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                t_CHITIETHOADONTableAdapter1.DeleteOrderDetail(currentRow.MA_HD, selectedRow.ID);
                this.selectListOrderWithCustomerInfoTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfo);
            }
                
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfoRow row = (DB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfoRow)
                ((DataRowView)selectListOrderWithCustomerInfoBindingSource[e.RowIndex]).Row;
            if(row!=null)
            {
                if(row.TRANG_THAI == 0)
                {
                    e.CellStyle.BackColor = Color.White;
                    e.CellStyle.SelectionForeColor = Color.Blue;
                }
                else
                {
                    if(row.TRANG_THAI == 1 && row.TONG_TIEN == row.TIEN_TRA)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.SelectionBackColor = Color.LightGreen;
                        e.CellStyle.SelectionForeColor = Color.Blue;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.DeepSkyBlue;
                        e.CellStyle.SelectionBackColor = Color.DeepSkyBlue;
                        e.CellStyle.SelectionForeColor = Color.Blue;
                    }
                }

            }
        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            if (currentRow!=null)
            {
                //int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //float totalAmount = float.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                //CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                //string stotal = totalAmount.ToString("#,###", cul.NumberFormat);
                //PrintOrder printpreviewer = new PrintOrder(lblCustomerName.Text, lblAddress.Text, lblPhone.Text, stotal);
                //printpreviewer.ma_hd = id;
                //printpreviewer.ShowDialog();
                PrintOrder printpreviewer = new PrintOrder(lblCustomerName.Text, 
                    lblAddress.Text, 
                    lblPhone.Text, 
                    Common.GetInstance().getMoneyFormatByDouble(currentRow.TONG_TIEN),
                    Common.GetInstance().getMoneyFormatByDouble(currentRow.TIEN_TRA),
                    Common.GetInstance().getMoneyFormatByDouble(currentRow.TONG_TIEN-currentRow.TIEN_TRA));
                printpreviewer.ma_hd = currentRow.MA_HD;
                printpreviewer.DtReport = null;
                printpreviewer.ShowDialog();
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                return;
            try
            {
                if (currentRow == null)
                    return;
                t_HOADONTableAdapter1.DeleteOrderByID(currentRow.MA_HD);
                this.selectListOrderWithCustomerInfoTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.SelectListOrderWithCustomerInfo);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đã có lỗi xảy ra. Xóa hóa đơn thất bại.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       



    }
}
