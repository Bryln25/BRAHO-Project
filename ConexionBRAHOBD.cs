using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public class ConexionBRAHOBD
    {
        public class ConexionCOALogin
        {
            public static SqlConnection ObtenerConexion()
            {
                SqlConnection conexion = new SqlConnection(
                    @"Data Source=25.39.110.125,1433;Initial Catalog=BrahoDB;User ID=user1;Password=12345;Encrypt=False"
                );

                try
                {
                    conexion.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }

                return conexion;
            }
        }

    }
}
