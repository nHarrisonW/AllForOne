using Microsoft.AspNetCore.Mvc;

namespace AllForOne.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCahllenge6Controller : ControllerBase
{
    [HttpGet]
    [Route ("evaluate/{userNumber}")]
    public string OddOrEvenNumber(string userNumber, bool isNumber = false, int validNumber = 0)
    {
        isNumber = Int32.TryParse(userNumber, out validNumber);
        if(isNumber == true)
        {
        if(validNumber % 2 == 0)
        {
            return $"{userNumber} is an even number";
        }else{
            return $"{userNumber} is an odd number";
        }
        }
        return "THAT IS NOT A NUMBER!!!!";
    }
}