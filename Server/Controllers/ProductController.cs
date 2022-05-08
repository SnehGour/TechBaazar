using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Model;
using Server.Repository.IRepository;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepo;
        public ProductController(IProductRepository productRepository)
        {
            _productRepo = productRepository;
        }

        [HttpGet("getallproducts")]
        public IActionResult getAllProducts()
        {
            var allProducts = _productRepo.getAllProducts();
            if(allProducts == null)
                return NotFound();

            return Ok(allProducts);
        }

        [HttpPost("addproduct")]
        public IActionResult addProduct(Products product)
        {
            if(product == null)
            {
                return BadRequest(new {message = "Please make sure data is correct"});
            }
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            if(!_productRepo.addProduct(product))
            {
                return BadRequest(new {message =$"Something went wrong while saving the product {product.Name}"});
            }
            return Ok(product);
        }

        [HttpPost("getproduct")]
        public IActionResult getProduct(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var product =  _productRepo.getProduct(id);
            if(product == null)
            {
                return BadRequest(new { message = "Invalid Id" });
            }
            return Ok(product);
        }

    }
}
