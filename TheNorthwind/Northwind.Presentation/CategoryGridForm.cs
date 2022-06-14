using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Northwind.Entities;
using Northwind.DataAccess;

namespace Northwind.Presentation
{
    public partial class CategoryGridForm : Form
    {
        public CategoryGridForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCategoriesGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var selectedRow = dataGridView1.Rows[e.RowIndex];

            var idCell = selectedRow.Cells["colCatID"];
            var categoryId = (int)idCell.Value;


            var updateForm = new CategoryCreateForm(categoryId);
            updateForm.FormClosed += UpdateForm_FormClosed;

            updateForm.Show();


        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillCategoriesGrid();
        }

        private void FillCategoriesGrid()
        {
            var repository = new CategoryRepository();
            try
            {
                var categories = repository.GetAll();
                dataGridView1.DataSource = categories;
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıtlar getirilemedi.");
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int selectedRow = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dataGridView1.ClearSelection();
                    this.dataGridView1.Rows[selectedRow].Selected = true;
                }
            }
        }

        private void contextItemDeleteCategory_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //var selectedRow = dataGridView1.SelectedRows[0];
                    //var idCell = selectedRow.Cells["colCatID"];
                    //var categoryID = (int)idCell.Value;

                    var category = (Category)dataGridView1.SelectedRows[0].DataBoundItem;

                    try
                    {
                        var repository = new CategoryRepository();
                        repository.Remove(category);

                        MessageBox.Show("Satır başarıyla silindi.");
                        FillCategoriesGrid();

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

        private void contextItemUpdateCategory_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var idCell = selectedRow.Cells["colCatID"];
                var categoryID = (int)idCell.Value;

                var updateForm = new CategoryCreateForm(categoryID);
                updateForm.FormClosed += UpdateForm_FormClosed;
                updateForm.Show();
            }
        }
    }
}