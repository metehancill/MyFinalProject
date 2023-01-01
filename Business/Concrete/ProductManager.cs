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
    }
}

