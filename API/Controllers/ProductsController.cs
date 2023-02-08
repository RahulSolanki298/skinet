using Core.Entities;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepo;

        public ProductsController(IProductRepository productRepo)
        {
            _productRepo= productRepo;
        }

        [HttpGet]
        public async Task<IReadOnlyList<Product>> GetProducts()
        {
            return await _productRepo.GetProductsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id)
        {
            return await _productRepo.GetProductByIdAsync(id);
        }

        [HttpGet("brands")]
        public async Task<IReadOnlyList<ProductBrand>> GetBrands()
        {
            return await _productRepo.GetBrandsAsync();
        }
        
        [HttpGet("types")]
        public async Task<IReadOnlyList<ProductType>> GetTypes(int id)
        {
           return await _productRepo.GetTypesAsync();
        }
    }
}