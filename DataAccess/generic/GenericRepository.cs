using Core.Internal;
using Entities;
using Microsoft.EntityFrameworkCore; 
using System.Linq.Expressions;

namespace DataAccess.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbCon _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbCon context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(object id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }
    }
}
