using Microsoft.AspNetCore.Mvc;

namespace Cproject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("index")]
    public IActionResult Index()
    {
        return Ok(new { Message = "Welcome to the API!" });
    }

    [HttpGet("privacy")]
    public IActionResult Privacy()
    {
        return Ok(new { Message = "Privacy endpoint not implemented." });
    }

    [HttpGet("error")]
    public IActionResult Error()
    {
        _logger.LogError("An error occurred.");
        return Problem(detail: "An error occurred.", statusCode: 500);
    }
}