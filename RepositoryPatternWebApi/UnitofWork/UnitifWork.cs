using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RepositoryPatternWebApi.Data;
using RepositoryPatternWebApi.Services.ProductService;


namespace RepositoryPatternWebApi.UnitofWork
{
    public class UnitifWork : IUnitofWork
    {
        private readonly AppDbContext _appDbContext;
       
        public UnitifWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public DbContext dbContext => _appDbContext;

        public IProductService productService {  get; set; }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }

        public async Task SaveChangesAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
