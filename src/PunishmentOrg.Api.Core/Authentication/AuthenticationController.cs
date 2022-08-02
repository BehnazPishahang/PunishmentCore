using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Anu.PunishmentOrg.Api.Authentication
{
    public class User
    { 
    }
    public class UserLoginRequestDto
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string? Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? Password { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? PhoneNumber { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? PhoneNumberNew { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string? TitleNew { get; set; }
    }

    public class AuthResult
    {
        public string? Token { get; set; }
        public bool Result { get; set; }
        public List<string>? Errors { get; set; }
    }

    public class AuthenticationController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthenticationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
         
        [Route("Login")]
        [HttpPost]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public async Task<IActionResult> Login([FromBody]UserLoginRequestDto loginRequest)
        {
                // Check if the user exist
                //var existing_user;// await _userManager.FindByEmailAsync(loginRequest.Email);

                if (loginRequest == null)
                    return BadRequest(new AuthResult() { Errors = new List<string>() { "Invalid payload" }, Result = false });

                //var isCorrect = await _userManager.CheckPasswordAsync(existing_user, loginRequest.Password);

                //if (!isCorrect)
                //    return BadRequest(new AuthResult() { Errors = new List<string>() { "Invalid credentials" }, Result = false });

                var jwtToken = GenerateJwtToken(loginRequest);

                return Ok(new AuthResult() { Token = jwtToken, Result = true });

            //return BadRequest(new AuthResult() { Errors = new List<string>() { "Invalid payload" }, Result = false });
        }

        private string GenerateJwtToken(UserLoginRequestDto user)
        {
            var jwtTokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();

            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("JwtConfig:Secret").Value);

            // Token descriptor
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim("Id", user.Id),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Email, value:user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.Now.ToUniversalTime().ToString())
            }),

                Expires = DateTime.Now.AddHours(24),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            return jwtTokenHandler.WriteToken(token);
        }

    }

    //public interface IJwtTokenGenerator
    //{
    //    string GenerateToken(Guid Id, string firstName, string lastName, string email);
    //}

    //public class JwtTokenGenerator : IJwtTokenGenerator
    //{
    //    public string GenerateToken(Guid Id, string firstName, string lastName, string email)
    //    {
    //        return "";
    //    }
    //}
}
