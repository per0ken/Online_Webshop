using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebshopAPI.Database;
using WebshopAPI.Models;
using AutoMapper;

namespace WebshopAPI.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper, ILogger<HelloWorldController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost("account/register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.Username, Email = model.Email, FullName = model.FullName};
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User registered.");
                    return Ok(new { message = "User registered successfully" });
                }

                return BadRequest(result.Errors);
            }

            return BadRequest("Invalid data");
        }
    }
}
