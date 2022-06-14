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
    public partial class OrderGridForm : Form
    {
        public OrderGridForm()
        {
            InitializeComponent();
        }

        private void OrderGridForm_Load(object sender, EventArgs e)
        {
            FillOrderGrid();
        }

        private void FillOrderGrid()
        {
            var repository = new OrderRepository();
            try
            {
                var orders = repository.GetAllOrders();
                dataGridOrder.DataSource = orders;
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıtlar getirilemedi.");
            }
        }

        private void dataGridOrder_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right &&
                e.RowIndex > -1)
            {
                dataGridOrder.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuItemUpdateOrder_Click(object sender, EventArgs e)
        {
            if (dataGridOrder.SelectedRows.Count > 0)
            {
                // Bind etmek => Bir değeri/nesneyi bir arayüz kontrolüne bağlamak
                // Bound

                // as keywordü de cast etme işlemidir
                // Değerin başına (Order) yazarak cast etmek ile as Order cast etme farkı;
                // Explicit cast işleminde eğer cast ettiğniz değer gerçekten o tipte (Order tipinde)
                // değilse Exception fırlatır
                // as keyword'ü ile cast ettiğinizde Exception fırlatmaz, null değer döndürür
                // as keyword'ü yalnızca referans tipli nesneler için kullanılır
                var order = dataGridOrder.SelectedRows[0].DataBoundItem as Order;
                if (order != null)
                {
                    var updateForm = new OrderEditForm(order.OrderID);
                    updateForm.Show();
                }

                //if (dataGridOrder.SelectedRows[0].DataBoundItem is Order)
                //{
                //    var order = (Order)dataGridOrder.SelectedRows[0].DataBoundItem;
                //}
            }
        }

        private void menuItemDeleteOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
