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
using Dapper;
using Northwind.Entities;

namespace Northwind.Presentation
{
    public partial class SupplierGridForm : Form
    {
        public SupplierGridForm()
        {
            InitializeComponent();
        }


        private void SupplierGridForm_Load(object sender, EventArgs e)
        {
            FillSuppliersGrid();
        }

        private void FillSuppliersGrid()
        {
            var repository = new SupplierRepository();

            try
            {
                var supplier = repository.GetAllSuppliers();
                dataGridViewSuppliers.DataSource = supplier;
            }
            catch (Exception)
            {

                MessageBox.Show("Kayitlari getirirken bir hata olustu.");
            }
        }

        private void dataGridViewSuppliers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    this.dataGridViewSuppliers.ClearSelection();
                    this.dataGridViewSuppliers.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void contextItemDeleteSuppliers_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Bu kaydi silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var supplier = (Supplier)dataGridViewSuppliers.SelectedRows[0].DataBoundItem;

                    try
                    {
                        var repository = new SupplierRepository();
                        repository.Remove(supplier);
                        MessageBox.Show("Satır başarıyla silindi.");
                        FillSuppliersGrid();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Silme sırasında bir hata meydana geldi \n\r" + ex.Message);
                    }


                }

            }
        }

        private void contextItemUpdateSuppliers_Click(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewSuppliers.SelectedRows[0];
                var idCell = selectedRow.Cells["SupplierID"];
                var supplierID = (int)idCell.Value;

                var updateForm = new SupplierCreateForm(supplierID);
                updateForm.FormClosed += UpdateForm_FormClosed;
                updateForm.Show();
            }
        }

        private void UpdateForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FillSuppliersGrid();
        }
    }
}
