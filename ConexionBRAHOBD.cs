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
        public static SqlConnection ObtenerConexion()
        {
            //SqlConnection conexion = new SqlConnection(
            //    @"Data Source=25.39.110.125,1433;Initial Catalog=BrahoDB;User ID=user1;Password=12345;Encrypt=False;"
            //);

            SqlConnection conexion = new SqlConnection(
               @"workstation id=BrahoDB.mssql.somee.com;packet size=4096;user id=AndrewsH_SQLLogin_1;pwd=6k2wgo4tjq;data source=BrahoDB.mssql.somee.com;persist security info=False;initial catalog=BrahoDB;TrustServerCertificate=True;"
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
