using EventManagement.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        #region Fields

        private readonly IConfiguration _configuration;

        #endregion

        #region Constructors

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        #endregion

        #region Methods

        [HttpGet]
        [Route("[action]")]
        public string GetSecret()
        {
            return TestToken.Get(_configuration);
        }

        #endregion
    }
}