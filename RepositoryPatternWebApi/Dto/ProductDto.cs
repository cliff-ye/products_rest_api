using System.ComponentModel.DataAnnotations;
namespace RepositoryPatternWebApi.Dto
{
    public record ProductDto(string Name, decimal Price, string Description);
}
