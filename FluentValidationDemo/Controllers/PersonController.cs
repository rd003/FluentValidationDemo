using FluentValidationDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationDemo.Controllers;

[ApiController]
[Route("api/people")]
public class PersonController : ControllerBase
{

    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> AddPerson(Person person)
    {
        try
        {
            return Ok("Added");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return StatusCode(500, ex.Message);
        }
    }

   
}
