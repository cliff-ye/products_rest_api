using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWebApi.Dto;
using RepositoryPatternWebApi.Models;

namespace RepositoryPatternWebApi.Services.ProductService
{
    public interface IProductService 
    {
        public Task<ActionResult<Product>> GetProductById(int id);
       
    }
}
