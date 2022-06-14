using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Northwind.DataAccess
{
    public class ProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            var product = Enumerable.Empty<Product>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Product>("select * from Products");
            }
        }


        public IEnumerable<Category> GetAllCategories()
        {
            var category = Enumerable.Empty<Category>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Category>("select * from Categories");
            }
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            var supplier = Enumerable.Empty<Supplier>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Supplier>("select * from Suppliers");
            }
        }

        public Product Find(int productID)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = "Select * from Products where ProductID = @productID";

                var product = connection.QuerySingleOrDefault<Product>(sqlText, new { productID = productID });
                return product;
            }
        }

        public void Update(Product product)
        {
            using (var connection = DBConnectionFactory.Create())
            {

                const string sqlText = @"
UPDATE Products SET 
ProductName = @ProductName,
SupplierID = @SupplierID,
CategoryID = @CategoryID,
QuantityPerUnit = @QuantityPerUnit,
UnitPrice =  @UnitPrice,
UnitsInStock = @UnitsInStock,
UnitsOnOrder = @UnitsOnOrder,
ReorderLevel = @ReorderLevel,
Discontinued = @Discontinued
WHERE ProductID = @ProductID";

                var affectedRows = connection.Execute(sqlText, product);

            }
        }

        public void Add(Product product)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = @"
INSERT INTO [dbo].[Products]

([ProductName],
[SupplierID],
[CategoryID],
[QuantityPerUnit],
[UnitPrice],
[UnitsInStock], 
[UnitsOnOrder],
[ReorderLevel],
[Discontinued])

values (
@ProductName, 
@SupplierID, 
@CategoryID, 
@QuantityPerUnit, 
@UnitPrice,
@UnitsInStock, 
@UnitsOnOrder, 
@ReorderLevel, 
@Discontinued)";

                connection.Execute(sqlText, product);
            }
        }


        public void Remove(Product product)
        {
            Remove(product.ProductID);
        }

        public void Remove(int productID)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = "DELETE FROM Products WHERE ProductID = @productID";

                connection.Execute(sqlText, new { productID = productID });
            }
        }
    }
}
