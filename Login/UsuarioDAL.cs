using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project.Login
{
    public class UsuarioDAL
    {
        public static List<Usuario> MostrarNuevo()
        {
            List<Usuario> Lista = new List<Usuario>();
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT IdUsuario, Usuario, NombreApellido, Rol, Email FROM Usuarios WHERE Rol = 'Sin Rol'";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = reader.GetInt32(0);
                    usuario.UsuarioNombre = reader.GetString(1);
                    usuario.Nombre = reader.GetString(2);
                    usuario.Puesto = reader.GetString(3);
                    usuario.Email = reader.GetString(4);
                    Lista.Add(usuario);
                }

                conexion.Close();
                return Lista;
            }
        }

        public static List<Usuario> MostrarProcesados()
        {
            List<Usuario> Lista = new List<Usuario>();
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT IdUsuario, Usuario, NombreApellido, Rol, Email FROM Usuarios WHERE Rol != 'Sin Rol'";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = reader.GetInt32(0);
                    usuario.UsuarioNombre = reader.GetString(1);
                    usuario.Nombre = reader.GetString(2);
                    usuario.Puesto = reader.GetString(3);
                    usuario.Email = reader.GetString(4);
                    Lista.Add(usuario);
                }

                conexion.Close();
                return Lista;
            }
        }

        public static int EditarUsuario(Usuario usuario)
        {
            try
            {
                int retorna = 0;
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "UPDATE Usuarios SET Usuario = @Usuario, NombreApellido = @NombreApellido, Rol = @Rol, Email = @Email WHERE IdUsuario = @IdUsuario";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                    comando.Parameters.AddWithValue("@Usuario", usuario.UsuarioNombre);
                    comando.Parameters.AddWithValue("@NombreApellido", usuario.Nombre);
                    comando.Parameters.AddWithValue("@Rol", usuario.Puesto);
                    comando.Parameters.AddWithValue("@Email", usuario.Email);
                    retorna = comando.ExecuteNonQuery();
                }

                return retorna;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la base de datos");
                return 0;
            }
        }

        public static int EliminarUsuario(int Id)
        {
            try
            {
                int retorna = 0;
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@IdUsuario", Id);
                    retorna = comando.ExecuteNonQuery();
                }
                return retorna;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la base de datos");
                return 0;
            }
        }
        
    }
}
