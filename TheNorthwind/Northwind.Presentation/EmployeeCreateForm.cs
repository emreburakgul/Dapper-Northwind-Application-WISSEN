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
    public partial class EmployeeCreateForm : Form
    {
        private int _employeeID;
        
        public EmployeeCreateForm()
        {
            InitializeComponent();
            FillReportsToCmb();
        }

        public EmployeeCreateForm(int employeeID)
        {
            InitializeComponent();
            _employeeID = employeeID;

            var repository = new EmployeeRepository();
            var employee = repository.Find(_employeeID);
            FillReportsToCmb();

            if (employee != null)
            {
                txtEmployeeID.Text = employee.EmployeeID.ToString();
                txtLastName.Text = employee.LastName.ToString();
                txtFirstName.Text = employee.FirstName.ToString();
                txtTitle.Text = employee.Title.ToString();
                txtTitleOfCourtesy.Text = employee.TitleOfCourtesy.ToString();
                dtpBirthDate.Value = employee.BirthDate.HasValue ? employee.BirthDate.Value : default;
                dtpHireDate.Value = employee.HireDate.HasValue ? employee.HireDate.Value : default;
                txtAddress.Text = employee.Address;
                txtCity.Text = employee.City;
                txtRegion.Text = employee.Region;
                txtPostalCode.Text = employee.PostalCode;
                txtCountry.Text = employee.Country;
                txtHomePhone.Text = employee.HomePhone;
                txtExtension.Text = employee.Extension;
                txtNotes.Text = employee.Notes;
                cmbReportsTo.SelectedValue = employee.ReportsTo.HasValue ? employee.ReportsTo.Value : default;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_employeeID != 0)
            {
                var employee = GetEmployeeFromInputs();
                var repository = new EmployeeRepository();
                try
                {
                    repository.Update(employee);
                    MessageBox.Show("Başarıyla güncellendi.");
                    Form.ActiveForm.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Bir hata meydana geldi \n\r - {ex.Message}");
                }
            }
            else
            {
                var employee = GetEmployeeFromInputs();
                var repository = new EmployeeRepository();
                try
                {
                    repository.Add(employee);
                    MessageBox.Show("Başarıyla güncellendi.");
                    Form.ActiveForm.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Bir hata meydana geldi \n\r - {ex.Message}");
                }
            }
        }

        private Employee GetEmployeeFromInputs()
        {
            var employee = new Employee()
            {
                EmployeeID = _employeeID,
                LastName = txtLastName.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                Title = txtTitle.Text.Trim(),
                TitleOfCourtesy = txtTitleOfCourtesy.Text.Trim(),
                BirthDate = dtpBirthDate.Value,
                HireDate = dtpHireDate.Value,
                Address = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                Region = txtRegion.Text.Trim(),
                PostalCode = txtPostalCode.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                HomePhone = txtHomePhone.Text.Trim(),
                Extension = txtExtension.Text.Trim(),
                Notes = txtNotes.Text.Trim(),
                ReportsTo = cmbReportsTo.SelectedValue != null 
                ? (int?)cmbReportsTo.SelectedValue 
                : default(int?)
                

             };

            return employee;
        }

        private void FillReportsToCmb()
        {
            var repository = new EmployeeRepository();
            var allEmployee = repository.GetAll();

            var managerList = new List<Employee>();
            foreach (var employee in allEmployee)
            {
                if (employee.EmployeeID != _employeeID)
                {
                    managerList.Add(employee);
                }
            }

            cmbReportsTo.ValueMember = "EmployeeID";
            cmbReportsTo.DisplayMember = "FirstName";
            cmbReportsTo.DataSource = managerList;

        }


    }
}
