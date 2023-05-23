using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion.DTO
{
    public class UsuarioDTO
    {
        private Guid id;
        private String nombre;
        private String email;
        private int edad;

        public UsuarioDTO(Guid id, String nombre, String email, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.edad = edad;
        }

        public Guid Id()
        {
            return this.id;
        }
        public String Nombre()
        {
            return this.nombre;
        }
        public String Email()
        {
            return this.email;
        }
        public int Edad()
        {
            return this.edad;
        }

        public String presentacion()
        {
            return "Mi nombre es " + this.nombre + ", mi email " + this.email + " y mi edad " + this.edad + " (" + this.id + ")";
        }
    }
}
