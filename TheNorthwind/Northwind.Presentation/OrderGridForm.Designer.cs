namespace Northwind.Presentation
{
    partial class OrderGridForm
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
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemUpdateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteOrder = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridOrder.MultiSelect = false;
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.ReadOnly = true;
            this.dataGridOrder.RowHeadersWidth = 51;
            this.dataGridOrder.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridOrder.RowTemplate.Height = 25;
            this.dataGridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrder.Size = new System.Drawing.Size(800, 450);
            this.dataGridOrder.TabIndex = 0;
            this.dataGridOrder.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridOrder_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUpdateOrder,
            this.menuItemDeleteOrder});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // menuItemUpdateOrder
            // 
            this.menuItemUpdateOrder.Name = "menuItemUpdateOrder";
            this.menuItemUpdateOrder.Size = new System.Drawing.Size(180, 22);
            this.menuItemUpdateOrder.Text = "Update";
            this.menuItemUpdateOrder.Click += new System.EventHandler(this.menuItemUpdateOrder_Click);
            // 
            // menuItemDeleteOrder
            // 
            this.menuItemDeleteOrder.Name = "menuItemDeleteOrder";
            this.menuItemDeleteOrder.Size = new System.Drawing.Size(180, 22);
            this.menuItemDeleteOrder.Text = "Delete";
            this.menuItemDeleteOrder.Click += new System.EventHandler(this.menuItemDeleteOrder_Click);
            // 
            // OrderGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridOrder);
            this.Name = "OrderGridForm";
            this.Text = "OrderGridForm";
            this.Load += new System.EventHandler(this.OrderGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdateOrder;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteOrder;
    }
}