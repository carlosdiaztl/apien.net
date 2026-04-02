using Microsoft.AspNetCore.Mvc;
using usuarios.Models;
using usuarios.usuarios.application;
using usuarios.usuarios.repository;

namespace usuarios.usuarios.infrastructure
{
    [ApiController]
    [Route("[controller]")]
    public class UserCtrl : ControllerBase
    {
        private readonly UsuariosUseCase _usuariosUseCase;
        public UserCtrl(UsuariosUseCase usuariosUseCase)
        {
            this._usuariosUseCase = usuariosUseCase;
        }

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
