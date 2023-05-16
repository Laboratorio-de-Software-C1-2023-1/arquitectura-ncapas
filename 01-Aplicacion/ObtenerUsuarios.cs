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

        public List<Usuario> ejecutar()
        {
            return this.repositorio.obtenerTodos();
        }
    }
}
