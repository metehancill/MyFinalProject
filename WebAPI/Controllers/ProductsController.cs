using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        //filed alt çizgiyle verilir naming convention
        IProductService _productService;

        //IoC container -- Inversion of Control
        public ProductsController(IProductService productService) //controller sen bir ıporductservice bağımlısın
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {   //Dependency chain -- bağımlılık zinciri

            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success) { 
            return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);  
            }
            return BadRequest(result);
        }
    }
}


