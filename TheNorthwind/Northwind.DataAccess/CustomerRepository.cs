using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;
using Dapper;

namespace Northwind.DataAccess
{
    public class CustomerRepository
    {
        public IEnumerable<Customer> GetAll()
        {
            var customer = Enumerable.Empty<Customer>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Customer>("SELECT * FROM Customers");

            }
        }

        

        public void Update(Customer customer)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = @"
UPDATE Customers SET
CompanyName = @CompanyName,
ContactName = @ContactName,
ContactTitle = @ContactTitle,
Address = @Address,
City = @City,
Region = @Region,
PostalCode = @PostalCode,
Country = @Country,
Phone = @Phone,
Fax = @Fax
WHERE CustomerID = @CustomerID";
                connection.Execute(sqlText, customer);

            }
        }
        public void Add(Customer customer)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = @"
INSERT INTO [dbo].[Customers]
           ([CustomerID]
           ,[CompanyName]
           ,[ContactName]
           ,[ContactTitle]
           ,[Address]
           ,[City]
           ,[Region]
           ,[PostalCode]
           ,[Country]
           ,[Phone]
           ,[Fax])
     VALUES
           (@CustomerID,
           @CompanyName,
           @ContactName,
           @ContactTitle,
           @Address,
           @City,
           @Region,
           @PostalCode,
           @Country,
           @Phone,
           @Fax)";

                connection.Execute(sqlText, customer);
            }
        }

        public void Remove(Customer customer)
        {
            Remove(customer.CustomerID);
        }

        public void Remove(string customerID)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = "delete from Customers where CustomerID = @CustomerID";

                connection.Execute(sqlText, new { customerID = customerID });
            }
        }

        public Customer Find(string customerID)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = "select * from Customers where CustomerID = @CustomerID";

                var customer = connection.QuerySingleOrDefault<Customer>(sqlText, new { customerID = customerID });
                return customer;
            }
        }
    }


}
