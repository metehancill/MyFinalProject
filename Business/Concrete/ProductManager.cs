using System;
using Entities.Concrete;
using Business.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Abstract;

namespace Business.Concrete

{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            // İŞ KODLARI
            //if vs burada olur verilen durumları karşılıyorsa anlamına gelir.
            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice<=min && p.UnitPrice<=max);
        }
    }
}

