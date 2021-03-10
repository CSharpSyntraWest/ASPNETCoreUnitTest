using Microsoft.EntityFrameworkCore;
using Project.API.DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.DataAccess
{
    public class EntityRepository<T>: IEntityRepository<T> where T:class,new()
    {
        private CustomerDbContext _dbContext;
        private DbSet<T> _dbSet;
        public EntityRepository(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public virtual void Insert(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public virtual IQueryable<T> GetAllQueryable()
        {
            return _dbSet;
        }

    }
}
