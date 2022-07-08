using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EventManagement.API.Models
{
    public static class TestToken
    {
        public static string Get(IConfiguration configuration)
        {
            var tokenSettings = configuration.GetSection("JwtTokenSettings").Get<TokenSettings>();

            var testUser = configuration.GetSection("TestUser").Get<TestUser>();

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, testUser.Sub),
                new Claim(JwtRegisteredClaimNames.Email, testUser.Email)
            };

            var secretBytes = Encoding.UTF8.GetBytes(tokenSettings.JwtSecretKey);

            var key = new SymmetricSecurityKey(secretBytes);

            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: tokenSettings.JwtIssuer,
                audience: tokenSettings.JwtAudience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: signingCredentials);

            var value = new JwtSecurityTokenHandler().WriteToken(token);

            return value;
        }
    }
}