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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            ListProduct frm = new ListProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnListCutomer_Click(object sender, EventArgs e)
        {
            ListCustomer frm = new ListCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnListOrder_Click(object sender, EventArgs e)
        {
            ListOrder frm = new ListOrder();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
