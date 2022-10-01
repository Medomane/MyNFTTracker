using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyNFTTracker.Models;

namespace MyNFTTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppUserController : ControllerBase
    {
        private readonly ILogger<AppUserController> _logger;

        public AppUserController(ILogger<AppUserController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<AppUser> Get()
        {
            var appCtx = new MyNFTTrackerContext();
            return new[]
            {
                new AppUser {Id = 1,Discord = "Discord",Username = "Mohamed",Role = "admin"}
            };
        }
    }
}