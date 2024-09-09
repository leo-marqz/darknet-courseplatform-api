
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DarkNetCoursePlatform.Api.Controllers
{
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getstring")]
        public IActionResult Get()
        {
            _logger.LogInformation("GET request received");
            return Ok("Hello from DarkNetCoursePlatform.Api");
        }
    }
}