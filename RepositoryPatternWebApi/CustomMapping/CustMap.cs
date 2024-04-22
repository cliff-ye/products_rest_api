using RepositoryPatternWebApi.Dto;
using RepositoryPatternWebApi.Models;

namespace RepositoryPatternWebApi.CustomMapping
{
    public class CustMap
    {
        public static Product DtoToProduct(ProductDto productDto)
        {
            Product p = new Product()
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Description = productDto.Description,
            };
            
            return p;
        }
    }
}
