using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPatternWebApi.UnitofWork;

namespace RepositoryPatternWebApi.GenericRepository
{
    public class GenericRepository<T> : ControllerBase, IGenericRepository<T> where T : class
    {
        private readonly IUnitofWork _unitofwork;
        protected DbSet<T> _dbSet;

        public GenericRepository(IUnitofWork unitofwork) 
        {
            _unitofwork = unitofwork;
            _dbSet = _unitofwork.dbContext.Set<T>();
        }

        public async Task<ActionResult<T>> Add(T entity)
        {
             _dbSet.Add(entity);
            await _unitofwork.SaveChangesAsync();
            return entity;
        }

        public async Task<IActionResult> Delete(int id)
        {
            var data = await _dbSet.FindAsync(id);
            if(data == null)
            {
                return NotFound();
            }
            _dbSet.Remove(data);
            await _unitofwork.SaveChangesAsync();
            return NoContent();
        }

        public async Task<ActionResult<T>> Get(int id)
        {
            var data = await _dbSet.FindAsync(id);
            if(data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        public async Task<ActionResult<IEnumerable<T>>> GetAll()
        {
            var data = await _dbSet.ToListAsync();

            if(data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        public Task<IActionResult> Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
