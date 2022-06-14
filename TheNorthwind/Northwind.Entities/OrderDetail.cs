using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public Product Product { get; set; }
        public int ProductID
        {
            get
            {
                return Product != null 
                    ? Product.ProductID 
                    : default;
            }
        }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public decimal TotalPrice
        {
            get { return UnitPrice * Quantity * (1 - (decimal)Discount); }
        }
    }
}


