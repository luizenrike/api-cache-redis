using APICacheRedis.Domain.Interfaces;
using APICacheRedis.Domain.Models;

namespace APICacheRedis.Application.Services
{
    public class AgenciaService : Interfaces.IAgenciaService
    {
        private readonly IAgenciaService _agenciaService;
        public AgenciaService(IAgenciaService agenciaService)
        {
            _agenciaService = agenciaService;
        }
        public async Task<IEnumerable<Agencia>> GetAll()
        {
            var response = await _agenciaService.GetAll();
            return response;
        }
    }
}
