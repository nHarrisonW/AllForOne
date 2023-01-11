using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge7Controller : ControllerBase
{
    [HttpGet]
    [Route("this/{reversible}")]

    public string ReverseThisNumber(string reversible, bool isNumber, int number = 0, int reverseNumber = 0)
    {
        isNumber = Int32.TryParse(reversible, out number);
        string rvrs = string.Empty;
        if (isNumber == true)
        {
            for (int i = reversible.Length - 1; i >= 0; i--)
            {
                rvrs += reversible[i];
            }
            return $"{rvrs} is the number you entered, but backwards!";
        }
        else if (!isNumber)
        {
            for (int i = reversible.Length - 1; i >= 0; i--)
            {
                rvrs += reversible[i];
            }

        }
        return $"{rvrs} is what you entered, but backwards, although it wasn't exactly a number...";
    }

}