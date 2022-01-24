using Microsoft.EntityFrameworkCore;
using SFAContracts.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SFAData.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T: class
    {
        private readonly DataContext _context;

        public RepositoryBase(DataContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
             await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void EditAsync(T entity)
        {
             _context.Set<T>().Update(entity);
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
           return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> FindAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}
