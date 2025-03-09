using Microsoft.AspNetCore.Mvc;

namespace WebshopAPI.Controllers
{
    [Route("home")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("HelloWorldController's Get method was called.");
            return Ok("Hello, World!");
        }
    }
}
