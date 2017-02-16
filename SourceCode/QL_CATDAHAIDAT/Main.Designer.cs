namespace QL_CATDAHAIDAT
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnListProduct = new System.Windows.Forms.ToolStripButton();
            this.btnListCutomer = new System.Windows.Forms.ToolStripButton();
            this.btnListOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListProduct,
            this.toolStripSeparator1,
            this.btnListCutomer,
            this.toolStripSeparator2,
            this.btnListOrder});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 78);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 78);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 78);
            // 
            // btnListProduct
            // 
            this.btnListProduct.AutoSize = false;
            this.btnListProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnListProduct.Image = global::QL_CATDAHAIDAT.Properties.Resources.package_icon;
            this.btnListProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListProduct.Name = "btnListProduct";
            this.btnListProduct.Size = new System.Drawing.Size(98, 75);
            this.btnListProduct.Text = "Mặt hàng";
            this.btnListProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListProduct.ToolTipText = "Mặt hàng";
            this.btnListProduct.Click += new System.EventHandler(this.btnListProduct_Click);
            // 
            // btnListCutomer
            // 
            this.btnListCutomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnListCutomer.Image = global::QL_CATDAHAIDAT.Properties.Resources.Customer_icon;
            this.btnListCutomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListCutomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListCutomer.Name = "btnListCutomer";
            this.btnListCutomer.Size = new System.Drawing.Size(95, 75);
            this.btnListCutomer.Text = "Khách hàng";
            this.btnListCutomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListCutomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListCutomer.Click += new System.EventHandler(this.btnListCutomer_Click);
            // 
            // btnListOrder
            // 
            this.btnListOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnListOrder.Image = global::QL_CATDAHAIDAT.Properties.Resources.order_icon;
            this.btnListOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListOrder.Name = "btnListOrder";
            this.btnListOrder.Size = new System.Drawing.Size(74, 75);
            this.btnListOrder.Text = "Hóa đơn";
            this.btnListOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListOrder.Click += new System.EventHandler(this.btnListOrder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 557);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnListProduct;
        private System.Windows.Forms.ToolStripButton btnListCutomer;
        private System.Windows.Forms.ToolStripButton btnListOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}