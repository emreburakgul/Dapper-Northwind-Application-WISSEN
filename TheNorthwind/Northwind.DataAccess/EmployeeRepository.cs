using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Northwind.Entities;

namespace Northwind.DataAccess
{
    public class EmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            var employee = Enumerable.Empty<Employee>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Employee>("Select * From Employees");
            }
        }

        public void Update(Employee employee)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = @"
UPDATE dbo.Employees
   SET LastName = @LastName,
      FirstName = @FirstName,
      Title = @Title,
      TitleOfCourtesy = @TitleOfCourtesy,
      BirthDate = @BirthDate,
      HireDate = @HireDate,
      Address = @Address,
      City = @City,
      Region = @Region,
      PostalCode = @PostalCode,
      Country = @Country,
      HomePhone = @HomePhone,
      Extension = @Extension,
      Notes = @Notes,
      ReportsTo = @ReportsTo
 WHERE EmployeeID = @EmployeeID
";
                connection.Execute(sqlText, employee);
            }
        }

        public void Add(Employee employee)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = @"INSERT INTO dbo.Employees
           (LastName
           ,FirstName
           ,Title
           ,TitleOfCourtesy
           ,BirthDate
           ,HireDate
           ,Address
           ,City
           ,Region
           ,PostalCode
           ,Country
           ,HomePhone
           ,Extension
           ,Photo
           ,Notes
           ,ReportsTo
           ,PhotoPath)
     VALUES
           @LastName,
           @FirstName,
           @Title,
           @TitleOfCourtesy,
           @BirthDate,
           @HireDate,
           @Address,
           @City,
           @Region,
           @PostalCode,
           @Country,
           @HomePhone,
           @Extension,
           @Notes,
           @ReportsTo)
";
                connection.Execute(sqlText, employee);
            }
        }

        public void Remove(Employee employee)
        {
            Remove(employee.EmployeeID);
        }

        public void Remove(int employeeID)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = "DELETE from Employees where EmployeeID = @employeeID";
                connection.Execute(sqlText, new { employeeID = employeeID });
            }
        }

        public Employee Find(int employeeID)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = "SELECT * from Employees WHERE EmployeeID = @employeeID";
                var employee = connection.QuerySingleOrDefault<Employee>(sqlText, new { employeeID = employeeID });
                return employee;
            }
        }
    }
}
