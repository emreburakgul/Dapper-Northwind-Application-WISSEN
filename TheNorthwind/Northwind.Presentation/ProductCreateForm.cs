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
    public partial class ProductCreateForm : Form
    {
        private int _productID;

        public ProductCreateForm()
        {
            InitializeComponent();
            lblProductID.Text = String.Empty;
            lblProductIDShow.Text = String.Empty;
        }

        public ProductCreateForm(int productID)
        {
            InitializeComponent();
            _productID = productID;

            var repository = new ProductRepository();
            var product = repository.Find(_productID);

            if (product != null)
            {
                lblProductID.Text = product.ProductID.ToString();
                txtProductName.Text = product.ProductName;
                txtQuantityPerUnit.Text = product.QuantityPerUnit.ToString();   
                txtUnitsOnOrder.Text = product.UnitsOnOrder.ToString(); 
                txtUnitsInStock.Text = product.UnitsInStock.ToString();
                txtReorderLevel.Text = product.ReorderLevel.ToString();
                chkDiscontinued.Checked = product.Discontinued;
                numUnitPrice.Value = (decimal)product.UnitPrice;
            }
            else
            {
                MessageBox.Show("Güncellenmek istenen kayıt mevcut değil!");
                Close();
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_productID != 0)  // UPDATE // 
            {
                
                var product = GetProductFromInputs();
                var repository = new ProductRepository();

                try
                {
                    repository.Update(product);
                    MessageBox.Show("Kaydedildi.");
                    Form.ActiveForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydetme sırasında bir hata meydana geldi \n\r" + ex.Message);
                }
            }
            else
            {
               
                var product =  GetProductFromInputs();
                var repository = new ProductRepository();
                try
                {
                    
                    repository.Add(product);
                    MessageBox.Show("Kaydedildi.");
                    Form.ActiveForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydetme sırasında bir hata meydana geldi \n\r" + ex.Message);
                }
            }

        }

        private Product GetProductFromInputs()
        {
            var product = new Product()
            {
                ProductID = _productID,
                ProductName = txtProductName.Text.Trim(),
                SupplierID = cmbSupplier.SelectedItem != null
                ? (int)cmbSupplier.SelectedValue
                : default,
                CategoryID = cmbCategory.SelectedItem != null
                ? (int)cmbCategory.SelectedValue
                : default,
                QuantityPerUnit = txtQuantityPerUnit.Text.Trim(),
                UnitPrice = numUnitPrice.Value != 0 ? numUnitPrice.Value : default(decimal?),
                UnitsInStock = !string.IsNullOrWhiteSpace(txtUnitsInStock.Text)
                ? short.Parse(txtUnitsInStock.Text)
                : default(short?),
                UnitsOnOrder = !string.IsNullOrWhiteSpace(txtUnitsOnOrder.Text)
                ? short.Parse(txtUnitsOnOrder.Text)
                : default(short?),
                ReorderLevel = !string.IsNullOrWhiteSpace(txtReorderLevel.Text)
                ? short.Parse(txtReorderLevel.Text)
                : default(short?),
                Discontinued = chkDiscontinued.Checked,
            };
            return product;
        }


        private void FillCategoriesComboBox()
        {
            var repository = new ProductRepository();

            try
            {
                var categories = repository.GetAllCategories();
                cmbCategory.ValueMember = "CategoryID";
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.DataSource = categories;
            }
            catch (Exception)
            {
                MessageBox.Show("Kategori kayıtları getirilemedi.");
            }
        }


        private void FillSupplierComboBox()
        {
            var repository = new ProductRepository();
            try
            {
                var supplier = repository.GetAllSuppliers();
                cmbSupplier.ValueMember = "SupplierID";
                cmbSupplier.DisplayMember = "CompanyName";
                cmbSupplier.DataSource = supplier;
            }
            catch (Exception)
            {

                MessageBox.Show("Tedarikçi kayıtları getirilemedi.");
            }


            

            
        }

        private void ProductCreateForm_Load(object sender, EventArgs e)
        {

            FillSupplierComboBox();
            FillCategoriesComboBox();
        }
    }
}

