using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers 
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context= context;
        }

        [HttpGet("GetProducts")]
        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpGet("GetProduct/{id}")]
        public async Task<Product> GetProduct(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(x=>x.Id == id);
        }
        
    }
}