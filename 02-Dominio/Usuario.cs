namespace _02_Dominio
{
    public class Usuario
    {
        private String nombre;
        private String email;
        private int edad;

        public Usuario(
            String nombre,
            String email,
            int edad
        )
        {

            if (this.nombre.Length < 4)
            {
                throw new Exception("El nombre debe contener, al menos, 4 caractreres");
            }

            if (this.edad < 18)
            {
                throw new Exception("El usuario debe ser mayor a 18 años");
            }

            this.nombre = nombre;
            this.email = email;
            this.edad = edad;
        }
    }
}