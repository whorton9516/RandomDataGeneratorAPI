using Microsoft.AspNetCore.Mvc;

using RandomDataGeneratorAPI.Services;

namespace RandomDataGeneratorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AddressController : ControllerBase
{
    private readonly IDataGenerator _dataGenerator;

    [HttpGet]
    [Route("get")]
    public IActionResult Get([FromQuery] int count = 1)
    {
        try
        {
            if (count > 0)
            {
                var addresses = _dataGenerator.GenerateAddresses(count);
                return Ok(addresses);
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
