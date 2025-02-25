using InsightLoop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsightLoop.AuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;
        public AuthController(UserService userService)
        {
            _userService = userService;
        }

    }
}
