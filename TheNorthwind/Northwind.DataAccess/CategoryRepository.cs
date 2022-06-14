using Dapper;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess
{
    // repository sınıf
    // Veritabanındaki bir tabloyu yazılım ortamında bir koleksiyon şeklinde temsil eden yapılar 
    // Repository: Depo
    public class CategoryRepository
    {
        // Eğer bir sınıfın koleksiyon tipinde public bir üyesi varsa bunun tipini
        // sınıf olarak değil interface olarak tanımlayın.

        public IEnumerable<Category> GetAll()
        {
            var category = Enumerable.Empty<Category>();

            using (var connection = DBConnectionFactory.Create())
            {
                return connection.Query<Category>("SELECT * FROM Categories");
            }
        }

        public void Add(Category category)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = @"
insert into Categories (CategoryName, Description)
values (@CategoryName, @Description)";

                    connection.Execute(sqlText, category);
            }
        }

        public void Update(Category category)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = @"
update Categories set CategoryName = @CategoryName,
Description = @Description
where CategoryID = @CategoryID";

                    connection.Execute(sqlText, category);
            }
        }

        public void Remove(Category category)
        {
            Remove(category.CategoryID);
        }

        public void Remove(int categoryID)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = "delete from categories where CategoryID = @CategoryID";

                connection.Execute(sqlText, new { categoryID = categoryID });
            }
        }

        public Category Find(int categoryID)
        {
            using (var connection = DBConnectionFactory.Create())
            {
                const string sqlText = "select * from categories where CategoryID = @categoryID";

                var category = connection.QuerySingleOrDefault<Category>(sqlText, new { categoryID = categoryID });
                return category;
            }
        }
    }
}
