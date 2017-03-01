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

        DB_QLCatDaHaiDatDataSet.M_SANPHAMRow currentRow;

        public ListProduct()
        {
            InitializeComponent();
            
        }

        private void setViewMode ()
        {
            txtProductName.Enabled = false;
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
            txtDescription.Enabled = true;
            txtUnit.Enabled = true;

            txtProductName.Text = "";
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
            this.setViewMode();
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
                    this.m_SANPHAMTableAdapter.UpdateProduct(txtProductName.Text,txtUnit.Text,txtDescription.Text,currentRow.MA_SP);
                    this.setViewMode();
                    this.m_SANPHAMTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_SANPHAM);
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
                newRow.GHI_CHU = this.txtDescription.Text;
                newRow.DON_VI_TINH = this.txtUnit.Text;
                newRow.TRANG_THAI = 1;

                this.dB_QLCatDaHaiDatDataSet.M_SANPHAM.Rows.Add(newRow);
                m_SANPHAMTableAdapter.InsertProduct(newRow.TEN_SP,newRow.DON_VI_TINH,newRow.GHI_CHU,1);
                setViewMode();
                this.m_SANPHAMTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_SANPHAM);
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(btnDelete.Text.Equals("Hủy"))
            {
                this.ListProduct_Load(this, null);
            }
            else
            {
                if(MessageBox.Show("Bạn muốn xóa dòng này ?",
                    "Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    this.m_SANPHAMTableAdapter.DeleteProduct(currentRow.MA_SP);
                    this.setViewMode();
                    this.m_SANPHAMTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_SANPHAM);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setInsertMode();
        }

        private void mSANPHAMBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if(mSANPHAMBindingSource.Current !=null)
            {
                currentRow = (DB_QLCatDaHaiDatDataSet.M_SANPHAMRow)((DataRowView)mSANPHAMBindingSource.Current).Row;

            }
        }




    }
}
