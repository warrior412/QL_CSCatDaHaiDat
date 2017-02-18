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
    public partial class PrintProductList : Form
    {
        public PrintProductList()
        {
            InitializeComponent();
        }

        private void PrintProductList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_QLCatDaHaiDatDataSet.M_SANPHAM' table. You can move, or remove it, as needed.
            this.M_SANPHAMTableAdapter.Fill(this.DB_QLCatDaHaiDatDataSet.M_SANPHAM);

            this.reportViewer1.RefreshReport();
        }
    }
}
