namespace EventManagement.API.Models
{
    internal class TokenSettings
    {
        public string JwtIssuer { get; set; }

        public string JwtAudience { get; set; }

        public string JwtSecretKey { get; set; }
    }
}