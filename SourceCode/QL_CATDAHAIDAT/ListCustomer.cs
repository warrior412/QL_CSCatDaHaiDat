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

        DB_QLCatDaHaiDatDataSet.M_KHACHHANGRow currentRow;
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

            rdbKhachLe.Enabled = rdbVua.Enabled = false;

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

            rdbKhachLe.Enabled = rdbVua.Enabled = true;

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

            rdbKhachLe.Enabled = rdbVua.Enabled = true;

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
            try {
                if (isEditMode)
                {

                    m_KHACHHANGTableAdapter.UpdateCustomer(txtName.Text, txtAddress.Text, txtPhone.Text, txtDescription.Text, rdbKhachLe.Checked ? 0 : 1, 1, currentRow.MA_KH);
                    this.setViewMode();
                    this.m_KHACHHANGTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);

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
                    this.m_KHACHHANGTableAdapter.InsertCustomer(newRow.TEN_KH, newRow.DIA_CHI, newRow.SO_DT, newRow.GHI_CHU, 1, rdbKhachLe.Checked ? 0 : 1);
                    setViewMode();
                    this.m_KHACHHANGTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu không thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.ListCustomer_Load(this,null);
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa dòng này ?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m_KHACHHANGTableAdapter.DeleteCustomer(currentRow.MA_KH);
                    this.m_KHACHHANGTableAdapter.Fill(this.dB_QLCatDaHaiDatDataSet.M_KHACHHANG);
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

        private void mKHACHHANGBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if(mKHACHHANGBindingSource.Current !=null)
            {
                currentRow = (DB_QLCatDaHaiDatDataSet.M_KHACHHANGRow)((DataRowView)mKHACHHANGBindingSource.Current).Row;
                if (!currentRow.IsLOAI_KHACHNull() && currentRow.LOAI_KHACH == 0)//Khach le
                {
                    rdbKhachLe.Checked = true;
                }
                else
                {
                    rdbVua.Checked = true;
                }
            }
        }
    }
}
