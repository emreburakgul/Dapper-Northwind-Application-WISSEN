using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Northwind.Entities;

namespace Northwind.DataAccess
{
    public class OrderRepository
    {
        public IEnumerable<Order> GetAllOrders()
        {
            var order = Enumerable.Empty<Order>();
            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Order>("Select * from Orders");
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            var customer = Enumerable.Empty<Customer>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Customer>("select * from Customers");
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var employee = Enumerable.Empty<Employee>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Employee>("select * from Employees");
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var product = Enumerable.Empty<Product>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Product>("select * from Products");
            }
        }

        public IEnumerable<Shipper> GetAllShippers()
        {
            var shipper = Enumerable.Empty<Shipper>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Shipper>("select * from Shippers");
            }
        }

        public Order Find(int orderId)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string orderSqlText = "select * from [Orders] where OrderID = @orderId";
                const string detailSqlText = @"
select
    od.*,
    NULL as Seperator,
    p.*
from 
[Order Details]  od
inner join Products p on od.ProductID = p.ProductID
where OrderID = @orderId";

                var parameters = new { orderId = orderId };
                var order = connection.QuerySingleOrDefault<Order>(
                    orderSqlText,
                    parameters);

                if (order != null)
                {
                    var orderDetails = connection.Query<OrderDetail, Product, OrderDetail>(
                        detailSqlText,
                        (detail, product) =>
                        {
                            detail.Product = product;
                            return detail;
                        },
                        // MapQueryResult,
                        parameters,
                        splitOn: "Seperator");

                    foreach (var detail in orderDetails)
                    {
                        order.OrderDetails.Add(detail);
                    }
                }

                return order;
            }
        }

        public void Add(Order order)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string orderInsertSql = @"
insert into Orders (CustomerID,
EmployeeID,
OrderDate,
RequiredDate,
ShippedDate,
ShipVia,
ShipName,
Freight,
ShipAddress,
ShipCity,
ShipRegion,
ShipPostalCode,
ShipCountry)
values (@CustomerID,
@EmployeeID,
@OrderDate,
@RequiredDate,
@ShippedDate,
@ShipVia,
@ShipName,
@Freight,
@ShipAddress,
@ShipCity,
@ShipRegion,
@ShipPostalCode,
@ShipCountry)

select @@IDENTITY;";

                // Execute and Get OrderID!

                order.OrderID = connection.ExecuteScalar<int>(orderInsertSql, order);


                const string orderDetailInsertSql = @"
insert into [Order Details]
(OrderID,
ProductID,
UnitPrice,
Quantity,
Discount)
values (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)";

                foreach (var orderDetail in order.OrderDetails)
                {
                    orderDetail.OrderID = order.OrderID;

                    connection.Execute(orderDetailInsertSql, orderDetail);
                }
            }
        }

        public void Remove(Order orderDetails)
        {
            throw new NotImplementedException();
        }

        private OrderDetail MapQueryResult(OrderDetail orderDetail, Product product)
        {
            orderDetail.Product = product;
            return orderDetail;
        }
    }
}
