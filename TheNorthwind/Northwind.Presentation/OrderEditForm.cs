using Northwind.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Entities;

namespace Northwind.Presentation
{
    public partial class OrderEditForm : Form
    {
        private readonly List<OrderDetail> _orderDetailInputs = new List<OrderDetail>();

        // readonly
        // Sınıftaki bir alanı (field) salt okunur yapmak için kullanabiliriz
        // readonly tanımlanmış field'ın değeri yalnızca ve yalnızca constructor metotta atanabilir
        // Başka bir noktada değeri değiştirilemez
        // Diğer bir ifadeyle; _orderId değeri initialize edildiği gibi kalacak, bir daha değişmeyecek
        private readonly int _orderId;

        public OrderEditForm()
        {
            InitializeComponent();
        }

        public OrderEditForm(int orderId)
        {
            InitializeComponent();

            _orderId = orderId;
        }

        private void OrderCreateForm_Load(object sender, EventArgs e)
        {
            FillCustomerComboBox();
            FillEmployeeComboBox();
            FillProductComboBox();
            FillShipperComboBox();
            SetupGrid();

            if (_orderId != default)
            {
                FillOrderFormInputs();
            }
        }

        private void FillOrderFormInputs()
        {
            try
            {
                var orderRepository = new OrderRepository();
                var order = orderRepository.Find(_orderId);

                if (order != null)
                {
                    cmbCustomerID.SelectedValue = !string.IsNullOrWhiteSpace(order.CustomerID)
                        ? order.CustomerID
                        : string.Empty;
                    cmbEmployeeID.SelectedValue = order.EmployeeID.HasValue
                        ? order.EmployeeID.Value
                        : string.Empty;

                    dtpOrderDate.Value = order.OrderDate;
                    dtpRequiredDate.Value = order.RequiredDate;
                    dtpShippedDate.Value = order.ShippedDate;
                    cmbShipperID.SelectedValue = order.ShipVia;
                    txtShipName.Text = order.ShipName;
                    txtFreight.Text = order.Freight.ToString();
                    txtShipAddress.Text = order.ShipAddress;
                    txtShipCity.Text = order.ShipCity;
                    txtShipRegion.Text = order.ShipRegion;
                    txtShipPostalCode.Text = order.ShipPostalCode;
                    txtShipCountry.Text = order.ShipCountry;

                    foreach (var detail in order.OrderDetails)
                    {
                        _orderDetailInputs.Add(detail);
                    }

                    RefreshGrid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sipariş bilgileri yüklenemedi");
            }
        }

        private void SetupGrid()
        {
            datagridOrderDetails.AutoGenerateColumns = false;
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (cmbProductID.SelectedItem != null &&
                short.TryParse(txtQuantity.Text.Trim(), out short quantity) &&
                quantity > 0)
            {
                float.TryParse(txtDiscount.Text.Trim(), out float discount);

                var orderDetail = new OrderDetail()
                {
                    Product = cmbProductID.SelectedItem != null
                        ? (Product)cmbProductID.SelectedItem
                        : default,
                    UnitPrice = numUnitPrice.Value,
                    Quantity = quantity,
                    Discount = discount >= 0 && discount <= 1
                        ? discount 
                        : default
                };

                // flag yöntemi
                bool productFound = false;
                foreach (var detailInput in _orderDetailInputs)
                {
                    if (detailInput.ProductID == orderDetail.ProductID)
                    {
                        detailInput.Quantity += orderDetail.Quantity;
                        productFound = true;
                        break;
                    }
                }

                if (!productFound)
                {
                    _orderDetailInputs.Add(orderDetail);
                }
                
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Lütfen ürünü ve adedi eksiksiz belirtin");
            }
        }

        private void RefreshGrid()
        {
            datagridOrderDetails.DataSource = null;
            datagridOrderDetails.DataSource = _orderDetailInputs;
        }

        private void FillCustomerComboBox()
        {
            var repository = new OrderRepository();

            try
            {
                var customer = repository.GetAllCustomers();
                cmbCustomerID.ValueMember = "CustomerID";
                cmbCustomerID.DisplayMember = "CompanyName";
                cmbCustomerID.DataSource = customer;
            }
            catch (Exception)
            {
                MessageBox.Show("Kategori kayıtları getirilemedi.");
            }
        }
        private void FillEmployeeComboBox()
        {
            var repository = new OrderRepository();
            try
            {
                var employee = repository.GetAllEmployees();
                cmbEmployeeID.ValueMember = "EmployeeID";
                cmbEmployeeID.DisplayMember = "FirstName";
                cmbEmployeeID.DataSource = employee;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FillShipperComboBox()
        {
            var repository = new OrderRepository();
            try
            {
                var shipper = repository.GetAllShippers();
                cmbShipperID.ValueMember = "ShipperID";
                cmbShipperID.DisplayMember = "CompanyName";
                cmbShipperID.DataSource = shipper;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FillProductComboBox()
        {
            var repository = new OrderRepository();
            try
            {
                var products = repository.GetAllProducts();
                cmbProductID.ValueMember = "ProductID";
                cmbProductID.DisplayMember = "ProductName";
                cmbProductID.DataSource = products;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var order = GetOrderFromInputs();
            var repository = new OrderRepository();
            try
            {
                repository.Add(order);
                MessageBox.Show("Kaydedildi.");
                Form.ActiveForm.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata meydana geldi \n\r" + ex.Message);
            }


        }

        private void ActiveForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            RefreshGrid();
        }

        private Order GetOrderFromInputs()
        {
            var order = new Order()
            {
                CustomerID = cmbCustomerID.SelectedItem != null
                ? (string)cmbCustomerID.SelectedValue
                : default,
                EmployeeID = cmbEmployeeID.SelectedItem != null
                ? (int)cmbEmployeeID.SelectedValue
                : default,
                OrderDate = dtpOrderDate.Value,
                RequiredDate = dtpRequiredDate.Value,
                ShippedDate = dtpShippedDate.Value,
                ShipVia = cmbShipperID.SelectedItem != null
                ? (int)cmbShipperID.SelectedValue
                : default,
                ShipName = txtShipName.Text.Trim(),
                Freight = !string.IsNullOrWhiteSpace(txtFreight.Text)
                ? decimal.Parse(txtFreight.Text)
                : default(decimal),
                ShipAddress = txtShipAddress.Text.Trim(),
                ShipCity = txtShipCity.Text.Trim(),
                ShipRegion = txtShipRegion.Text.Trim(),
                ShipPostalCode = txtShipPostalCode.Text.Trim(),
                ShipCountry = txtShipCountry.Text.Trim(),

            };

            foreach (var item in _orderDetailInputs)
            {
                order.OrderDetails.Add(item);
            }


            return order;


        }

        private void cmbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductID.SelectedItem != null)
            {
                var selectedProduct = (Product)cmbProductID.SelectedItem;
                numUnitPrice.Value = selectedProduct.UnitPrice.HasValue
                    ? selectedProduct.UnitPrice.Value
                    : default;
            }
            else
            {
                numUnitPrice.Value = default;
            }
        }

        private void datagridOrderDetails_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    this.datagridOrderDetails.ClearSelection();
                    this.datagridOrderDetails.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagridOrderDetails.SelectedRows.Count > 0)
            {
                var dialogResult = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var orderDetails =(OrderDetail)datagridOrderDetails.SelectedRows[0].DataBoundItem;
                    try
                    {
                        _orderDetailInputs.Remove(orderDetails);
                        RefreshGrid();
                        MessageBox.Show("Satır başarıyla silindi.");
  

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme sırasında bir hata meydana geldi \n\r" + ex.Message);
                    }


                }
            }
        }

        private void OrderEditForm_Click(object sender, EventArgs e)
        {
            
        }
    }
}