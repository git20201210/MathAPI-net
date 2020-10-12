using MathAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MathAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly IAddService _addService;

        public MathController(IAddService addService)
        {
            _addService = addService;
        }

        [HttpGet("add/{a}/{b}")]
        public IActionResult Get(double a, double b)
        {
            return Ok(new
            {
                elementOne = a,
                elemetTwo = b,
                sum = _addService.Add(a, b)
            });
        }
    }
}
