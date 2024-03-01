using APICacheRedis.Domain.Interfaces;
using APICacheRedis.Domain.Models;
using APICacheRedis.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APICacheRedis.Domain.Services
{
    public class AgenciaService : IAgenciaService
    {
        private readonly IRepository<Agencia> _repository;
        private readonly ICachingService _cacheService;
        private readonly string KEY_AGENCIAS = "AGENCIAS";

        public AgenciaService(IRepository<Agencia> repository, ICachingService cacheService)
        {
            _repository = repository;
            _cacheService = cacheService;

        }
        public async Task<IEnumerable<Agencia>> GetAll()
        {

            //check data in cache
            var cacheData = await _cacheService.GetAsync(KEY_AGENCIAS);
            
            var response = new List<Agencia>();

            if (!string.IsNullOrEmpty(cacheData))
            {
                response = JsonSerializer.Deserialize<List<Agencia>>(cacheData);
                return response;
            }

            response = await _repository.ToListAsync();
            await _cacheService.SetAsync(KEY_AGENCIAS, JsonSerializer.Serialize(response));

            
            return response;
        }
    }
}
