using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

class Program
{

    // Main Method
    static public void Main(String[] args)
    {
        ProductManager productManager = new ProductManager(new InMemoryProductDal());

        foreach (var product in productManager.GetAll())
        {
            Console.WriteLine(product.ProductName);
        }
        
    }
}