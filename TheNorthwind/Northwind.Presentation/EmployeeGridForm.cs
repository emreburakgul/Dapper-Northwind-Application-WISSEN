using Northwind.DataAccess;
using Northwind.Entities;
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
    public partial class EmployeeGridForm : Form
    {
        public EmployeeGridForm()
        {
            InitializeComponent();
        }

        private void contextMenuUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var idCell = selectedRow.Cells["EmployeeID"];
                var employeeID = (int)idCell.Value;

                var updateForm = new EmployeeCreateForm(employeeID);
                updateForm.FormClosed += UpdateForm_FormClosed;
                updateForm.Show();
            }
        }

        private void UpdateForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FillEmployeeGrid();
        }

        private void contextMenuDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var employee = (Employee)dataGridView1.SelectedRows[0].DataBoundItem;

                    try
                    {
                        var repository = new EmployeeRepository();
                        repository.Remove(employee);

                        MessageBox.Show("Satır başarıyla silindi.");
                        FillEmployeeGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme sırasında bir hata meydana geldi \n\r" + ex.Message);
                    }
                }
            }
        }

        private void EmployeeGridForm_Load(object sender, EventArgs e)
        {
            FillEmployeeGrid();
        }

        private void FillEmployeeGrid()
        {
            var repository = new EmployeeRepository();
            try
            {
                var employee = repository.GetAll();
                dataGridView1.DataSource = employee;
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıtlar getirilemedi.");
            }
        }
    }
}
