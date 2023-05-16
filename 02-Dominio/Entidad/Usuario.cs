using _02_Dominio.ValueObject;
using System.Text.RegularExpressions;

namespace _02_Dominio
{
    public class Usuario
    {
        private Identificador id;
        private Nombre nombre;
        private Email email;
        private EdadMayor edad;


        public Usuario(
            Guid id,
            String nombre,
            String email,
            int edad
        )
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.email = new Email(email);
            this.edad = new EdadMayor(edad);
        }

        public void cambiarNombre(String nuevoNombre)
        {
            this.nombre = new Nombre(nuevoNombre);
        }

        public String presentacion()
        {
            return "Mi nombre es " + this.nombre.Valor() + ", mi email " + this.email.Valor() + " y mi edad " + this.edad.Valor() + " (" + this.id.Valor() + ")";
        }
        
    }
}