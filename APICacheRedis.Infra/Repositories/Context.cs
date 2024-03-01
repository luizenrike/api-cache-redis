using APICacheRedis.Domain.Models;
using APICacheRedis.Infra.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICacheRedis.Infra.Repositories
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(AgenciaConfiguration).Assembly);
        }

        // reference in database
        public DbSet<Agencia> Agencias { get; set; }
    }
}
