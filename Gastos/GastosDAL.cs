using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public class GastosDAL
    {
        public static int AgregarGasto(Gastos Gastos)
        {
            try
            {
                int retorna = 0;

                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "INSERT INTO GastosObra (IdObra, Fecha, Descripcion, TipoGasto, Monto) " +
                                   "VALUES (@IdObra, @Fecha, @Descripcion, @TipoGasto, @Monto)";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@IdObra", Gastos.IdObra);
                    comando.Parameters.AddWithValue("@Fecha", Gastos.Fecha);
                    comando.Parameters.AddWithValue("@Descripcion", Gastos.Descripcion);
                    comando.Parameters.AddWithValue("@TipoGasto", Gastos.TipoGasto);
                    comando.Parameters.AddWithValue("@Monto", Gastos.Monto);

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

        public static List<Gastos> MostrarGastos()
        {
            List<Gastos> Lista = new List<Gastos>();
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT *FROM GastosObra";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Gastos Gastos = new Gastos();
                    Gastos.IdGasto = reader.GetInt32(0);
                    Gastos.IdObra = reader.GetInt32(1);
                    Gastos.Fecha = reader.GetString(2);
                    Gastos.Descripcion = reader.GetString(3);
                    Gastos.TipoGasto = reader.GetString(4);
                    Gastos.Monto = reader.GetString(5);
                    Lista.Add(Gastos);
                }

                conexion.Close();
                return Lista;

            }

        }
        public static int EditarGasto(Gastos Gastos)
        {
            try
            {
                int retorna = 0;
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "UPDATE GastosObra SET IdObra = @IdObra, Fecha = @Fecha, Descripcion = @Descripcion, TipoGasto = @TipoGasto, Monto = @Monto WHERE IdGasto = @IdGasto";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@IdGasto", Gastos.IdGasto);
                    comando.Parameters.AddWithValue("@Fecha", Gastos.Fecha);
                    comando.Parameters.AddWithValue("@IdObra", Gastos.IdObra);
                    comando.Parameters.AddWithValue("@Descripcion", Gastos.Descripcion);
                    comando.Parameters.AddWithValue("@TipoGasto", Gastos.TipoGasto);
                    comando.Parameters.AddWithValue("@Monto", Gastos.Monto);
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

        public static int EliminarGasto(int Id)
        {
            try
            {
                int retorna = 0;
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "DELETE FROM GastosObra WHERE IdGasto = @IdGasto";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@IdGasto", Id);
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

        public static DataTable CargarObras()
        {
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                DataTable tb = new DataTable();
                try
                {
                    string consulta = "SELECT IdObra, NombreObra FROM Obras";

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

        public static string BuscarNombreObraPorId(int idObra)
        {
            string nombreObra = string.Empty;
            try
            {
                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "SELECT NombreObra FROM Obras WHERE IdObra = @IdObra";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@IdObra", idObra);
                    object resultado = comando.ExecuteScalar();
                    if (resultado != null)
                    {
                        nombreObra = resultado.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la base de datos");
            }
            return nombreObra;
        }
    }
}
