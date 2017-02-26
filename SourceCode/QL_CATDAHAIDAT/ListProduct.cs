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
    public partial class ListProduct : Form
    {
        bool isViewMode;
        bool isInsertMode;
        bool isEditMode;
        public ListProduct()
        {
            InitializeComponent();
            
        }

        private void setViewMode ()
        {
            txtProductName.Enabled = false;
            txtProductPrice.Enabled = false;
            txtDescription.Enabled = false;
            txtUnit.Enabled = false;

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;

            isViewMode = true;
            isEditMode = false;
            isInsertMode = false;

            btnDelete.Text = "Xóa";
        }

        private void setEditMode()
        {
            txtProductName.Enabled = true;
            txtProductPrice.Enabled = true;
            txtDescription.Enabled = true;
            txtUnit.Enabled = true;

            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;

            btnDelete.Text = "Hủy";

            isViewMode = false;
            isEditMode = true;
            isInsertMode = false;
        }
        private void setInsertMode()
        {
            txtProductName.Enabled = true;
            txtProductPrice.Enabled = true;
            txtDescription.Enabled = true;
            txtUnit.Enabled = true;

            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtDescription.Text = "";
            txtUnit.Text = "";

            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;

            btnDelete.Text = "Hủy";

            isViewMode = false;
            isEditMode = false;
            isInsertMode = true;
        }

        private void ListProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.M_SANPHAM' table. You can move, or remove it, as needed.
            this.m_SANPHAMTableAdapter.Connection.ConnectionString = Common.GetInstance().CurrentShop;
            this.m_SANPHAMTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_SANPHAM);
            Binding b = new Binding("Text", this.mSANPHAMBindingSource, "TRANG_THAI", true);
            b.Format += b_Format;
            lblStatus.DataBindings.Add(b);
            this.setViewMode();
        }

        void b_Format(object sender, ConvertEventArgs e)
        {
            if (e.Value == null || e.Value.ToString().Equals(""))
                return;
            if (int.Parse(e.Value.ToString()) == 1)
                e.Value = "Còn hàng";
            else
                e.Value = "Ngưng kinh doanh";

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setEditMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isEditMode)
            {
                try
                {
                    this.dB_QLCatDaHaiDatDataSet.M_SANPHAM.AcceptChanges();
                    this.mSANPHAMBindingSource.EndEdit();
                    this.m_SANPHAMTableAdapter.Update(this.dB_QLCatDaHaiDatDataSet.M_SANPHAM);
                    this.setViewMode();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu không thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(isInsertMode)
            {
                DB_QLCatDaHaiDatDataSet.M_SANPHAMRow newRow = dB_QLCatDaHaiDatDataSet.M_SANPHAM.NewM_SANPHAMRow();
                newRow.TEN_SP = this.txtProductName.Text;
                newRow.GIA_SP = double.Parse(this.txtProductPrice.Text);
                newRow.GHI_CHU = this.txtDescription.Text;
                newRow.DON_VI_TINH = this.txtUnit.Text;
                newRow.TRANG_THAI = 1;

                this.dB_QLCatDaHaiDatDataSet.M_SANPHAM.Rows.Add(newRow);
                m_SANPHAMTableAdapter.Update(this.dB_QLCatDaHaiDatDataSet.M_SANPHAM);
                setViewMode();
                this.m_SANPHAMTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_SANPHAM);
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(btnDelete.Text.Equals("Hủy"))
            {

            }
            else
            {
                if(MessageBox.Show("Bạn muốn xóa dòng này ?",
                    "Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int maSP = int.Parse(this.dgListProduct.CurrentRow.Cells[0].Value.ToString());
                    foreach(DataRow row in this.dB_QLCatDaHaiDatDataSet.M_SANPHAM.Rows)
                    {
                        int rowid = int.Parse(row[0].ToString());
                        if(maSP==rowid)
                        {
                            row[5] = -1;
                            this.dB_QLCatDaHaiDatDataSet.M_SANPHAM.AcceptChanges();
                            this.mSANPHAMBindingSource.EndEdit();
                            this.m_SANPHAMTableAdapter.Update(this.dB_QLCatDaHaiDatDataSet.M_SANPHAM);
                            this.setViewMode();
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setInsertMode();
        }




    }
}
