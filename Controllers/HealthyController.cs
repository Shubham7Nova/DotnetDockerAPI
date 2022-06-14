using Microsoft.AspNetCore.Mvc;

namespace DotnetDockerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthyWebApi : ControllerBase
{
    private readonly ILogger<HealthyWebApi> _logger;

    public HealthyWebApi(ILogger<HealthyWebApi> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "healthy")]
    public string Get()
    {
        return "WebApi is running.";
    }

}
