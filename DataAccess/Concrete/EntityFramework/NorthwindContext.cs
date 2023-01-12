using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	//Context : Db tabloları ile proje classları bağlamak için kullanılır
	public class NorthwindContext:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // bu metod hangi veri tabanımızla ilişkili olduğumuzu belirttiğimiz yerdir
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind,;Trusted_Connection=true");// Connection string girilir.
        }//belirtilen veri tabanının ->

        public DbSet <Product> Products { get; set; } //->verilen tablolara bağlanması
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

    }
}

