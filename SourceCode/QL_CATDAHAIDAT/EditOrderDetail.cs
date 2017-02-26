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
    public partial class EditOrderDetail : Form
    {
        public EditOrderDetail()
        {
            InitializeComponent();
        }
        public void setDetailOrder(string orderTime, string customername, string price, string productname,string quantity,string total)
        {
            this.lblOrderTime.Text = orderTime;
            this.lblCustomerName.Text = customername;
            this.lblPrice.Text = price;
            this.lblProductname.Text = productname;
            this.lblQuantity.Text = quantity;
            this.lblTotal.Text = total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy đơn hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }
    }
}
