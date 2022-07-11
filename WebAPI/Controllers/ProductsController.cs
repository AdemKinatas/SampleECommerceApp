using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
            if (products.Count > 0)
            {
                return Ok(products);
            }
            return NotFound();
        }

        [HttpGet("getProductsByCategoryId/{id}")]
        public async Task<IActionResult> GetProductsByCategoryId(int id)
        {
            var products = await _productService.GetProductsByCategoryAsync(id);
            if (products.Count > 0)
            {
                return Ok(products);
            }
            return NotFound();
        }

        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound();
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Product product)
        {
            await _productService.AddAsync(product);
            return Ok(product);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Product product)
        {
            await _productService.UpdateAsync(product);
            return Ok(product);
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> Delete(Product product)
        {
            await _productService.DeleteAsync(product);
            return Ok();
        }
    }
}
