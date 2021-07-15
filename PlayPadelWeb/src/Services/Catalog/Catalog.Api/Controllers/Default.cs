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

            return "Running Catalog ..";
        }

        [HttpGet]
        public async Task<DataCollection<ProductDto>> GetAll(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<int> products = null;

            if (!string.IsNullOrEmpty(ids))
            {
                products = ids.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _productQueryService.GetAllAsync(page, take, products);
        }
    }
}
