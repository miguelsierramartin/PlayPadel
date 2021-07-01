using Microsoft.AspNetCore.Mvc;

namespace Api.Gateway.WebClientReservas.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Running Gateway Reserva..";
        }
    }
}