using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public class ClientesDAL
    {
        public static int AgregarClientes(Clientes cliente)
        {
            try
            {
                int retorna = 0;

                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "INSERT INTO Clientes (NombreApellido, Telefono, Email, Direccion, Cedula) " +
                                   "VALUES (@NombreApellido, @Telefono, @Email, @Direccion, @Cedula)";

                    SqlCommand comando = new SqlCommand(query, conexion);


                    comando.Parameters.AddWithValue("@NombreApellido", cliente.NombreApellido);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@Email", cliente.Email);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    comando.Parameters.AddWithValue("@Cedula", cliente.Cedula);


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

        public static DataTable Mostrar()
        {
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT NombreApellido, Telefono, Email, Direccion, Cedula FROM Clientes", conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        public static int EditarClientes(Clientes cliente)
        {
            try
            {
                int retorna = 0;
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "UPDATE Clientes SET NombreApellido = @NombreApellido, Telefono = @Telefono, Email = @Email, Direccion = @Direccion WHERE Cedula = @Cedula";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@NombreApellido", cliente.NombreApellido);
                    comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    comando.Parameters.AddWithValue("@Email", cliente.Email);
                    comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    comando.Parameters.AddWithValue("@Cedula", cliente.Cedula);
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

        public static int EliminarClientes(string Id)
        {
            try
            {
                int retorna = 0;
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "DELETE FROM Clientes WHERE IdClientes = @Id";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Id", Id);
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
