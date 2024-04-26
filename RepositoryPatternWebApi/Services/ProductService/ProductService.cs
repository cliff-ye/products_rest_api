using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPatternWebApi.Data;
using RepositoryPatternWebApi.Dto;
using RepositoryPatternWebApi.GenericRepository;
using RepositoryPatternWebApi.Models;
using RepositoryPatternWebApi.UnitofWork;

namespace RepositoryPatternWebApi.Services.ProductService
{
    public class ProductService : GenericRepository<Product>, IProductService
    {
        public ProductService(IUnitofWork unitofwork) : base(unitofwork)
        {
        }

       
    }
}
