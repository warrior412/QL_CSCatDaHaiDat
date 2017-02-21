namespace QL_CATDAHAIDAT
{
    partial class ListOrder
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYLAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tONGTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getOrderListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_QLCatDaHaiDatDataSet = new QL_CATDAHAIDAT.DB_QLCatDaHaiDatDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getOrderDetailByOrderIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getOrderListTableAdapter = new QL_CATDAHAIDAT.DB_QLCatDaHaiDatDataSetTableAdapters.GetOrderListTableAdapter();
            this.getOrderDetailByOrderIDTableAdapter = new QL_CATDAHAIDAT.DB_QLCatDaHaiDatDataSetTableAdapters.GetOrderDetailByOrderIDTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCatDaHaiDatDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDetailByOrderIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 477);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tất cả",
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.comboBox1.Location = new System.Drawing.Point(357, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHDDataGridViewTextBoxColumn,
            this.nGAYLAPDataGridViewTextBoxColumn,
            this.tENKHDataGridViewTextBoxColumn,
            this.sODTDataGridViewTextBoxColumn,
            this.tONGTIENDataGridViewTextBoxColumn,
            this.tRANGTHAIDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getOrderListBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(472, 416);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // mAHDDataGridViewTextBoxColumn
            // 
            this.mAHDDataGridViewTextBoxColumn.DataPropertyName = "MA_HD";
            this.mAHDDataGridViewTextBoxColumn.FillWeight = 10F;
            this.mAHDDataGridViewTextBoxColumn.HeaderText = "MA_HD";
            this.mAHDDataGridViewTextBoxColumn.Name = "mAHDDataGridViewTextBoxColumn";
            this.mAHDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAHDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nGAYLAPDataGridViewTextBoxColumn
            // 
            this.nGAYLAPDataGridViewTextBoxColumn.DataPropertyName = "NGAY_LAP";
            this.nGAYLAPDataGridViewTextBoxColumn.FillWeight = 25F;
            this.nGAYLAPDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.nGAYLAPDataGridViewTextBoxColumn.Name = "nGAYLAPDataGridViewTextBoxColumn";
            this.nGAYLAPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENKHDataGridViewTextBoxColumn
            // 
            this.tENKHDataGridViewTextBoxColumn.DataPropertyName = "TEN_KH";
            this.tENKHDataGridViewTextBoxColumn.FillWeight = 40F;
            this.tENKHDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tENKHDataGridViewTextBoxColumn.Name = "tENKHDataGridViewTextBoxColumn";
            this.tENKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sODTDataGridViewTextBoxColumn
            // 
            this.sODTDataGridViewTextBoxColumn.DataPropertyName = "SO_DT";
            this.sODTDataGridViewTextBoxColumn.FillWeight = 30F;
            this.sODTDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sODTDataGridViewTextBoxColumn.Name = "sODTDataGridViewTextBoxColumn";
            this.sODTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sODTDataGridViewTextBoxColumn.Visible = false;
            // 
            // tONGTIENDataGridViewTextBoxColumn
            // 
            this.tONGTIENDataGridViewTextBoxColumn.DataPropertyName = "TONG_TIEN";
            this.tONGTIENDataGridViewTextBoxColumn.FillWeight = 25F;
            this.tONGTIENDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tONGTIENDataGridViewTextBoxColumn.Name = "tONGTIENDataGridViewTextBoxColumn";
            this.tONGTIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRANGTHAIDataGridViewTextBoxColumn
            // 
            this.tRANGTHAIDataGridViewTextBoxColumn.DataPropertyName = "TRANG_THAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.HeaderText = "TRANG_THAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.Name = "tRANGTHAIDataGridViewTextBoxColumn";
            this.tRANGTHAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRANGTHAIDataGridViewTextBoxColumn.Visible = false;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIA_CHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIA_CHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIACHIDataGridViewTextBoxColumn.Visible = false;
            // 
            // getOrderListBindingSource1
            // 
            this.getOrderListBindingSource1.DataMember = "GetOrderList";
            this.getOrderListBindingSource1.DataSource = this.dB_QLCatDaHaiDatDataSet;
            // 
            // dB_QLCatDaHaiDatDataSet
            // 
            this.dB_QLCatDaHaiDatDataSet.DataSetName = "DB_QLCatDaHaiDatDataSet";
            this.dB_QLCatDaHaiDatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCheckOut);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.lblCustomerName);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.lblOrderDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(503, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 477);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(21, 425);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(130, 37);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "THANH TOÁN";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // button2
            // 
            this.button2.Image = global::QL_CATDAHAIDAT.Properties.Resources.close;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(297, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "HỦY HÓA ĐƠN";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::QL_CATDAHAIDAT.Properties.Resources.printer;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(157, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "IN LẠI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tình trạng  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ  :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getOrderListBindingSource1, "DIA_CHI", true));
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(121, 84);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(127, 15);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Ngày lập hóa đơn :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(120, 143);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(151, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "ĐÃ THANH TOÁN";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getOrderListBindingSource1, "TEN_KH", true));
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(121, 55);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(127, 15);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Ngày lập hóa đơn :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getOrderListBindingSource1, "SO_DT", true));
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(121, 115);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(127, 15);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Ngày lập hóa đơn :";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getOrderListBindingSource1, "NGAY_LAP", true));
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(121, 25);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(127, 15);
            this.lblOrderDate.TabIndex = 1;
            this.lblOrderDate.Text = "Ngày lập hóa đơn :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày lập hóa đơn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách hàng :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(6, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 248);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tENSPDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.gIADataGridViewTextBoxColumn,
            this.tRANGTHAIDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.getOrderDetailByOrderIDBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 10);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.RowTemplate.Height = 26;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(430, 231);
            this.dataGridView2.TabIndex = 0;
            // 
            // tENSPDataGridViewTextBoxColumn
            // 
            this.tENSPDataGridViewTextBoxColumn.DataPropertyName = "TEN_SP";
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "Tên mặt hàng";
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            this.tENSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SO_LUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "Số luợng đặt";
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            this.sOLUONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIADataGridViewTextBoxColumn
            // 
            this.gIADataGridViewTextBoxColumn.DataPropertyName = "GIA";
            this.gIADataGridViewTextBoxColumn.HeaderText = "Giá";
            this.gIADataGridViewTextBoxColumn.Name = "gIADataGridViewTextBoxColumn";
            this.gIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRANGTHAIDataGridViewTextBoxColumn1
            // 
            this.tRANGTHAIDataGridViewTextBoxColumn1.DataPropertyName = "TRANG_THAI";
            this.tRANGTHAIDataGridViewTextBoxColumn1.HeaderText = "TRANG_THAI";
            this.tRANGTHAIDataGridViewTextBoxColumn1.Name = "tRANGTHAIDataGridViewTextBoxColumn1";
            this.tRANGTHAIDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tRANGTHAIDataGridViewTextBoxColumn1.Visible = false;
            // 
            // getOrderDetailByOrderIDBindingSource
            // 
            this.getOrderDetailByOrderIDBindingSource.DataMember = "GetOrderDetailByOrderID";
            this.getOrderDetailByOrderIDBindingSource.DataSource = this.dB_QLCatDaHaiDatDataSet;
            // 
            // getOrderListTableAdapter
            // 
            this.getOrderListTableAdapter.ClearBeforeFill = true;
            // 
            // getOrderDetailByOrderIDTableAdapter
            // 
            this.getOrderDetailByOrderIDTableAdapter.ClearBeforeFill = true;
            // 
            // ListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÀN HÌNH DANH SÁCH HÓA ĐƠN";
            this.Load += new System.EventHandler(this.ListOrder_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_QLCatDaHaiDatDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOrderDetailByOrderIDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DB_QLCatDaHaiDatDataSet dB_QLCatDaHaiDatDataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCheckOut;
        private DB_QLCatDaHaiDatDataSetTableAdapters.GetOrderListTableAdapter getOrderListTableAdapter;
        private System.Windows.Forms.BindingSource getOrderDetailByOrderIDBindingSource;
        private DB_QLCatDaHaiDatDataSetTableAdapters.GetOrderDetailByOrderIDTableAdapter getOrderDetailByOrderIDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOADONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getOrderListBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANGTHAIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYLAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tONGTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANGTHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
    }
}