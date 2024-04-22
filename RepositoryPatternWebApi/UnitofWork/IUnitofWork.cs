using Microsoft.EntityFrameworkCore;
using RepositoryPatternWebApi.Services.ProductService;

namespace RepositoryPatternWebApi.UnitofWork
{
    public interface IUnitofWork : IDisposable 
    {
        DbContext dbContext { get; }
        IProductService productService { get; }
        public Task SaveChangesAsync();
    }
}
