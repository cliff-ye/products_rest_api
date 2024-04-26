using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWebApi.CustomMapping;
using RepositoryPatternWebApi.Data;
using RepositoryPatternWebApi.Dto;
using RepositoryPatternWebApi.GenericRepository;
using RepositoryPatternWebApi.Models;
using RepositoryPatternWebApi.Services.ProductService;
using RepositoryPatternWebApi.UnitofWork;


namespace RepositoryPatternWebApi.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        public IGenericRepository<Product> productRepo;
       

        public ProductController(IUnitofWork unitofWork)
        {
           _unitofWork = unitofWork;
            productRepo = new ProductService(unitofWork);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> AddProduct([FromBody]ProductDto productDto)
        {
            var product = CustMap.DtoToProduct(productDto);
            
            return await productRepo.Add(product);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await productRepo.Get(id);
            return product;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = await productRepo.GetAll();
            return products;
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductDto productDto)
        {
            var product = CustMap.DtoToProduct(productDto);
            await productRepo.Update(id, product);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var delProd = await productRepo.Delete(id);

            return delProd;
        }


    }
}
