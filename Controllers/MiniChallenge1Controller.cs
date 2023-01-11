using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge1Controller : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]
    public string SayHello(string name){
        return $"Nice to meet you, {name}";
    }
}
