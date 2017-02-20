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
    public partial class SetProductPrice : Form
    {
        private int ma_kh;

        public int Ma_kh
        {
            get { return ma_kh; }
            set { ma_kh = value; }
        }
        public SetProductPrice()
        {
            InitializeComponent();
        }

        private void SetProductPrice_Load(object sender, EventArgs e)
        {
            this.getProductPriceListByCustomerTableAdapter.Fill(dB_QLCatDaHaiDatDataSet.GetProductPriceListByCustomer, this.Ma_kh);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn lưu thông tin giá sản phẩm ?",
                "Xác nhận",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                int ma_sp = int.Parse(this.dataGridView1.CurrentRow.Cells[7].Value.ToString());
                this.getProductPriceListByCustomerTableAdapter.InsertT_GIASANPHAM
                    (Ma_kh, 
                    ma_sp, 
                    double.Parse(txtGiaA.Text), 
                    double.Parse(txtGiaB.Text), 
                    double.Parse(txtGiaC.Text), 
                    1);
                this.getProductPriceListByCustomerTableAdapter.Fill(dB_QLCatDaHaiDatDataSet.GetProductPriceListByCustomer, this.Ma_kh);
            }
        }
    }
}
