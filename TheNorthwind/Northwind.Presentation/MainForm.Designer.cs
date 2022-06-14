
namespace Northwind.Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem,
            this.tedarikçiYönetimiToolStripMenuItem,
            this.müşteriYönetimiToolStripMenuItem,
            this.çalışanYönetimiToolStripMenuItem,
            this.siparişYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewCategory,
            this.menuItemAllCategories});
            this.kategoriYönetimiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // menuItemNewCategory
            // 
            this.menuItemNewCategory.Name = "menuItemNewCategory";
            this.menuItemNewCategory.Size = new System.Drawing.Size(158, 22);
            this.menuItemNewCategory.Text = "Yeni Kategori";
            this.menuItemNewCategory.Click += new System.EventHandler(this.menuItemNewCategory_Click);
            // 
            // menuItemAllCategories
            // 
            this.menuItemAllCategories.Name = "menuItemAllCategories";
            this.menuItemAllCategories.Size = new System.Drawing.Size(158, 22);
            this.menuItemAllCategories.Text = "Tüm Kategoriler";
            this.menuItemAllCategories.Click += new System.EventHandler(this.menuItemAllCategories_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewProduct,
            this.menuItemAllProducts});
            this.ürünYönetimiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuItemNewProduct
            // 
            this.menuItemNewProduct.Name = "menuItemNewProduct";
            this.menuItemNewProduct.Size = new System.Drawing.Size(140, 22);
            this.menuItemNewProduct.Text = "Yeni Ürün";
            this.menuItemNewProduct.Click += new System.EventHandler(this.menuItemNewProduct_Click);
            // 
            // menuItemAllProducts
            // 
            this.menuItemAllProducts.Name = "menuItemAllProducts";
            this.menuItemAllProducts.Size = new System.Drawing.Size(140, 22);
            this.menuItemAllProducts.Text = "Tüm Ürünler";
            this.menuItemAllProducts.Click += new System.EventHandler(this.menuItemAllProducts_Click);
            // 
            // tedarikçiYönetimiToolStripMenuItem
            // 
            this.tedarikçiYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewSupplier,
            this.menuItemAllSuppliers});
            this.tedarikçiYönetimiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tedarikçiYönetimiToolStripMenuItem.Name = "tedarikçiYönetimiToolStripMenuItem";
            this.tedarikçiYönetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.tedarikçiYönetimiToolStripMenuItem.Text = "Tedarikçi yönetimi";
            // 
            // menuItemNewSupplier
            // 
            this.menuItemNewSupplier.Name = "menuItemNewSupplier";
            this.menuItemNewSupplier.Size = new System.Drawing.Size(161, 22);
            this.menuItemNewSupplier.Text = "Yeni Tedarikçi";
            this.menuItemNewSupplier.Click += new System.EventHandler(this.menuItemNewSupplier_Click);
            // 
            // menuItemAllSuppliers
            // 
            this.menuItemAllSuppliers.Name = "menuItemAllSuppliers";
            this.menuItemAllSuppliers.Size = new System.Drawing.Size(161, 22);
            this.menuItemAllSuppliers.Text = "Tüm Tedarikçiler";
            this.menuItemAllSuppliers.Click += new System.EventHandler(this.menuItemAllSuppliers_Click);
            // 
            // müşteriYönetimiToolStripMenuItem
            // 
            this.müşteriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewCustomer,
            this.menuItemAllCustomers});
            this.müşteriYönetimiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.müşteriYönetimiToolStripMenuItem.Name = "müşteriYönetimiToolStripMenuItem";
            this.müşteriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.müşteriYönetimiToolStripMenuItem.Text = "Müşteri Yönetimi";
            // 
            // menuItemNewCustomer
            // 
            this.menuItemNewCustomer.Name = "menuItemNewCustomer";
            this.menuItemNewCustomer.Size = new System.Drawing.Size(154, 22);
            this.menuItemNewCustomer.Text = "Yeni Müşteri";
            this.menuItemNewCustomer.Click += new System.EventHandler(this.menuItemNewCustomer_Click);
            // 
            // menuItemAllCustomers
            // 
            this.menuItemAllCustomers.Name = "menuItemAllCustomers";
            this.menuItemAllCustomers.Size = new System.Drawing.Size(154, 22);
            this.menuItemAllCustomers.Text = "Tüm Müşteriler";
            this.menuItemAllCustomers.Click += new System.EventHandler(this.menuItemAllCustomers_Click);
            // 
            // çalışanYönetimiToolStripMenuItem
            // 
            this.çalışanYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewEmployee,
            this.menuItemAllEmployee});
            this.çalışanYönetimiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.çalışanYönetimiToolStripMenuItem.Name = "çalışanYönetimiToolStripMenuItem";
            this.çalışanYönetimiToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.çalışanYönetimiToolStripMenuItem.Text = "Çalışan Yönetimi";
            // 
            // menuItemNewEmployee
            // 
            this.menuItemNewEmployee.Name = "menuItemNewEmployee";
            this.menuItemNewEmployee.Size = new System.Drawing.Size(159, 22);
            this.menuItemNewEmployee.Text = "Yeni Çalışan";
            this.menuItemNewEmployee.Click += new System.EventHandler(this.menuItemNewEmployee_Click);
            // 
            // menuItemAllEmployee
            // 
            this.menuItemAllEmployee.Name = "menuItemAllEmployee";
            this.menuItemAllEmployee.Size = new System.Drawing.Size(159, 22);
            this.menuItemAllEmployee.Text = "Bütün Çalışanlar";
            this.menuItemAllEmployee.Click += new System.EventHandler(this.menuItemAllEmployee_Click);
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewOrder,
            this.menuItemAllOrders});
            this.siparişYönetimiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // menuItemNewOrder
            // 
            this.menuItemNewOrder.Name = "menuItemNewOrder";
            this.menuItemNewOrder.Size = new System.Drawing.Size(149, 22);
            this.menuItemNewOrder.Text = "Yeni Sipariş";
            this.menuItemNewOrder.Click += new System.EventHandler(this.menuItemNewOrder_Click);
            // 
            // menuItemAllOrders
            // 
            this.menuItemAllOrders.Name = "menuItemAllOrders";
            this.menuItemAllOrders.Size = new System.Drawing.Size(149, 22);
            this.menuItemAllOrders.Text = "Tüm Siparişler";
            this.menuItemAllOrders.Click += new System.EventHandler(this.menuItemAllOrders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 562);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewCategory;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllCategories;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewProduct;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllProducts;
        private System.Windows.Forms.ToolStripMenuItem tedarikçiYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewSupplier;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllSuppliers;
        private System.Windows.Forms.ToolStripMenuItem müşteriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewCustomer;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem çalışanYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllEmployee;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewOrder;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllOrders;
    }
}