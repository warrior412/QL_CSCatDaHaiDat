namespace QL_CATDAHAIDAT
{
    partial class PrintOrder
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
            this.SELECTDETAILORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_QLCatDaHaiDatDataSet = new QL_CATDAHAIDAT.DB_QLCatDaHaiDatDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SELECTDETAILORDERTableAdapter = new QL_CATDAHAIDAT.DB_QLCatDaHaiDatDataSetTableAdapters.SELECTDETAILORDERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SELECTDETAILORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_QLCatDaHaiDatDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SELECTDETAILORDERBindingSource
            // 
            this.SELECTDETAILORDERBindingSource.DataMember = "SELECTDETAILORDER";
            this.SELECTDETAILORDERBindingSource.DataSource = this.DB_QLCatDaHaiDatDataSet;
            // 
            // DB_QLCatDaHaiDatDataSet
            // 
            this.DB_QLCatDaHaiDatDataSet.DataSetName = "DB_QLCatDaHaiDatDataSet";
            this.DB_QLCatDaHaiDatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.SELECTDETAILORDERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CATDAHAIDAT.PrintOrder.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(667, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // SELECTDETAILORDERTableAdapter
            // 
            this.SELECTDETAILORDERTableAdapter.ClearBeforeFill = true;
            // 
            // PrintOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 540);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintOrder";
            this.Load += new System.EventHandler(this.PrintOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SELECTDETAILORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_QLCatDaHaiDatDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SELECTDETAILORDERBindingSource;
        private DB_QLCatDaHaiDatDataSet DB_QLCatDaHaiDatDataSet;
        private DB_QLCatDaHaiDatDataSetTableAdapters.SELECTDETAILORDERTableAdapter SELECTDETAILORDERTableAdapter;
    }
}