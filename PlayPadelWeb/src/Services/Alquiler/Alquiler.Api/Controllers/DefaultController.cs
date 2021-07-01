using Microsoft.AspNetCore.Mvc;

namespace Alquiler.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Running Alquiler ..";
        }
    }
}
