using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Deployment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpGet("hello")]
        public string Hello()
        {
            return "hello";
        }
    }
}
