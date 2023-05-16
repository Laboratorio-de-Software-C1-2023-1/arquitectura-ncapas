using _02_Dominio;
using _02_Dominio.Repositorio;

namespace _01_Aplicacion
{
    public class CrearUsuarios
    {
        private UsuarioRepositorio repositorio;

        public CrearUsuarios(UsuarioRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(Usuario usuario)
        {
            this.repositorio.grabar(usuario);
        }

    }
}