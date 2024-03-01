
using APICacheRedis.Domain.Interfaces;
using APICacheRedis.Domain.Repositories;
using APICacheRedis.Domain.Services;
using APICacheRedis.Infra.Caching;
using APICacheRedis.Infra.Repositories;

namespace APICacheRedis.Configuration
{
    public static class RepositoryConfig
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IAgenciaService, AgenciaService>();
            services.AddScoped<ICachingService, CachingService>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<Application.Interfaces.IAgenciaService, Application.Services.AgenciaService>();
        }
    }
}
