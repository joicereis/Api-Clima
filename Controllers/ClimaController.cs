using Api_Clima.Interface;
using Api_Clima.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api_Clima.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClimaController : ControllerBase
    {
        private readonly ClimaService _climaService;

        public ClimaController(ClimaService climaService)
        {
            _climaService = climaService;
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> GetClima(string city)
        {
            try
            {
                var clima = await _climaService.GetClimaAsync(city);
                return Ok(clima);
            }
            catch (Exception ex)
            {
                return  BadRequest(new { message = ex.Message });
            }

        }
    }


}
