using _01_Aplicacion.DTO;
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

        public void ejecutar(UsuarioDTO usuario)
        {
            this.repositorio.grabar(new Usuario(usuario.Id(), usuario.Nombre(), usuario.Email(), usuario.Edad()));
        }

    }
}