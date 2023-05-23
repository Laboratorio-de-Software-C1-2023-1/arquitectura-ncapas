using _01_Aplicacion.DTO;
using _02_Dominio;
using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class ObtenerUsuarios
    {
        private UsuarioRepositorio repositorio;

        public ObtenerUsuarios(UsuarioRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<UsuarioDTO> ejecutar()
        {
            List<Usuario> usuarios = this.repositorio.obtenerTodos();
            List<UsuarioDTO> usuariosDTO = new List<UsuarioDTO>();
            foreach (Usuario usuario in usuarios)
            {
                UsuarioDTO usuarioDTO = new UsuarioDTO(usuario.Id(), usuario.Nombre(), usuario.Email(), usuario.Edad());
                usuariosDTO.Add(usuarioDTO);
            }
            return usuariosDTO;
        }
    }
}
