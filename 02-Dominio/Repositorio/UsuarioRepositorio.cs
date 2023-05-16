using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Repositorio
{
    public interface UsuarioRepositorio
    {
        public List<Usuario> obtenerTodos();
        public void grabar(Usuario usuario);
    }
}
