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
    public partial class ListOrder : Form
    {
        public ListOrder()
        {
            InitializeComponent();
        }

        private void ListOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.GetOrderList' table. You can move, or remove it, as needed.
            this.getOrderListTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.GetOrderList);
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.GetOrderList' table. You can move, or remove it, as needed.
            this.getOrderListTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.GetOrderList);
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.T_HOADON' table. You can move, or remove it, as needed.

        }



    }
}
