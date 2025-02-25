using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] // Ulaşılma Yolu
    [ApiController] // ATTRIBUTE
    public class ProductsController : ControllerBase
    {
        IProductService _productService; // Loosely Coupled - Soyut Sınıfa Bağlılık
                                         // Business katmanına bağımlı ama soyut yapı üzerinden bağlantısı var.
        public ProductsController(IProductService productService) // Program.cs'de IoC kullanıldı
        {
            _productService = productService;
        }

        [HttpGet("getall")] // Sistemden datayı almak
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpPost("add")] // Datayı sisteme vermek. Postman üzerinden json formatıyla veri eklendi.
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success) 
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
