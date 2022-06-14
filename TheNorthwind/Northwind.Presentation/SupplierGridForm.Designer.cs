namespace Northwind.Presentation
{
    partial class SupplierGridForm
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
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextItemUpdateSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.contextItemDeleteSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSuppliers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSuppliers.MultiSelect = false;
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.ReadOnly = true;
            this.dataGridViewSuppliers.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewSuppliers.RowTemplate.Height = 25;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(633, 426);
            this.dataGridViewSuppliers.TabIndex = 0;
            this.dataGridViewSuppliers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSuppliers_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextItemUpdateSuppliers,
            this.contextItemDeleteSuppliers});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // contextItemUpdateSuppliers
            // 
            this.contextItemUpdateSuppliers.Name = "contextItemUpdateSuppliers";
            this.contextItemUpdateSuppliers.Size = new System.Drawing.Size(112, 22);
            this.contextItemUpdateSuppliers.Text = "Update";
            this.contextItemUpdateSuppliers.Click += new System.EventHandler(this.contextItemUpdateSuppliers_Click);
            // 
            // contextItemDeleteSuppliers
            // 
            this.contextItemDeleteSuppliers.Name = "contextItemDeleteSuppliers";
            this.contextItemDeleteSuppliers.Size = new System.Drawing.Size(112, 22);
            this.contextItemDeleteSuppliers.Text = "Delete";
            this.contextItemDeleteSuppliers.Click += new System.EventHandler(this.contextItemDeleteSuppliers_Click);
            // 
            // SupplierGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Name = "SupplierGridForm";
            this.Text = "SupplierGridForm";
            this.Load += new System.EventHandler(this.SupplierGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextItemUpdateSuppliers;
        private System.Windows.Forms.ToolStripMenuItem contextItemDeleteSuppliers;
    }
}