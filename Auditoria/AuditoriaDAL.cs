using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project.Auditoria
{
    public class AuditoriaDAL
    {
        private Usuario usuario;

        public AuditoriaDAL(Usuario usuarioLogueado)
        {
            usuario = usuarioLogueado;

        }
        public static List<Log> MostrarLog()
        {
            List<Log> Lista = new List<Log>();
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT *FROM Auditoria ORDER BY Fecha DESC";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Log log = new Log();
                    log.IdAuditoria = reader.GetInt32(0);
                    log.Usuario = reader.GetString(1);
                    log.Accion = reader.GetString(2);
                    log.Detalle = reader.GetString(3);
                    log.Fecha = reader.GetDateTime(4).ToString();
                    log.Equipo = reader.GetString(5);
                    Lista.Add(log);
                }

                conexion.Close();
                return Lista;

            }

        }



        public void RAuditoria(string accion, string detalle)
        {
            using (SqlConnection cn = ConexionBRAHOBD.ObtenerConexion())
            {

                string query = @"INSERT INTO Auditoria (Usuario, Accion, Detalle, Fecha, Equipo)
                             VALUES (@Usuario, @Accion, @Detalle, @Fecha, @Equipo)";


                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario.Usuarioo);
                    cmd.Parameters.AddWithValue("@Accion", accion);
                    cmd.Parameters.AddWithValue("@Detalle", detalle);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Equipo", Dns.GetHostName());
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
