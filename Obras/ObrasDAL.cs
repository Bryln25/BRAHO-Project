using System;
using System.Collections.Generic;
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
                    string query = "INSERT INTO Obras (TipoObra, AlcanceObra, Ubicacion, MetrosCuadrados, Presupuesto, FechaInicio, FechaFinal, Recordatorio, Estado) " +
                                   "VALUES (@TipoObra, @AlcanceObra, @Ubicacion, @MetrosCuadrados, @Presupuesto, @FechaInicio, @FechaFinal, @Recordatorio, @Estado)";

                    SqlCommand comando = new SqlCommand(query, conexion);


                    comando.Parameters.AddWithValue("@TipoObra", obras.TipoObra);
                    comando.Parameters.AddWithValue("@AlcanceObra", obras.AlcanceObra);
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

        public static List<Obras> Mostrar()
        {
            List<Obras> Lista = new List<Obras>();
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT *FROM Obras";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Obras obras = new Obras();
                    obras.IdObra = reader.GetInt32(0);
                    obras.TipoObra = reader.GetString(1);
                    obras.AlcanceObra = reader.GetString(2);
                    obras.Ubicacion = reader.GetString(3);
                    obras.MetrosCuadrados = reader.GetString(4);
                    obras.Presupuesto = reader.GetString(5);
                    obras.FechaInicio = reader.GetString(6);
                    obras.FechaFinal = reader.GetString(7);
                    obras.Recordatorio = reader.GetString(8);
                    obras.Estado = reader.GetString(9);
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
                    string query = "UPDATE Obras SET TipoObra = @TipoObra, AlcanceObra = @AlcanceObra, Ubicacion = @Ubicacion, MetrosCuadrados = @MetrosCuadrados, Presupuesto = @Presupuesto, FechaInicio = @FechaInicio, FechaFinal = @FechaFinal, Recordatorio = @Recordatorio, Estado = @Estado WHERE IdObra = @IdObra";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@IdObra", obras.IdObra);
                    comando.Parameters.AddWithValue("@TipoObra", obras.TipoObra);
                    comando.Parameters.AddWithValue("@AlcanceObra", obras.AlcanceObra);
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
