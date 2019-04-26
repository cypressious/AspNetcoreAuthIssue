using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspAuthIssue.Controllers
{
    [Authorize]
    [Route("")]
    public class ValuesController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("bar")]
        public void Bar()
        {
        }

        [Authorize(AuthenticationSchemes = "Basic")]
        [HttpGet("foo")]
        public void Foo()
        {
        }
    }
}