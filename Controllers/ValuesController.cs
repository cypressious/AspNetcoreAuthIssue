using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspAuthIssue.Controllers
{
    [Authorize]
    [Route("")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("post")]
        public void Foo()
        {
        }

        [Authorize(AuthenticationSchemes = "Basic")]
        [HttpGet("get")]
        public string Get() => "OK";
    }
}