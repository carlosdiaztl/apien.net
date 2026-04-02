using usuarios.Models;
using usuarios.usuarios.repository;

namespace usuarios.usuarios.application
{
    public class UsuariosUseCase
    {
        private readonly UsuarioRepository usuarioRepository;
        public UsuariosUseCase(UsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }
        public async Task <User> Create(UserCreate usuario)
        {
            var newUser = new User
            {
                Name = usuario.Name,
                Email = usuario.Email,
                Password = usuario.Password,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            usuarioRepository.Create(newUser);
            return newUser;
        }
    }
}
