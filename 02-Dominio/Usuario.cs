using _02_Dominio.ValueObject;
using System.Text.RegularExpressions;

namespace _02_Dominio
{
    public class Usuario
    {
        private Nombre nombre;
        private Email email;
        private EdadMayor edad;

        public Usuario(
            String nombre,
            String email,
            int edad
        )
        {
            this.nombre = new Nombre(nombre);
            this.email = new Email(email); ;
            this.edad = new EdadMayor(edad);
        }

        public void cambiarNombre(String nuevoNombre)
        {
            this.nombre = new Nombre(nuevoNombre);
        }
        
    }
}