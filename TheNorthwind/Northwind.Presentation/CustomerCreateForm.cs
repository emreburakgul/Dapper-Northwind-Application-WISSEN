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
    public partial class CustomerCreateForm : Form
    {
        private string _customerID;

        public CustomerCreateForm()
        {
            InitializeComponent();
        }

        public CustomerCreateForm(string customerID)
        {
            InitializeComponent();
            _customerID = customerID;

            var repository = new CustomerRepository();
            var customer = repository.Find(_customerID);

            if (customer != null)
            {
                txtCustomerID.Text = customer.CustomerID;
                txtCustomerCompanyName.Text = customer.CompanyName;
                txtContactName.Text = customer.ContactName;
                txtContactTitle.Text = customer.ContactTitle;
                txtAddress.Text = customer.Address;
                txtCity.Text= customer.City;
                txtRegion.Text = customer.Region;
                txtPostalCode.Text = customer.PostalCode;
                txtCountry.Text = customer.Country;
                txtPhone.Text = customer.Phone;
                txtFax.Text = customer.Fax;
            }
            else
            {
                MessageBox.Show("Güncellenmek istenen kayıt mevcut değil!");
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_customerID != null)
            {
                var customer = GetCustomerInputs();
                var repository = new CustomerRepository();
                try
                {
                    repository.Update(customer);
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
                var customer = GetCustomerInputs();
                var repository = new CustomerRepository();
                try
                {
                    repository.Add(customer);
                    MessageBox.Show("Kaydedildi.");
                    Form.ActiveForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kaydetme sırasında bir hata meydana geldi \n\r" + ex.Message);
                }
            }
        }

        private Customer GetCustomerInputs()
        {
            var customer = new Customer()
            {
                CustomerID = txtCustomerID.Text.Trim(),
                CompanyName = txtCustomerCompanyName.Text.Trim(),
                ContactName = txtContactName.Text.Trim(),
                ContactTitle = txtContactTitle.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                Region = txtRegion.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Fax = txtFax.Text.Trim()
            };
            return customer;
        }
    }
}
