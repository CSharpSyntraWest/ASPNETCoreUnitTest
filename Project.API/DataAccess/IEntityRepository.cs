using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.DataAccess
{
    public interface IEntityRepository<T> where T : class, new()
    {
        void Insert(T entity);
        IQueryable<T> GetAllQueryable();
    }
}
