using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Nomad.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NomadController : ControllerBase
    {        
        private readonly ILogger<NomadController> _logger;

        public NomadController(ILogger<NomadController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Status()
        {
            return "Service is available";
        }
    }
}
