using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class Default : ControllerBase
    {

        private readonly ILogger<Default> _logger;

        public Default(ILogger<Default> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Running Catalog ..";
        }
    }
}
