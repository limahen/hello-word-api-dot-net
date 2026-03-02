using Microsoft.AspNetCore.Mvc;

namespace hello_word_api_dot_net.Controllers;

[ApiController]
[Route("")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return "Hello World!";
    }
}
