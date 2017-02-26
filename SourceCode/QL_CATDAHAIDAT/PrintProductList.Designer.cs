namespace QL_CATDAHAIDAT
{
    partial class PrintProductList
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DB_QLCatDaHaiDatDataSet = new QL_CATDAHAIDAT.DB_QLCatDaHaiDatDataSet();
            this.GetProductInfoForPrintingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetProductInfoForPrintingTableAdapter = new QL_CATDAHAIDAT.DB_QLCatDaHaiDatDataSetTableAdapters.GetProductInfoForPrintingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DB_QLCatDaHaiDatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetProductInfoForPrintingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetProductInfoForPrintingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CATDAHAIDAT.PrintProductList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(609, 505);
            this.reportViewer1.TabIndex = 0;
            // 
            // DB_QLCatDaHaiDatDataSet
            // 
            this.DB_QLCatDaHaiDatDataSet.DataSetName = "DB_QLCatDaHaiDatDataSet";
            this.DB_QLCatDaHaiDatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GetProductInfoForPrintingBindingSource
            // 
            this.GetProductInfoForPrintingBindingSource.DataMember = "GetProductInfoForPrinting";
            this.GetProductInfoForPrintingBindingSource.DataSource = this.DB_QLCatDaHaiDatDataSet;
            // 
            // GetProductInfoForPrintingTableAdapter
            // 
            this.GetProductInfoForPrintingTableAdapter.ClearBeforeFill = true;
            // 
            // PrintProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 504);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintProductList";
            this.Text = "PrintProductList";
            this.Load += new System.EventHandler(this.PrintProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DB_QLCatDaHaiDatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetProductInfoForPrintingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetProductInfoForPrintingBindingSource;
        private DB_QLCatDaHaiDatDataSet DB_QLCatDaHaiDatDataSet;
        private DB_QLCatDaHaiDatDataSetTableAdapters.GetProductInfoForPrintingTableAdapter GetProductInfoForPrintingTableAdapter;
    }
}