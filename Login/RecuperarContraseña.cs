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
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
            Funciones.RedondearForm(this);
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

        private (string Usuario, string Contrasena) ObtenerUsuarioYContrasenaPorCorreo(string email)
        {
            string usuario = null;
            string contrasena = null;

            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT Usuario, Contraseña FROM Usuarios WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Email", email);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = reader["Usuario"]?.ToString();
                        contrasena = reader["Contraseña"]?.ToString();
                    }
                }
            }

            return (usuario, contrasena);
        }

        private string GenerarCodigoRecuperacion(string email)
        {
            Random random = new Random();
            string codigo = random.Next(100000, 999999).ToString(); // 6 dígitos
            DateTime expiracion = DateTime.Now.AddMinutes(10); // válido por 10 minutos

            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = @"INSERT INTO CodigosRecuperacion (Email, Codigo, FechaExpiracion)
                         VALUES (@Email, @Codigo, @FechaExpiracion)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@FechaExpiracion", expiracion);
                cmd.ExecuteNonQuery();
            }

            return codigo;
        }

        private void EnviarCorreoCodigo(string destino, string codigo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient servidor = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("braylinnunez72@gmail.com", "BRAHO Project");
                mail.To.Add(destino);
                mail.Subject = "Código de recuperación de contraseña";

                string html = @"
        <h2>Recuperación de contraseña de <b>BRAHO Project</b></h2>
        <p>Tu código de verificación es:</p>
        <h1 style='color: #007bff;'>" + codigo + @"</h1>
        <p>Este código expirará en 10 minutos.</p>
        <br/>
        <img src='https://images.leadconnectorhq.com/image/f_webp/q_80/r_1200/u_https://assets.cdn.filesafe.space/oAoRhPLqEQ4Tvh6z5D9L/media/66dc7d98ab806e4461387ba4.png' width='200'/>
        ";

                mail.Body = html;
                mail.IsBodyHtml = true;

                servidor.Port = 587;
                servidor.Credentials = new NetworkCredential("braylinnunez72@gmail.com", "gatz zyty ktxr peti");
                servidor.EnableSsl = true;

                servidor.Send(mail);

                MessageBox.Show("Se envió el código de recuperación al correo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void BotonEnviarCodigo_Click(object sender, EventArgs e)
        {
            string email = txtRecuperarcion.Texts.Trim();

            var (usuario, _) = ObtenerUsuarioYContrasenaPorCorreo(email);

            if (usuario != null)
            {
                string codigo = GenerarCodigoRecuperacion(email);
                EnviarCorreoCodigo(email, codigo);

                // Abre formulario para ingresar el código
                   Form ingresarCodigo = new FrmVerificarCodigo(email);
                   ingresarCodigo.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("El correo no está registrado en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
