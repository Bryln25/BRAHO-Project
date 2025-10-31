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
    public partial class FrmCambiarContrasena : Form
    {
        string email;
        public FrmCambiarContrasena(string email)
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

        private void BtnVerContraseña1_Click(object sender, EventArgs e)
        {
            if (txtNuevaContraseña.PasswordChar)
            {
                // Mostrar la contraseña
                txtNuevaContraseña.PasswordChar = false;
                BtnVerContraseña1.Image = Properties.Resources.hide; // Cambia a imagen de ojo cerrado
            }
            else
            {
                // Ocultar la contraseña
                txtNuevaContraseña.PasswordChar = true;
                BtnVerContraseña1.Image = Properties.Resources.visible; // Cambia a imagen de ojo abierto
            }
        }

        private void BtnVerContraseña2_Click(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.PasswordChar)
            {
                // Mostrar la contraseña
                txtConfirmarContraseña.PasswordChar = false;
                BtnVerContraseña2.Image = Properties.Resources.hide; // Cambia a imagen de ojo cerrado
            }
            else
            {
                // Ocultar la contraseña
                txtConfirmarContraseña.PasswordChar = true;
                BtnVerContraseña2.Image = Properties.Resources.visible; // Cambia a imagen de ojo abierto
            }
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            // Validar que las contraseñas coincidan
            if (txtNuevaContraseña.Texts.Trim() != txtConfirmarContraseña.Texts.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNuevaContraseña.Texts = string.Empty;
                txtConfirmarContraseña.Texts = string.Empty;
                txtNuevaContraseña.Focus();

                return;
            }

            string nuevaContrasena = txtNuevaContraseña.Texts.Trim();
            string hash = Funciones.HashPassword(nuevaContrasena);

            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "UPDATE Usuarios SET Contraseña = @Contrasena WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Contrasena", hash);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
              
            }

            MessageBox.Show("Contraseña actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            Form iniciodesesion = new IniciodeSesion();
            iniciodesesion.Show();
            this.Close();
        }
    }
}
