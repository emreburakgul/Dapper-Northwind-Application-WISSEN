using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Northwind.Entities;

namespace Northwind.DataAccess
{
    public class SupplierRepository
    {
        public IEnumerable<Supplier> GetAllSuppliers()
        {
            var supplier = Enumerable.Empty<Supplier>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Supplier>("SELECT * FROM Suppliers");
            }
        }

        public void Remove(Supplier supplier)
        {
            Remove(supplier.SupplierID);
        }

        public void Remove(int supplierID)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = "DELETE FROM Suppliers WHERE SupplierID = @supplierID";

                connection.Execute(sqlText, new { supplierID = supplierID });
            }
        }


        public Supplier Find(int supplierID)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = "Select * from Suppliers where SupplierID = @supplierID";

                var supplier = connection.QuerySingleOrDefault<Supplier>(sqlText, new { supplierID = supplierID });
                return supplier;
            }
        }

        public void Update(Supplier supplier)
        {
            using (var connection = DBConnectionFactory.Create())
            {

                const string sqlText = @"
UPDATE Suppliers SET 
CompanyName = @CompanyName,
ContactName = @ContactName,
ContactTitle = @ContactTitle,
Address = @Address,
City =  @City,
Region = @Region,
Country = @Country,
Phone = @Phone,
Fax = @Fax,
HomePage = @HomePage
WHERE SupplierID = @SupplierID";
                connection.Execute(sqlText, supplier);

            }
        }


        public void Add(Supplier supplier)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = @"
INSERT INTO Suppliers
(CompanyName, ContactName, ContactTitle, Address, City, 
Region, PostalCode, Country, Phone, Fax, HomePage) 
values (@CompanyName, @ContactName, @ContactTitle, @Address, @City,
@Region, @PostalCode, @Country, @Phone, @Fax, @HomePage)";

                connection.Execute(sqlText, supplier);
            }
        }
    }
}
