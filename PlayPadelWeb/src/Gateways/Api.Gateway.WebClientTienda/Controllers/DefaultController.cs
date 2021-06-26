using Microsoft.AspNetCore.Mvc;

namespace Api.Gateway.WebClientTienda.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Running Gateways..";
        }
    }
}