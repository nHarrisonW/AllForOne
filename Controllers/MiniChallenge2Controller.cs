using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge2Controller : ControllerBase
{
    [HttpGet]
    [Route("Adding/{numberOne}/{numberTwo}")]
    public int Adding(int numberOne = 0, int numberTwo = 0)
    {
        return (numberOne + numberTwo);
    }
}
