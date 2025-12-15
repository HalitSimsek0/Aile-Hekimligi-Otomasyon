using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Internal
{

    public interface IRepository<T> where T : class
    {

        IEnumerable<T> GetAll();
        T GetById(object id);
        void add(T entity);
        void Update(T entity);
        void Delete(object id);
        IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
    }
}

