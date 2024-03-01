using APICacheRedis.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICacheRedis.Infra.Repositories
{
    public class Repository<TEntity>: IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly Context _context;
        public Repository(Context context)
        {
            _context = context;

        }

        void IRepository<TEntity>.Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        void IRepository<TEntity>.Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }

        void IRepository<TEntity>.Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        async Task<List<TEntity>> IRepository<TEntity>.ToListAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        List<TEntity> IRepository<TEntity>.ToList()
        {
            return _context.Set<TEntity>().ToList();
        }
    }
}
