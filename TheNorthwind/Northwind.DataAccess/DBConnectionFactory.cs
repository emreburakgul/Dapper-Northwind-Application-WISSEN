using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Northwind.DataAccess
{
    public class DBConnectionFactory
    {

        private const string ConnectionString = "Server=.;Database=Northwind; Integrated Security=True;";

        public static SqlConnection Create()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
