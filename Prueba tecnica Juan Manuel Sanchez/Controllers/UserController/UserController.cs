using Microsoft.AspNetCore.Mvc;
using Prueba_tecnica_Juan_Manuel_Sanchez.Models.UserModel;
using Prueba_tecnica_Juan_Manuel_Sanchez.Services.UserServices;

namespace Prueba_tecnica_Juan_Manuel_Sanchez.Controllers
{
    [Route("prueba/juan")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserModel userModel)
        {
            var createdUser = await _userService.CreateUserAsync(userModel);
            return Ok( new {message = $"Bienvenido {userModel.Name}a nuestra aplicacion."});
        }
    }
}
