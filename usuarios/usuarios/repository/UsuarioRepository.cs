using usuarios.Models;

namespace usuarios.usuarios.repository
{
    public class UsuarioRepository

    {
        private readonly CitytestContext _context;
    
            public UsuarioRepository(CitytestContext context)
            {
                _context = context;
            }
    
            public async Task Create(User usuario)
            {
               
    
                _context.Users.Add(usuario);
                await _context.SaveChangesAsync();
        }
    }
}
