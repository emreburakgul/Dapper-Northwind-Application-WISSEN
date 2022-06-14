using Northwind.Entities;
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
using Northwind.DataAccess;

namespace Northwind.Presentation
{
    public partial class CategoryCreateForm : Form
    {
        private int _categoryID;

        public CategoryCreateForm() // create new row
        {
            InitializeComponent();
            lblCategoryID.Text = string.Empty;
            lblCategoryName.Text = string.Empty;
            lblDescription.Text = string.Empty;
            lblSelectedCategory.Text = string.Empty;
            lblSelectedCatID.Text = string.Empty;
            lblSelectedDescription.Text = string.Empty;
        }

        public CategoryCreateForm(int categoryID) // update formu constructor
        {
            InitializeComponent();
            _categoryID = categoryID;

            var repository = new CategoryRepository();

            var category = repository.Find(_categoryID);

            if (category != null)
            {
                lblCategoryID.Text = categoryID.ToString();
                lblCategoryName.Text = category.CategoryName;
                lblDescription.Text = category.Description;
            }
        }

        private void btnCreateCat_Click(object sender, EventArgs e)
        {

            
            if (_categoryID != 0)
            {
                var category = new Category()
                {
                    CategoryName = txtCategoryName.Text.Trim(),
                    Description = txtCatDescription.Text.Trim(),
                    CategoryID = _categoryID,
                };
                var repository = new CategoryRepository();
                try
                {
                    repository.Update(category);
                    MessageBox.Show("Başarıyla güncellendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata meydana geldi \n\r - {ex.Message}");
                }
            }

            else // yeni row girme
            {
                var category = new Category()
                {
                    CategoryName = txtCategoryName.Text.Trim(),
                    Description = txtCatDescription.Text.Trim()
                };

                var repository = new CategoryRepository();
                try
                {
                    repository.Add(category);
                    MessageBox.Show("Başarıyla güncellendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata meydana geldi \n\r - {ex.Message}");
                }
                
            }

        }
    }
}