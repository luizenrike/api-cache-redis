using APICacheRedis.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APICacheRedis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenciaController : ControllerBase
    {

        private readonly IAgenciaService _agenciaService;
        public AgenciaController(IAgenciaService agenciaService)
        {
            _agenciaService = agenciaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var response = await _agenciaService.GetAll();
            return Ok(response);
        }
    }
}
