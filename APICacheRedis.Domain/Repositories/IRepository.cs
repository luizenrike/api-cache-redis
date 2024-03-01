using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICacheRedis.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        List<TEntity> ToList();
        
        Task<List<TEntity>> ToListAsync();

    }
}
