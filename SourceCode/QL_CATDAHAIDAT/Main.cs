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
            btnSelectShop_Click(this, null);
        }
        public bool checkBeforeOpen()
        {
            if (this.MdiChildren.Length > 0)
            {
                MessageBox.Show("Vui lòng tắt màn hình đang mở trước khi mở màn hình mới", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
                
            return true;
        }
        public void changeShopName (string name)
        {
            this.Text = name;
            this.toolStripLabel1.Text = name;
        }


        private void btnListProduct_Click(object sender, EventArgs e)
        {
            if (!checkBeforeOpen())
                return;
            ListProduct frm = new ListProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnListCutomer_Click(object sender, EventArgs e)
        {
            if (!checkBeforeOpen())
                return;
            ListCustomer frm = new ListCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnListOrder_Click(object sender, EventArgs e)
        {
            if (!checkBeforeOpen())
                return;
            AddNewOrder frm = new AddNewOrder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnHistoryOrder_Click(object sender, EventArgs e)
        {
            if (!checkBeforeOpen())
                return;
            ListOrder frm = new ListOrder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectShop_Click(object sender, EventArgs e)
        {
            if (!checkBeforeOpen())
                return;
            ShopSelect dialog = new ShopSelect();
            dialog.MdiParent = this;
            dialog.Show();
        }

        private void btnAnalyst_Click(object sender, EventArgs e)
        {
            if (!checkBeforeOpen())
                return;
            AnalystForm dialog = new AnalystForm();
            dialog.MdiParent = this;
            dialog.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!checkBeforeOpen())
                return;
            BackUpForm dialog = new BackUpForm();
            dialog.MdiParent = this;
            dialog.Show();
        }

    }
}
