using Microsoft.AspNetCore.Mvc;

namespace SKE.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SourcesController : ControllerBase
    {
        private readonly ILogger<SourcesController> _logger;

        public SourcesController(ILogger<SourcesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>();
        }
    }
}