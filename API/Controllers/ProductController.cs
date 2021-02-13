using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/{Controller}")]
    public class ProductController:ControllerBase
    {

        private readonly App_DbContext _DbContext;
        public ProductController(App_DbContext context)
        {
            _DbContext= context;
            
        }
        [HttpGet]
    [Route("ProductList")]
        public async Task<ActionResult<List<Product>>>  ProductList()
        {
            var result = await _DbContext.Products.ToListAsync();
            return Ok(result);
        }
        [HttpGet]
    [Route("ProductById/{id}")]
        public  async Task<ActionResult<Product>> ProductById(int id)
        {
            return  await _DbContext.Products.FindAsync(id);
        }
    }
}