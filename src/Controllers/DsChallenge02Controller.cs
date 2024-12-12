using Microsoft.AspNetCore.Mvc;

namespace ds_challenge_02.Controllers;

[ApiController]
[Route("api/hello")]
public class DsChallenge02Controller : ControllerBase
{

    [HttpGet(Name = "GreetUser")]
    public string GreetUser()
    {
        return "TODO: updated to accept a string as a parameter and returns a concatenated string of \"Hello \" and the passed name";
    }
}