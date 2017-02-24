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

    }
}
