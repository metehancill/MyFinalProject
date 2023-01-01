using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {    //ORM Object Relatioanl Mapping
        // Veri tabanıyla bağın kurulum veri tabanı işlmelerini yapılması süreci EF...


        public void All(Product entity)
        {   //IDisposable pattern implementasyon of c#
            using (NorthwindContext context=new NorthwindContext())//bir class newlendiğinde g.c using bitince bellekten atılmasını sağlar
            {
                var addedEntitiy = context.Entry(entity);
                addedEntitiy.State = EntityState.Added;
                context.SaveChanges();  
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntitiy = context.Entry(entity);
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Product>().ToList()       //Select * From Products döndürür
                    : context.Set<Product>().Where(filter).ToList();         
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntitiy = context.Entry(entity);
                updatedEntitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

