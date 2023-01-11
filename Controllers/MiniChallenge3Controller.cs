using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge3Controller : ControllerBase
{
    [HttpGet]
    [Route("Asking/{name}/{time}")]
    public string AskingQuestions(string name, string time)
    {
        return $"Greetings {name}, {time} sure is early!";
    }
}
