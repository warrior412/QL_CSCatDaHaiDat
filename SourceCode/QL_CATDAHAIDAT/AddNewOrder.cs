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
    public partial class AddNewOrder : Form
    {
        public AddNewOrder()
        {
            InitializeComponent();
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
            this.getProductPriceListByCustomerTableAdapter.Fill(dB_QLCatDaHaiDatDataSet.GetProductPriceListByCustomer, int.Parse(comboBox1.SelectedValue.ToString()));
        }





        
    }
}
