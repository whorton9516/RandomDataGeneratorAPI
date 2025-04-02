using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

using RandomDataGeneratorAPI.Services;

namespace RandomDataGeneratorAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IDataGenerator _dataGenerator;
    
    public UserController(IDataGenerator dataGenerator)
    {
        _dataGenerator = dataGenerator;
    }

    [HttpGet]
    [Route("get")]
    public IActionResult Get([FromQuery] int count = 1)
    {
        try
        {
            if (count > 0)
            {
                var users = _dataGenerator.GenerateUsers(count);
                return Ok(users);
            }
            else
            {
                return BadRequest("Count must be greater than 0");
            }
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    [Route("names")]
    public IActionResult GetNames([FromQuery] int count = 1)
    {
        try
        {
            if (count > 0)
            {
                var names = _dataGenerator.GenerateNames(count);
                return Ok(names);
            }
            else
            {
                return BadRequest("Count must be greater than 0");
            }
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    [Route("emails")]
    public IActionResult GetEmails([FromQuery] int count = 1)
    {
        try
        {
            if (count > 0)
            {
                var emails = _dataGenerator.GenerateEmails(count);
                return Ok(emails);
            }
            else
            {
                return BadRequest("Count must be greater than 0");
            }
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    [Route("phoneNumbers")]
    public IActionResult GetPhoneNumbers([FromQuery] int count = 1)
    {
        try
        {
            if (count > 0)
            {
                var phoneNumbers = _dataGenerator.GeneratePhoneNumbers(count);
                return Ok(phoneNumbers);
            }
            else
            {
                return BadRequest("Count must be greater than 0");
            }
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpGet]
    [Route("usernames")]
    public IActionResult GetUsernames([FromQuery] int count = 1)
    {
        try
        {
            if (count > 0)
            {
                var usernames = _dataGenerator.GenerateUsernames(count);
                return Ok(usernames);
            }
            else
            {
                return BadRequest("Count must be greater than 0");
            }
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
