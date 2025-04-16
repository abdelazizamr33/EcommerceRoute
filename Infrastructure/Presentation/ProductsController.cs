using Microsoft.AspNetCore.Mvc;
using ServicesAbstractions;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(IServiceManager serviceManager) :ControllerBase
    {
        // endpoint : public non sttic method
        //sort default based on name 
        [HttpGet] //Get: /api/products
        public async Task<IActionResult> GetAllProducts([FromQuery]ProductSpecificationsParameters SpecParam)
        {
            var result = await serviceManager.ProductService.GetAllProductsAsync(SpecParam);
            if (result is null) return BadRequest();
            return Ok(result);//return Status code 200
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductsById(int id)
        {
            var res=await serviceManager.ProductService.GetProductByIdAsync(id);
            if(res is null) return BadRequest();
            return Ok(res);
        }
        [HttpGet("brands")] // GET : /api/products/brands
        public async Task<IActionResult> GetAlBrands()
        {
            var result=await serviceManager.ProductService.GetAllBrandsAsync();
            if (result is null) return BadRequest();
            return Ok(result);
        }
        [HttpGet("types")] // GET : /api/products/types
        public async Task<IActionResult> GetAllTypes()
        {
            var result = await serviceManager.ProductService.GetAllTypesAsync();
            if (result is null) return BadRequest();
            return Ok(result);
        }
    }
}
