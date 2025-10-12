using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public class ObrasDAL
    {
        public static int AgregarObra(Obras obras)
        {
            try
            {
                int retorna = 0;

                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "INSERT INTO Obras (IDCliente, NombreObra, TipoObra, Ubicacion, MetrosCuadrados, Presupuesto, FechaInicio, FechaFinal, Recordatorio, Estado) " +
                                   "VALUES (@IDCliente, @NombreObra, @TipoObra, @Ubicacion, @MetrosCuadrados, @Presupuesto, @FechaInicio, @FechaFinal, @Recordatorio, @Estado)";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@IDCliente", obras.IDCliente);
                    comando.Parameters.AddWithValue("@NombreObra", obras.NombreObra);
                    comando.Parameters.AddWithValue("@TipoObra", obras.TipoObra);
                    comando.Parameters.AddWithValue("@Ubicacion", obras.Ubicacion);
                    comando.Parameters.AddWithValue("@MetrosCuadrados", obras.MetrosCuadrados);
                    comando.Parameters.AddWithValue("@Presupuesto", obras.Presupuesto);
                    comando.Parameters.AddWithValue("@FechaInicio", obras.FechaInicio);
                    comando.Parameters.AddWithValue("@FechaFinal", obras.FechaFinal);                    
                    comando.Parameters.AddWithValue("@Recordatorio", obras.Recordatorio);
                    comando.Parameters.AddWithValue("@Estado", obras.Estado);

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

        public static List<Obras> MostrarAgendado()
        {
            List<Obras> Lista = new List<Obras>();
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT *FROM Obras WHERE Estado = 'Agendado'";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Obras obras = new Obras();
                    obras.IdObra = reader.GetInt32(0);
                    obras.IDCliente = reader.GetInt32(1);
                    obras.NombreObra = reader.GetString(2);
                    obras.TipoObra = reader.GetString(3);
                    obras.Ubicacion = reader.GetString(4);
                    obras.MetrosCuadrados = reader.GetString(5);
                    obras.Presupuesto = reader.GetString(6);
                    obras.FechaInicio = reader.GetString(7);
                    obras.FechaFinal = reader.GetString(8);
                    obras.Recordatorio = reader.GetString(9);
                    obras.Estado = reader.GetString(10);
                    Lista.Add(obras);
                }

                conexion.Close();
                return Lista;

            }


        }

        public static List<Obras> MostrarIniciado()
        {
            List<Obras> Lista = new List<Obras>();
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT *FROM Obras WHERE Estado = 'Iniciado'";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Obras obras = new Obras();
                    obras.IdObra = reader.GetInt32(0);
                    obras.IDCliente = reader.GetInt32(1);
                    obras.NombreObra = reader.GetString(2);
                    obras.TipoObra = reader.GetString(3);
                    obras.Ubicacion = reader.GetString(4);
                    obras.MetrosCuadrados = reader.GetString(5);
                    obras.Presupuesto = reader.GetString(6);
                    obras.FechaInicio = reader.GetString(7);
                    obras.FechaFinal = reader.GetString(8);
                    obras.Recordatorio = reader.GetString(9);
                    obras.Estado = reader.GetString(10);
                    Lista.Add(obras);
                }

                conexion.Close();
                return Lista;

            }


        }

        public static List<Obras> MostrarTerminado()
        {
            List<Obras> Lista = new List<Obras>();
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT *FROM Obras WHERE Estado = 'Terminado'";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Obras obras = new Obras();
                    obras.IdObra = reader.GetInt32(0);
                    obras.IDCliente = reader.GetInt32(1);
                    obras.NombreObra = reader.GetString(2);
                    obras.TipoObra = reader.GetString(3);
                    obras.Ubicacion = reader.GetString(4);
                    obras.MetrosCuadrados = reader.GetString(5);
                    obras.Presupuesto = reader.GetString(6);
                    obras.FechaInicio = reader.GetString(7);
                    obras.FechaFinal = reader.GetString(8);
                    obras.Recordatorio = reader.GetString(9);
                    obras.Estado = reader.GetString(10);
                    Lista.Add(obras);
                }

                conexion.Close();
                return Lista;

            }


        }

        public static int EditarObras(Obras obras)
        {
            try
            {
                int retorna = 0;
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "UPDATE Obras SET IDCliente = @IDCliente, NombreObra = @NombreObra, TipoObra = @TipoObra, Ubicacion = @Ubicacion, MetrosCuadrados = @MetrosCuadrados, Presupuesto = @Presupuesto, FechaInicio = @FechaInicio, FechaFinal = @FechaFinal, Recordatorio = @Recordatorio, Estado = @Estado WHERE IdObra = @IdObra";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@IDCliente", obras.IDCliente);
                    comando.Parameters.AddWithValue("@NombreObra", obras.NombreObra);
                    comando.Parameters.AddWithValue("@IdObra", obras.IdObra);
                    comando.Parameters.AddWithValue("@TipoObra", obras.TipoObra);
                    comando.Parameters.AddWithValue("@Ubicacion", obras.Ubicacion);
                    comando.Parameters.AddWithValue("@MetrosCuadrados", obras.MetrosCuadrados);
                    comando.Parameters.AddWithValue("@Presupuesto", obras.Presupuesto);
                    comando.Parameters.AddWithValue("@FechaInicio", obras.FechaInicio);
                    comando.Parameters.AddWithValue("@FechaFinal", obras.FechaFinal);
                    comando.Parameters.AddWithValue("@Recordatorio", obras.Recordatorio);
                    comando.Parameters.AddWithValue("@Estado", obras.Estado);
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

        public static int EliminarObra(int Id)
        {
            try
            {
                int retorna = 0;
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "DELETE FROM Obras WHERE IdObra = @IdObra";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@IdObra", Id);
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

        public static DataTable CargarClientes()
        {
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                DataTable tb = new DataTable();
                try
                {
                    string consulta = "SELECT IDCliente, NombreApellido FROM Clientes";

                    SqlCommand cmd = new SqlCommand(consulta, conexion);
                    SqlDataReader reader = cmd.ExecuteReader();

                    tb.Load(reader);

                    return tb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }

                return tb;
            }
        }
    }
}
