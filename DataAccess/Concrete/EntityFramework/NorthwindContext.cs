using System;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	//Context : Db tabloları ile proje classları bağlamak için kullanılır
	public class NorthwindContext:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // bu metod hangi veri tabanımızla ilişkili olduğumuzu belirttiğimiz yerdir
        {
            optionsBuilder.UseSqlServer(@"Server=(localhost)");// Connection string girilir.


        }
    }
}

