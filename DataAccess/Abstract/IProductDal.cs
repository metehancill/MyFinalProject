using System;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
	public interface IProductDal:IEntityRepository<Product> // Veri tabanı operasyonlarını içerir
	{
		List<ProductDetailDTO> GetProdcutDetails();

 	}
}

//Code refactoring

