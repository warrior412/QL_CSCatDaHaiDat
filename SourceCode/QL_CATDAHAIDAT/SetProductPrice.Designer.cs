namespace QL_CATDAHAIDAT
{
    partial class SetProductPrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getProductPriceListByCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLCatDaHaiDatDataSet = new QL_CATDAHAIDAT.DB_QLCatDaHaiDatDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaC = new System.Windows.Forms.TextBox();
            this.txtGiaB = new System.Windows.Forms.TextBox();
            this.txtGiaA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dBQLCatDaHaiDatDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getProductPriceListByCustomerTableAdapter = new QL_CATDAHAIDAT.DB_QLCatDaHaiDatDataSetTableAdapters.GetProductPriceListByCustomerTableAdapter();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONVITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIABDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tINHTRANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductPriceListByCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCatDaHaiDatDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBQLCatDaHaiDatDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tENSPDataGridViewTextBoxColumn,
            this.dONVITINHDataGridViewTextBoxColumn,
            this.gIAADataGridViewTextBoxColumn,
            this.gIABDataGridViewTextBoxColumn,
            this.gIACDataGridViewTextBoxColumn,
            this.tINHTRANGDataGridViewTextBoxColumn,
            this.kHACHHANGDataGridViewTextBoxColumn,
            this.mASPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getProductPriceListByCustomerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(312, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // getProductPriceListByCustomerBindingSource
            // 
            this.getProductPriceListByCustomerBindingSource.DataMember = "GetProductPriceListByCustomer";
            this.getProductPriceListByCustomerBindingSource.DataSource = this.dB_QLCatDaHaiDatDataSet;
            // 
            // dB_QLCatDaHaiDatDataSet
            // 
            this.dB_QLCatDaHaiDatDataSet.DataSetName = "DB_QLCatDaHaiDatDataSet";
            this.dB_QLCatDaHaiDatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtGiaC);
            this.groupBox2.Controls.Add(this.txtGiaB);
            this.groupBox2.Controls.Add(this.txtGiaA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(336, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 376);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giá";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(6, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 59);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QL_CATDAHAIDAT.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(33, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getProductPriceListByCustomerBindingSource, "TEN_SP", true));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // txtGiaC
            // 
            this.txtGiaC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getProductPriceListByCustomerBindingSource, "GIA_C", true));
            this.txtGiaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaC.Location = new System.Drawing.Point(9, 222);
            this.txtGiaC.Name = "txtGiaC";
            this.txtGiaC.Size = new System.Drawing.Size(216, 23);
            this.txtGiaC.TabIndex = 1;
            // 
            // txtGiaB
            // 
            this.txtGiaB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getProductPriceListByCustomerBindingSource, "GIA_B", true));
            this.txtGiaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaB.Location = new System.Drawing.Point(9, 160);
            this.txtGiaB.Name = "txtGiaB";
            this.txtGiaB.Size = new System.Drawing.Size(216, 23);
            this.txtGiaB.TabIndex = 1;
            // 
            // txtGiaA
            // 
            this.txtGiaA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getProductPriceListByCustomerBindingSource, "GIA_A", true));
            this.txtGiaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaA.Location = new System.Drawing.Point(9, 102);
            this.txtGiaA.Name = "txtGiaA";
            this.txtGiaA.Size = new System.Drawing.Size(216, 23);
            this.txtGiaA.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm :";
            // 
            // dBQLCatDaHaiDatDataSetBindingSource
            // 
            this.dBQLCatDaHaiDatDataSetBindingSource.DataSource = this.dB_QLCatDaHaiDatDataSet;
            this.dBQLCatDaHaiDatDataSetBindingSource.Position = 0;
            // 
            // getProductPriceListByCustomerTableAdapter
            // 
            this.getProductPriceListByCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tENSPDataGridViewTextBoxColumn
            // 
            this.tENSPDataGridViewTextBoxColumn.DataPropertyName = "TEN_SP";
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "TEN_SP";
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            this.tENSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dONVITINHDataGridViewTextBoxColumn
            // 
            this.dONVITINHDataGridViewTextBoxColumn.DataPropertyName = "DON_VI_TINH";
            this.dONVITINHDataGridViewTextBoxColumn.HeaderText = "DON_VI_TINH";
            this.dONVITINHDataGridViewTextBoxColumn.Name = "dONVITINHDataGridViewTextBoxColumn";
            this.dONVITINHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIAADataGridViewTextBoxColumn
            // 
            this.gIAADataGridViewTextBoxColumn.DataPropertyName = "GIA_A";
            this.gIAADataGridViewTextBoxColumn.HeaderText = "GIA_A";
            this.gIAADataGridViewTextBoxColumn.Name = "gIAADataGridViewTextBoxColumn";
            this.gIAADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIABDataGridViewTextBoxColumn
            // 
            this.gIABDataGridViewTextBoxColumn.DataPropertyName = "GIA_B";
            this.gIABDataGridViewTextBoxColumn.HeaderText = "GIA_B";
            this.gIABDataGridViewTextBoxColumn.Name = "gIABDataGridViewTextBoxColumn";
            this.gIABDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIACDataGridViewTextBoxColumn
            // 
            this.gIACDataGridViewTextBoxColumn.DataPropertyName = "GIA_C";
            this.gIACDataGridViewTextBoxColumn.HeaderText = "GIA_C";
            this.gIACDataGridViewTextBoxColumn.Name = "gIACDataGridViewTextBoxColumn";
            this.gIACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tINHTRANGDataGridViewTextBoxColumn
            // 
            this.tINHTRANGDataGridViewTextBoxColumn.DataPropertyName = "TINH_TRANG";
            this.tINHTRANGDataGridViewTextBoxColumn.HeaderText = "TINH_TRANG";
            this.tINHTRANGDataGridViewTextBoxColumn.Name = "tINHTRANGDataGridViewTextBoxColumn";
            this.tINHTRANGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kHACHHANGDataGridViewTextBoxColumn
            // 
            this.kHACHHANGDataGridViewTextBoxColumn.DataPropertyName = "KHACH_HANG";
            this.kHACHHANGDataGridViewTextBoxColumn.HeaderText = "KHACH_HANG";
            this.kHACHHANGDataGridViewTextBoxColumn.Name = "kHACHHANGDataGridViewTextBoxColumn";
            this.kHACHHANGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MA_SP";
            this.mASPDataGridViewTextBoxColumn.HeaderText = "MA_SP";
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            this.mASPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SetProductPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 393);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetProductPrice";
            this.Text = "Màn hình cài đặt giá";
            this.Load += new System.EventHandler(this.SetProductPrice_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductPriceListByCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCatDaHaiDatDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dBQLCatDaHaiDatDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaC;
        private System.Windows.Forms.TextBox txtGiaB;
        private System.Windows.Forms.TextBox txtGiaA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DB_QLCatDaHaiDatDataSet dB_QLCatDaHaiDatDataSet;
        private System.Windows.Forms.BindingSource dBQLCatDaHaiDatDataSetBindingSource;
        private System.Windows.Forms.BindingSource getProductPriceListByCustomerBindingSource;
        private DB_QLCatDaHaiDatDataSetTableAdapters.GetProductPriceListByCustomerTableAdapter getProductPriceListByCustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONVITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIABDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tINHTRANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kHACHHANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;

    }
}