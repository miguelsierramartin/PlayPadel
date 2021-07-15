using Catalog.Service.Queries;
using Catalog.Services.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Common.Collection;
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

        private readonly IProductQueryService _productQueryService;
        private readonly ILogger<ProductController> _logger;

        public Default(
            ILogger<ProductController> logger,
            IProductQueryService productQueryService)
        {
            _logger = logger;
            _productQueryService = productQueryService;
        }


        [HttpGet]
        public string Get()
        {

            return "Corriendo el microservicio de Catalog ..";
        }

    }
}
