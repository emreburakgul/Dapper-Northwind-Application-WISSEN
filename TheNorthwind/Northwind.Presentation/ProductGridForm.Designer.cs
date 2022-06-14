namespace Northwind.Presentation
{
    partial class ProductGridForm
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
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextItemUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.contextItemDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProduct.MultiSelect = false;
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewProduct.RowTemplate.Height = 25;
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1109, 412);
            this.dataGridViewProduct.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextItemUpdateProduct,
            this.contextItemDeleteProduct});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // contextItemUpdateProduct
            // 
            this.contextItemUpdateProduct.Name = "contextItemUpdateProduct";
            this.contextItemUpdateProduct.Size = new System.Drawing.Size(112, 22);
            this.contextItemUpdateProduct.Text = "Update";
            this.contextItemUpdateProduct.Click += new System.EventHandler(this.contextItemUpdateProduct_Click);
            // 
            // contextItemDeleteProduct
            // 
            this.contextItemDeleteProduct.Name = "contextItemDeleteProduct";
            this.contextItemDeleteProduct.Size = new System.Drawing.Size(112, 22);
            this.contextItemDeleteProduct.Text = "Delete";
            this.contextItemDeleteProduct.Click += new System.EventHandler(this.contextItemDeleteProduct_Click);
            // 
            // ProductGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 472);
            this.Controls.Add(this.dataGridViewProduct);
            this.Name = "ProductGridForm";
            this.Text = "ProductGridForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductGridForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextItemUpdateProduct;
        private System.Windows.Forms.ToolStripMenuItem contextItemDeleteProduct;
    }
}