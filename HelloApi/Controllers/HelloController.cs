using Microsoft.AspNetCore.Mvc;

namespace HelloApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET api/name/HelloWorld
        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            return "Hello " + name + "!";
        }
    }
}
