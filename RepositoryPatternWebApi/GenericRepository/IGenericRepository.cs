using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWebApi.Dto;
using RepositoryPatternWebApi.Models;

namespace RepositoryPatternWebApi.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<ActionResult<IEnumerable<T>>> GetAll();
        public Task<ActionResult<T>> Get(int id);
        public Task<ActionResult<T>> Add(T entity);
        public Task<IActionResult> Update(int id,T entity);
        public Task<IActionResult> Delete(int id);

    }
}
