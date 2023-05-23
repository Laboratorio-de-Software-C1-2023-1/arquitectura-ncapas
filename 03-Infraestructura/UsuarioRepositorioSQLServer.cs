using _02_Dominio;
using _02_Dominio.Repositorio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
    public class UsuarioRepositorioSQLServer : UsuarioRepositorio
    {
        String connectionString = "Data Source=DESKTOP-3B107HD\\SQLEXPRESS;Initial Catalog=arquitecturaNCapas;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public void grabar(Usuario usuario)
        {
            using (SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("INSERT INTO usuarios (id, nombre, email, edad) VALUES (@id, @nombre, @email, @edad)", conexion))
                {
                    comando.Parameters.Add("@id", System.Data.SqlDbType.UniqueIdentifier).Value = usuario.Id();
                    comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = usuario.Nombre();
                    comando.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = usuario.Email();
                    comando.Parameters.Add("@edad", System.Data.SqlDbType.Int).Value = usuario.Edad();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Usuario> obtenerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection conexion = new SqlConnection(this.connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand("SELECT id, nombre, email, edad FROM usuarios", conexion))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Guid id = reader.GetGuid(0);
                            String nombre = reader.GetString(1);
                            String email = reader.GetString(2);
                            int edad = reader.GetInt32(3);
                            Usuario usuario = new Usuario(id, nombre, email, edad);
                            usuarios.Add(usuario);
                        }
                    }
                }
            }

            return usuarios;
        }
    }
}
