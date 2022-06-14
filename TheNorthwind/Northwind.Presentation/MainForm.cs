using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuItemNewCategory_Click(object sender, EventArgs e)
        {
            var categoryCreateForm = new CategoryCreateForm();
            categoryCreateForm.Owner = this;
            categoryCreateForm.Show();
        }

        private void menuItemAllCategories_Click(object sender, EventArgs e)
        {
            var categoryGridForm = new CategoryGridForm();
            categoryGridForm.Owner = this;
            categoryGridForm.Show();
        }

        private void menuItemNewProduct_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreateForm();
            productCreateForm.Owner = this;
            productCreateForm.Show();
        }

        private void menuItemAllProducts_Click(object sender, EventArgs e)
        {
            var productGridForm = new ProductGridForm();
            productGridForm.Owner = this;
            productGridForm.Show();
        }

        private void menuItemNewSupplier_Click(object sender, EventArgs e)
        {
            var supplierCreateForm = new SupplierCreateForm();
            supplierCreateForm.Owner = this;
            supplierCreateForm.Show();

        }

        private void menuItemAllSuppliers_Click(object sender, EventArgs e)
        {
            var supplierGridForm = new SupplierGridForm();
            supplierGridForm.Owner = this;
            supplierGridForm.Show();
        }

        private void menuItemAllCustomers_Click(object sender, EventArgs e)
        {
            var customerGridForm = new CustomerGridForm();
            customerGridForm.Owner = this;
            customerGridForm.Show();
        }

        private void menuItemNewCustomer_Click(object sender, EventArgs e)
        {
            var customerCreateForm = new CustomerCreateForm();
            customerCreateForm.Owner = this;
            customerCreateForm.Show();
        }

        private void menuItemNewEmployee_Click(object sender, EventArgs e)
        {
            var employeeCreateForm = new EmployeeCreateForm();
            employeeCreateForm.Owner = this;
            employeeCreateForm.Show();
        }

        private void menuItemAllEmployee_Click(object sender, EventArgs e)
        {
            var employeeGridForm= new EmployeeGridForm();
            employeeGridForm.Owner = this;
            employeeGridForm.Show();

        }

        private void menuItemNewOrder_Click(object sender, EventArgs e)
        {
            var orderCreateForm = new OrderEditForm();
            orderCreateForm.Owner = this;
            orderCreateForm.Show();
        }

        private void menuItemAllOrders_Click(object sender, EventArgs e)
        {
            var orderGridForm = new OrderGridForm();
            orderGridForm.Owner = this;
            orderGridForm.Show();
        }
    }
}
