using Microsoft.AspNetCore.Mvc;
using usuarios.Models;
using usuarios.usuarios.application;
using usuarios.usuarios.repository;

namespace usuarios.usuarios.infrastructure
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UsuariosUseCase _usuariosUseCase;
        public UserController(UsuariosUseCase usuariosUseCase)
        {
            this._usuariosUseCase = usuariosUseCase;
        }

        [HttpPost(Name = "users")]
        public async Task<IActionResult> UserCreate(UserCreate user)
        {
            try 
            {
                var newUser = await _usuariosUseCase.Create(user);
                return Ok(newUser);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
