using Microsoft.EntityFrameworkCore;
using RepositoryPatternWebApi.Models;

namespace RepositoryPatternWebApi.Data
{
    public class AppDbContext : DbContext
    {
      
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
