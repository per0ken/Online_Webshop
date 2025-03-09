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

    [HttpPost("account/login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Username);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        _logger.LogInformation("Login was successful");
                        return Ok(new { message = "Login was successful" });
                    }
                    else
                    {
                        _logger.LogInformation("Invalid password");
                        return Unauthorized(new { message = "Invalid password" });
                    }
                }

                return Unauthorized(new { message = "User not found" });
            }

            return BadRequest(new { message = "Invalid data" });
        }
    }
}
