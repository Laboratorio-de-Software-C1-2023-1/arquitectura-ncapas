using _02_Dominio;
using _02_Dominio.Repositorio;

namespace _03_Infraestructura
{
    public class UsuarioRepositorioEnMemoria : UsuarioRepositorio
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void grabar(Usuario usuario)
        {
            this.usuarios.Add(usuario);
        }

        public List<Usuario> obtenerTodos()
        {
            return this.usuarios;
        }
    }
}