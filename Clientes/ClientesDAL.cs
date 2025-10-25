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

        public static List<Clientes> Mostrar()
        {
            List<Clientes> Lista = new List<Clientes>();
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT *FROM Clientes";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Clientes clientes = new Clientes();
                    clientes.IDCliente = reader.GetInt32(0);
                    clientes.NombreApellido = reader.GetString(1);
                    clientes.Telefono = reader.GetString(2);
                    clientes.Email = reader.GetString(3);
                    clientes.Direccion = reader.GetString(4);
                    clientes.Cedula = reader.GetString(5);
                    Lista.Add(clientes);
                }

                conexion.Close();
                return Lista;

            }

            
        }

        public static int EditarClientes(Clientes cliente)
        {
            try
            {
                int retorna = 0;
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "UPDATE Clientes SET NombreApellido = @NombreApellido, Telefono = @Telefono, Email = @Email, Direccion = @Direccion, Cedula = @Cedula WHERE IDCliente = @IDCliente";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    
                    comando.Parameters.AddWithValue("@IDCliente", cliente.IDCliente); 
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

        public static int EliminarCliente(int Id)
        {
            try
            {
                int retorna = 0;
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "DELETE FROM Clientes WHERE IdCliente = @Id";
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
