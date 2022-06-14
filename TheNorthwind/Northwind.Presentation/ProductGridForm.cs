using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Northwind.DataAccess;
using Northwind.Entities;

namespace Northwind.Presentation
{
    public partial class ProductGridForm : Form
    {
        public ProductGridForm()
        {
            InitializeComponent();
        }

        private void ProductGridForm_Load(object sender, EventArgs e)
        {
            FillProductsGrid();
        }



        private void dataGridViewProduct_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    this.dataGridViewProduct.ClearSelection();
                    this.dataGridViewProduct.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void contextItemUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewProduct.SelectedRows[0];
                var idCell = selectedRow.Cells["ProductID"];
                var productID = (int)idCell.Value;

                var updateForm = new ProductCreateForm(productID);
                updateForm.FormClosed += UpdateForm_FormClosed;
                updateForm.Show();
            }
        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillProductsGrid();
        }

        private void contextItemDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {

                var dialogResult = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    var product = (Product)dataGridViewProduct.SelectedRows[0].DataBoundItem;

                    try
                    {
                        var repository = new ProductRepository();
                        repository.Remove(product);

                        MessageBox.Show("Satır başarıyla silindi.");
                        FillProductsGrid();
                    }
                    catch (Exception ex)
                    {
                        
                    }
                    
                }
            }
        }

        private void FillProductsGrid()
        {
            var repository = new ProductRepository();

            try
            {
                var product = repository.GetAllProducts();
                dataGridViewProduct.DataSource = product;
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıtlar getirilemedi. Bir hata oluştu.");
            }
        }

    private void ProductGridForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        FillProductsGrid();
    }


}
}
