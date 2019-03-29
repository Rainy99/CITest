using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebAplication.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        
        [HttpGet]
        [Route("/")]
        public string Index()
        {
            var now = DateTimeOffset.Now.LocalDateTime.ToString("yyyy-MM-dd hh:mm:ss");
            var version = _configuration["Version"];
            return $"Now:{now}  Application Version:{version}";
        }
    }
}
