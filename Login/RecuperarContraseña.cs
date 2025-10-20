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

        private void EnviarCorreo(string destino, string contrasena, string usuario)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient servidor = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("braylinnunez72@gmail.com", "BRAHO Project");
                mail.To.Add(destino);
                mail.Subject = "Recuperación de contraseña";

                string html = @"
                <h2>Recuperación de contraseña de <b>BRAHO Project</b></h2>
                <p>Tu usuario es: <b>" + usuario + @"</b></p>
                <p>Tu contraseña es: <b>" + contrasena + @"</b></p>
                <br/>
                <img src='https://images.leadconnectorhq.com/image/f_webp/q_80/r_1200/u_https://assets.cdn.filesafe.space/oAoRhPLqEQ4Tvh6z5D9L/media/66dc7d98ab806e4461387ba4.png' width='200'/>
                ";

                mail.Body = html;
                mail.IsBodyHtml = true; // ✅ MUY IMPORTANTE

                servidor.Port = 587;
                servidor.Credentials = new NetworkCredential("braylinnunez72@gmail.com", "gatz zyty ktxr peti");
                servidor.EnableSsl = true;

                servidor.Send(mail);

                MessageBox.Show("Se envió la contraseña al correo registrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form iniciodesesion = new IniciodeSesion();
                iniciodesesion.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void BotonEnviarCodigo_Click(object sender, EventArgs e)
        {
            string email = txtRecuperarcion.Texts.Trim();

            var (usuario, contrasena) = ObtenerUsuarioYContrasenaPorCorreo(email);

            if (contrasena != null)
            {
                //string hash = Funciones.HashPassword(contrasena);
                EnviarCorreo(email, contrasena, usuario);
            }
            else
            {
                MessageBox.Show("El correo no está registrado en el sistema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
