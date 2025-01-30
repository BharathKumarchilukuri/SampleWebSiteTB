using Microsoft.AspNetCore.Mvc;

namespace SampleApplication_Backend.Controllers
{
    [Route("api/Bharath")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello World";
        }
    }
}
