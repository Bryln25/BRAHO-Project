using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using static BRAHO_Project.ConexionBRAHOBD;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public partial class FrmVerificarCodigo : Form
    {
        string email;
        public FrmVerificarCodigo(string email)
        {
            InitializeComponent();
            Funciones.RedondearForm(this);
            this.email = email;
        }

        //Codigo para mover el formulario
        private void MoverVentanaRecuperarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Form iniciodesesion = new IniciodeSesion();
            iniciodesesion.Show();
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form iniciodesesion = new IniciodeSesion();
            iniciodesesion.Show();
            this.Close();
        }

        private void BotonEnviarCodigo_Click(object sender, EventArgs e)
        {
            string codigoIngresado = txtRecuperarcion.Texts.Trim();

            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT *FROM CodigosRecuperacion WHERE Email = @Email AND Codigo = @Codigo AND FechaExpiracion > GETDATE()";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Codigo", codigoIngresado);


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Código válido
                    MessageBox.Show("Código verificado correctamente. Ahora puedes cambiar tu contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form cambiar = new FrmCambiarContrasena(email);
                    cambiar.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Código incorrecto o expirado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
