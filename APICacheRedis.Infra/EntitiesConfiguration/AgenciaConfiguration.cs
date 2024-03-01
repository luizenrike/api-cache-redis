using APICacheRedis.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICacheRedis.Infra.EntitiesConfiguration
{
    public class AgenciaConfiguration : IEntityTypeConfiguration<Agencia>
    { 
        public void Configure(EntityTypeBuilder<Agencia> builder)
        {
            builder.HasNoKey();
        }
    }
}
