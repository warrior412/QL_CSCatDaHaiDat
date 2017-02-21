using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;


namespace QL_CATDAHAIDAT
{
    public partial class AddNewOrder : Form
    {
        double selectedPrice = 0;
        double totalAmount = 0;
        DB_QLCatDaHaiDatDataSet.GetProductPriceListByCustomerRow currentRow = null;

        DataTable dtOrder = new DataTable();
        public AddNewOrder()
        {
            InitializeComponent();
            txtOther.Enabled = false;
            txtOther.Text = "0";
            txtQuantity.Text = "0";
            initOrderDataTable();
        }

        private void initOrderDataTable()
        {
            dtOrder.Columns.Clear();
            dtOrder.Columns.Add("Mã sản phẩm", typeof(string));
            dtOrder.Columns.Add("Tên sản phẩm", typeof(string));
            dtOrder.Columns.Add("GIA_HIDDEN", typeof(string));
            dtOrder.Columns.Add("Giá", typeof(string));
            dtOrder.Columns.Add("Số lượng", typeof(string));
            dtOrder.Columns.Add("Thành tiền", typeof(string));
            dtOrder.Columns.Add("Đơn vị tính", typeof(string));
        }

        private void AddNewOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.M_KHACHHANG' table. You can move, or remove it, as needed.
            this.m_KHACHHANGTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);
            this.getProductPriceListByCustomerTableAdapter.Fill(dB_QLCatDaHaiDatDataSet.GetProductPriceListByCustomer, int.Parse(comboBox1.SelectedValue.ToString()));

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
                return;
            this.getProductPriceListByCustomerTableAdapter.Fill(dB_QLCatDaHaiDatDataSet.GetProductPriceListByCustomer, int.Parse(comboBox1.SelectedValue.ToString()));
        }
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null)
                return;
            
        }


        void doCalculate()
        {
            currentRow =(DB_QLCatDaHaiDatDataSet.GetProductPriceListByCustomerRow)
                ((DataRowView)getProductPriceListByCustomerBindingSource.Current).Row;
            float quantity = float.Parse(txtQuantity.Text);
            if (rdPriceA.Checked)
            {
                selectedPrice = currentRow.IsGIA_ANull() ? 0 : currentRow.GIA_A;
                lblTotal.Text = Common.GetInstance().getMoneyFormatByDouble(quantity * selectedPrice);
                txtOther.Enabled = false;
            }
            if (rdPriceB.Checked)
            {
                selectedPrice = currentRow.IsGIA_BNull() ? 0 : currentRow.GIA_B;
                lblTotal.Text = Common.GetInstance().getMoneyFormatByDouble(quantity * selectedPrice);
                txtOther.Enabled = false;
            }
            if (rdPriceC.Checked)
            {
                selectedPrice = currentRow.IsGIA_CNull() ? 0 : currentRow.GIA_C; ;
                lblTotal.Text = Common.GetInstance().getMoneyFormatByDouble(quantity * selectedPrice);
                txtOther.Enabled = false;
            }
            if (rdOther.Checked)
            {
                selectedPrice = double.Parse(txtOther.Text);
                lblTotal.Text = Common.GetInstance().getMoneyFormatByDouble(quantity * selectedPrice);
                txtOther.Enabled = true;
            }
        }
        private void rdPriceA_CheckedChanged(object sender, EventArgs e)
        {
            doCalculate();
        }

        private void rdPriceB_CheckedChanged(object sender, EventArgs e)
        {
            doCalculate();
        }

        private void rdPriceC_CheckedChanged(object sender, EventArgs e)
        {
            doCalculate();
        }

        private void rdOther_CheckedChanged(object sender, EventArgs e)
        {
            doCalculate();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text.Trim().Equals(""))
                    txtQuantity.Text = "0";
                if (txtOther.Text.Trim().Equals(""))
                    txtOther.Text = "0";
                float quantity = float.Parse(txtQuantity.Text);
                lblTotal.Text = Common.GetInstance().getMoneyFormatByDouble(quantity * selectedPrice);
            }catch (Exception ex)
            {
                MessageBox.Show("Số lượng không hợp lệ !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void txtOther_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtOther.Text.Trim().Equals(""))
                    txtOther.Text = "0";
                if (txtQuantity.Text.Trim().Equals(""))
                    txtQuantity.Text = "0";
                selectedPrice = float.Parse(txtOther.Text);
                float quantity = float.Parse(txtQuantity.Text);
                lblTotal.Text = Common.GetInstance().getMoneyFormatByDouble(quantity * selectedPrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tiền không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getProductPriceListByCustomerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (getProductPriceListByCustomerBindingSource.Current == null)
                return;
            doCalculate();
            double priceA = currentRow.IsGIA_ANull()?0:currentRow.GIA_A;
            double priceB = currentRow.IsGIA_BNull()?0:currentRow.GIA_B;
            double priceC = currentRow.IsGIA_CNull()?0:currentRow.GIA_C;
            rdPriceA.Text = Common.GetInstance().getMoneyFormatByDouble(priceA);
            rdPriceB.Text = Common.GetInstance().getMoneyFormatByDouble(priceB);
            rdPriceC.Text = Common.GetInstance().getMoneyFormatByDouble(priceC);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            foreach(DataRow row in dtOrder.Rows)
            {
                if(row[0].Equals(currentRow.MA_SP.ToString()))
                {
                    MessageBox.Show("Sản phẩm đã được chọn, vui lòng chọn sản phẩm khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            dtOrder.Rows.Add(currentRow.MA_SP, currentRow.TEN_SP, selectedPrice.ToString(), Common.GetInstance().getMoneyFormatByDouble(selectedPrice), float.Parse(txtQuantity.Text), Common.GetInstance().getMoneyFormatByDouble(float.Parse(txtQuantity.Text)*selectedPrice),lblUnit.Text);
            totalAmount += selectedPrice * float.Parse(txtQuantity.Text);
            lblTotalAmount.Text = Common.GetInstance().getMoneyFormatByDouble(totalAmount);
            dataGridView1.DataSource = dtOrder;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            totalAmount = 0;
            foreach (DataRow row in dtOrder.Rows)
            {
                totalAmount += double.Parse(row[2].ToString()) * double.Parse(row[4].ToString());
            }
            lblTotalAmount.Text = Common.GetInstance().getMoneyFormatByDouble(totalAmount);
        }

        private void btnDoOrder_Click(object sender, EventArgs e)
        {
            if(totalAmount<=0)
            {
                MessageBox.Show("Đơn đặt hàng không hợp lệ. Tổng tiền phải lớn hơn không.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string hd_id = "";
            using (TransactionScope ts = new TransactionScope() )
            {
                try
                {
                    DateTime currentDate = DateTime.Now;
                    int id_kh = int.Parse(comboBox1.SelectedValue.ToString());
                    object rs = t_HOADONTableAdapter1.SelectOrderIDByCustomer(id_kh);
                    
                    if (rs == null)
                    {
                        hd_id = t_HOADONTableAdapter1.InsertQuery(currentDate, textBox3.Text, totalAmount, 0, id_kh).ToString();
                    }
                    else
                    {
                        hd_id = rs.ToString();
                        t_HOADONTableAdapter1.UpdateTotalAmount(totalAmount, hd_id);
                    }
                    foreach (DataRow row in dtOrder.Rows)
                    {
                        t_CHITIETHOADONTableAdapter1.Insert(hd_id,
                            int.Parse(row[0].ToString()),
                            currentDate,
                            double.Parse(row[4].ToString()),
                            double.Parse(row[2].ToString()), "", 1);
                    }
                    ts.Complete();
                }catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra khi tạo đơn hàng. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    
                }finally
                {
                    MessageBox.Show("Đơn hàng đã được tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ts.Dispose();
                }

                PrintOrder printpreviewer = new PrintOrder(lblCustomerName.Text, lblAddress.Text, lblPhone.Text, Common.GetInstance().getMoneyFormatByDouble(totalAmount));
                printpreviewer.ma_hd = hd_id;
                printpreviewer.DtReport = dtOrder;
                printpreviewer.ShowDialog();
            }

            
        }

        

        





        
    }
}
