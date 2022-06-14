using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.DataAccess;
using Northwind.Entities;

namespace Northwind.Presentation
{
    public partial class CustomerGridForm : Form
    {
        public CustomerGridForm()
        {
            InitializeComponent();
        }

        private void CustomerGridForm_Load(object sender, EventArgs e)
        {
            FillCustomerGrid();
        }

        private void FillCustomerGrid()
        {
            var repository = new CustomerRepository();
            try
            {
                var customers = repository.GetAll();
                dataGridViewCustomers.DataSource = customers;
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıtlar getirilemedi.");
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCustomers.SelectedRows[0];
                var idCell = selectedRow.Cells["CustomerID"];
                var customerID = (string)idCell.Value;

                var updateForm = new CustomerCreateForm(customerID);
                updateForm.FormClosed += UpdateForm_FormClosed;
                updateForm.Show();
            }
        }

        private void UpdateForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FillCustomerGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    var category = (Customer)dataGridViewCustomers.SelectedRows[0].DataBoundItem;

                    try
                    {
                        var repository = new CustomerRepository();
                        repository.Remove(category);

                        MessageBox.Show("Satır başarıyla silindi.");
                        FillCustomerGrid();

                        // eğer kullandığınız Repository sınıfı Remove methodu için yalnızca ID değerine göre silme
                        // işlemi yapan bir metot sunmuyorsa ve sizde sadece ID değeri varsa aşağıdaki teknikle o metot çağırılabilir.
                        // int categoryID = 10;
                        // repo.Remove(new Category() {CategoryID = categoryID});

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme sırasında bir hata meydana geldi \n\r" + ex.Message);
                    }


                }
            }
        }
    }
}
