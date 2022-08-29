using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Anu.DataAccess.Repositories
{
    public class GenericRepository<T> : Anu.Domain.IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public async Task AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().Where(expression).ToListAsync();
        }
        
        public async Task<bool> Exist(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public async Task<T> GetById(string id)
        {
            return _context.Set<T>().Find(id);
        }
        public async Task Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public async Task RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}
