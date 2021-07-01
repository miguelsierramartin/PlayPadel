

using Alquiler.Service.EventHandlers.Command;
using Alquiler.Service.Queries;
using Alquiler.Service.Queries.DTOs;
using MediatR;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Common.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alquiler.Api.Controllers
{
   // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("v1/pistas")]
    public class PistaController : ControllerBase
    {
        private readonly IPistaQueryService _pistaQuerService;
        private readonly ILogger<PistaController> _logger;
       private readonly IMediator _mediator;

        public PistaController(
            ILogger<PistaController> logger,
            IMediator mediator,
            IPistaQueryService pistaQuerService)
        {
            _logger = logger;
            _mediator = mediator;
            _pistaQuerService = pistaQuerService;
        }

        [HttpGet]
        public async Task<DataCollection<PistaDto>> GetAll(int page = 1, int take = 10, string ids = null)
        {
            IEnumerable<int> pistas = null;

            if (!string.IsNullOrEmpty(ids))
            {
                pistas = ids.Split(',').Select(x => Convert.ToInt32(x));
            }

            return await _pistaQuerService.GetAllAsync(page, take, pistas);
        }

        [HttpGet("{id}")]
        public async Task<PistaDto> Get(int id)
        {
            return await _pistaQuerService.GetAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReservaCreateCommand notification)
        {
            await _mediator.Publish(notification);
            return Ok();
        }
    }

}