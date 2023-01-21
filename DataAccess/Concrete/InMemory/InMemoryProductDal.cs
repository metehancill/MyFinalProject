using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
                //Veri tabanından gelen veri simülesi
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1, ProductName="Bardak", UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=2, ProductName="Kamera", UnitPrice=105,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2, ProductName="Telefon", UnitPrice=1500,UnitsInStock=85},
                new Product{ProductId=4,CategoryId=2, ProductName="Klavye", UnitPrice=65,UnitsInStock=1},
            };
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void All(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {  //ürünler silerken pk ile silinir bu bölümde eşleşen ıdler e göre silme yapılır.
            //LINQ Language Integrated Query
           Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId); // For görevi yapar
            _products.Remove(productToDelete);               // Her p için gönderilen p için gelen Product id ler eşitse birbirine eşitle
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();//Yeni bir liste olarak getirir SQL where sorgusu ile aynı.
        }

        public List<ProductDetailDTO> GetProdcutDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)//Parametre ekrandan gelen datadır.
        {
            //Gömnderilen ürünün idsine sahip listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;//product burada gönderilen elemanın değerine atanır."
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}

