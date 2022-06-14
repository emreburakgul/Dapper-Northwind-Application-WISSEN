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
    public partial class SupplierCreateForm : Form
    {

        private int _supplierID;

        public SupplierCreateForm()
        {
            InitializeComponent();
        }

        public SupplierCreateForm(int supplierID)
        {
            InitializeComponent();
            _supplierID = supplierID;

            var repository = new SupplierRepository();
            
            var supplier = repository.Find(_supplierID);

            if (supplier != null)
            {
                txtCompanyName.Text = supplier.CompanyName;
                txtSupplierID.Text = supplier.SupplierID.ToString();
                txtAddress.Text = supplier.Address;
                txtCity.Text = supplier.City;
                txtContactName.Text = supplier.ContactName;
                txtContactTitle.Text = supplier.ContactTitle;
                txtCountry.Text = supplier.Country;
                txtFax.Text = supplier.Fax;
                txtHomePage.Text = supplier.HomePage;
                txtPhone.Text = supplier.Phone;
                txtPostalCode.Text = supplier.PostalCode;
                txtRegion.Text = supplier.Region;
            }
            else
            {
                MessageBox.Show("Güncellenmek istenen kayıt mevcut değil!");
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_supplierID != 0)
            {
                
                var supplier = GetInputs();
                var repository = new SupplierRepository();
                try
                {
                    repository.Update(supplier);
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
                var supplier = GetInputs();
                var repository = new SupplierRepository();

                try
                {
                    repository.Add(supplier);
                    MessageBox.Show("Kaydedildi.");
                    Form.ActiveForm.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydetme sırasında bir hata meydana geldi \n\r" + ex.Message);
                }
            }
        }

        private Supplier GetInputs()
        {
            var supplier = new Supplier();

            supplier.SupplierID = _supplierID;
            supplier.CompanyName = txtCompanyName.Text.Trim();
            supplier.ContactName = txtContactName.Text.Trim();
            supplier.ContactTitle = txtContactTitle.Text.Trim();
            supplier.Address = txtAddress.Text.Trim();
            supplier.City = txtCity.Text.Trim();
            supplier.Region = txtRegion.Text.Trim();
            supplier.PostalCode = txtPostalCode.Text.Trim();
            supplier.Country = txtCountry.Text.Trim();
            supplier.Phone = txtPhone.Text.Trim();
            supplier.Fax = txtFax.Text.Trim();
            supplier.HomePage = txtHomePage.Text.Trim();

            return supplier;

        }
    }
}
