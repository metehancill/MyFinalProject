using System;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{ 
	public interface IProductService
	{
		IDataResult<List<Product>> GetAll();//ürün listesi döndürür
		IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByUnitPrice(decimal min,decimal max);
		IDataResult<List<ProductDetailDTO>> GetProductDetails();
		IResult Add (Product product);
        IDataResult<Product> GetById(int productId);
    }
}

