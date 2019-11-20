using ApplicationCore.Interfaces;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq; // ToList() thuoc Linq
namespace Infrastructure.Persistence.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class, IAggregateRoot // class ???
    {
        private readonly DbContext _context;

        public EFRepository(DbContext context)
        {
            _context = context;
        }

        protected DbContext Context => _context;

        public T GetBy(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

       /* public IEnumerable<T> Find(ISpecification<T> spec)
        {
            //return ApplySpecification(_context.Set<T>().AsQueryable(), spec);
    
        }*/

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public int Count()
        {
            return _context.Set<T>().Count();
        }
    }
}