
namespace Northwind.Presentation
{
    partial class CategoryGridForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextItemUpdateCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.contextItemDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCatID,
            this.colCatName,
            this.colCatDescription});
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(971, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // colCatID
            // 
            this.colCatID.DataPropertyName = "CategoryID";
            this.colCatID.HeaderText = "Category ID";
            this.colCatID.Name = "colCatID";
            this.colCatID.ReadOnly = true;
            this.colCatID.Width = 87;
            // 
            // colCatName
            // 
            this.colCatName.DataPropertyName = "CategoryName";
            this.colCatName.HeaderText = "Category Name";
            this.colCatName.Name = "colCatName";
            this.colCatName.ReadOnly = true;
            this.colCatName.Width = 106;
            // 
            // colCatDescription
            // 
            this.colCatDescription.DataPropertyName = "Description";
            this.colCatDescription.HeaderText = "Category Description";
            this.colCatDescription.Name = "colCatDescription";
            this.colCatDescription.ReadOnly = true;
            this.colCatDescription.Width = 131;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextItemUpdateCategory,
            this.contextItemDeleteCategory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // contextItemUpdateCategory
            // 
            this.contextItemUpdateCategory.Name = "contextItemUpdateCategory";
            this.contextItemUpdateCategory.Size = new System.Drawing.Size(120, 22);
            this.contextItemUpdateCategory.Text = "Güncelle";
            this.contextItemUpdateCategory.Click += new System.EventHandler(this.contextItemUpdateCategory_Click);
            // 
            // contextItemDeleteCategory
            // 
            this.contextItemDeleteCategory.Name = "contextItemDeleteCategory";
            this.contextItemDeleteCategory.Size = new System.Drawing.Size(120, 22);
            this.contextItemDeleteCategory.Text = "Sil";
            this.contextItemDeleteCategory.Click += new System.EventHandler(this.contextItemDeleteCategory_Click);
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "colCatID";
            this.CategoryID.HeaderText = "Category ID";
            this.CategoryID.Name = "CategoryID";
            // 
            // CategoryGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 300);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CategoryGridForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextItemUpdateCategory;
        private System.Windows.Forms.ToolStripMenuItem contextItemDeleteCategory;
    }
}

