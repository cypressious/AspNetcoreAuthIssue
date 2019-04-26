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
        [HttpGet("bar")]
        public void Foo()
        {
        }

        [Authorize(AuthenticationSchemes = "Basic")]
        [HttpGet("foo")]
        public string Get() => "OK";
    }
}