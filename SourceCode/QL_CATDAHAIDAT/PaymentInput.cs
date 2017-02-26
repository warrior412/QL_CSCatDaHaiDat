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
    public partial class PaymentInput : Form
    {
        public double debt;
        public double payAmount;
        public PaymentInput()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PaymentInput_Load(object sender, EventArgs e)
        {
            lblDebt.Text = Common.GetInstance().getMoneyFormatByDouble(debt);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("-"))
                    return;
                if (textBox1.Text.Trim().Equals(""))
                    textBox1.Text = "0";
                double paidAmount = double.Parse(textBox1.Text);
                if (paidAmount > debt)
                {
                    textBox1.Text = debt.ToString();
                    textBox1.SelectionLength = textBox1.Text.Length;
                }
                    
                lblInputMoney.Text = Common.GetInstance().getMoneyFormatByDouble(double.Parse(textBox1.Text));
            }catch(Exception ex)
            {
                MessageBox.Show("Chỉ được nhập số !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "0";
                textBox1.SelectionLength = textBox1.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            payAmount = double.Parse(textBox1.Text);
            string message = "Thực hiện thánh toán với số tiền là " + Common.GetInstance().getMoneyFormatByDouble(payAmount) + " .";
            DialogResult = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

    }
}
