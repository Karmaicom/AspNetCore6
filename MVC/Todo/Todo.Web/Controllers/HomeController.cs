using Microsoft.AspNetCore.Mvc;

namespace Todo.Web.Controllers
{

    [ApiController]
    [Route("api/home")]
    public class HomeController : ControllerBase
    {

        [HttpGet("hello")]
        public string Hello()
        {
            return "Hello World";
        }

    }
}
