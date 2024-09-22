using Microsoft.AspNetCore.Mvc;
using LibraryAPI.DTOs;  // Make sure to include the namespace for LoginRequest
using LibraryAPI.Services;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest login)
        {
            if (login == null || string.IsNullOrEmpty(login.Username) || string.IsNullOrEmpty(login.PasswordHash))
            {
                return BadRequest("Invalid login request.");
            }

            // Replace with actual user retrieval logic (e.g., from the database)
            var storedUser = new User
            {
                Username = "testuser",
                PasswordHash = "$2a$12$6NJwS2.v/9QwESZJgGBYt.XvGEnyGFbFR915ygA0SKfezSZyTr/3K",
                Role = "Member"
            };

            // Verify the entered password against the stored bcrypt hash
            if (login.Username == storedUser.Username && BCrypt.Net.BCrypt.Verify(login.PasswordHash, storedUser.PasswordHash))
            {
                var token = _tokenService.BuildToken(new User { Username = login.Username, Role = "Member" });
                return Ok(new { token });
            }

            return Unauthorized();
        }

    }
}
