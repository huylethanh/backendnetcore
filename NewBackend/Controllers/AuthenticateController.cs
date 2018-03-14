using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NewBackend.ViewModels;

namespace NewBackend.Controllers
{
    [AllowAnonymous]
    [Route("api/")]
    public class AuthenticateController : Controller
    {
        private IConfiguration configuration;
        public AuthenticateController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IActionResult Post()
        {
            var authorizationHeader = Request.Headers["Authorization"].First();
            var key = authorizationHeader.Split(" ")[1];
            var credential = Encoding.UTF8.GetString(Convert.FromBase64String(key)).Split(':');

            return BadRequest();
        }

        [HttpPost("Token")]
        public IActionResult Token([FromBody]LoginViewModel login)
        {
            if (login.UserName == "huyle" && login.Password == "123456")
            {
                var claims = new List<Claim>()
                {
                   new Claim(ClaimTypes.Name, login.UserName),
                   new Claim("staff","")
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["JWT:ServerSecret"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(issuer: "yourdomain.com", audience: "yourdomain.com", claims: claims, expires: DateTime.Now.AddMinutes(30), signingCredentials: creds);

                return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            };

            return BadRequest("Could not verify username and password");
        }

        [HttpGet("Test")]
        public IActionResult Test()
        {
            return Ok(DateTime.Now);
        }
    }
}