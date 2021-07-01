using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Gateway.WebClientReservas.Controllers
{
    [ApiController]
    [Route("/")]
    public class ReservaController : ControllerBase
    {

        private readonly ILogger<ReservaController> _logger;

        public ReservaController(ILogger<ReservaController> logger)
        {
            _logger = logger;
        }



    }
}
