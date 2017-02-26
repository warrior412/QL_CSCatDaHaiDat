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
    public partial class ListCustomer : Form
    {
        bool isViewMode;
        bool isInsertMode;
        bool isEditMode;
        public ListCustomer()
        {
            InitializeComponent();
            
        }

        private void setViewMode()
        {
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtDescription.Enabled = false;
            txtPhone.Enabled = false;

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
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtDescription.Enabled = true;
            txtPhone.Enabled = true;

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
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtDescription.Enabled = true;
            txtPhone.Enabled = true;

            txtName.Text = "";
            txtAddress.Text = "";
            txtDescription.Text = "";
            txtPhone.Text = "";

            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;

            btnDelete.Text = "Hủy";

            isViewMode = false;
            isEditMode = false;
            isInsertMode = true;
        }

        private void ListCustomer_Load(object sender, EventArgs e)
        {
            m_KHACHHANGTableAdapter.Connection.ConnectionString = Common.GetInstance().CurrentShop;
            // TODO: This line of code loads data into the 'dB_QLCatDaHaiDatDataSet.M_KHACHHANG' table. You can move, or remove it, as needed.
            this.m_KHACHHANGTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);
            this.setViewMode();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setInsertMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                try
                {
                    this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG.AcceptChanges();
                    this.mKHACHHANGBindingSource.EndEdit();
                    this.m_KHACHHANGTableAdapter.Update(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);
                    this.setViewMode();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu không thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (isInsertMode)
            {
                DB_QLCatDaHaiDatDataSet.M_KHACHHANGRow newRow = dB_QLCatDaHaiDatDataSet.M_KHACHHANG.NewM_KHACHHANGRow();
                newRow.TEN_KH = this.txtName.Text;
                newRow.DIA_CHI = this.txtAddress.Text;
                newRow.GHI_CHU = this.txtDescription.Text;
                newRow.SO_DT = this.txtPhone.Text;
                newRow.TRANG_THAI = 1;

                this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG.Rows.Add(newRow);
                m_KHACHHANGTableAdapter.Update(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);
                setViewMode();
                this.m_KHACHHANGTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setEditMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text.Equals("Hủy"))
            {

            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa dòng này ?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int maKH = int.Parse(this.dgCustomer.CurrentRow.Cells[0].Value.ToString());
                    DB_QLCatDaHaiDatDataSet.M_KHACHHANGRow deleteRow =
                        this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG.FindByMA_KH(maKH);
                    this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG.RemoveM_KHACHHANGRow(deleteRow);
                    m_KHACHHANGTableAdapter.Delete(maKH);
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            mKHACHHANGBindingSource.Filter = string.Format("TEN_KH LIKE '%{0}%'", txtFilter.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgCustomer.CurrentRow == null)
                return;
            SetProductPrice frm = new SetProductPrice();
            frm.Ma_kh = int.Parse(dgCustomer.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }
    }
}
