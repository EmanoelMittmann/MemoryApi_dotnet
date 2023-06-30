using Api_almostHacker.Infra;
using Api_almostHacker.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_almostHacker.Controllers
{
    public class UserController : Controller
    {
        private ApiContext _context; 
        public UserController()
        {
            _context = new ApiContext();
        }

        [HttpPost("User")]
        public async Task<IActionResult> Save([FromBody] User model)
        {
            _context.Users.Add(model);
            await _context.SaveChangesAsync();
            return Ok(model);    
        }

        [HttpGet("User")]

        public async Task<IActionResult> Index()
        {
            return Ok(_context.Users.ToList());
        }

    }
}
