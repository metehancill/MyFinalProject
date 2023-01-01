using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

class Program
{

    // SOLID -- Open close Principle
    // Yeni bir kod eklenirken mevcuttaki kodalr değiştirlmez dokunulmaz...
    static public void Main(String[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetAllByUnitPrice(50,100))
        {
            Console.WriteLine(product.ProductName);
        }
        
    }
}