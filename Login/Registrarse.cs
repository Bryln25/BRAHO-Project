using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;

namespace BRAHO_Project
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
            Funciones.RedondearForm(this);
        }

        //Codigo para mover el formulario
        private void MoverVentanaRegistrarse_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void BotonCerrarRegistrarse_Click(object sender, EventArgs e)
        {
            Form iniciodesesion = new IniciodeSesion();
            iniciodesesion.Show();
            this.Close();
        }

        private void BotonMinimizarRegistrarse_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form iniciodesesion = new IniciodeSesion();
            iniciodesesion.Show();
            this.Close();
        }

        private void BotonCrearCuenta_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrEmpty(txtUsuario.Texts) || string.IsNullOrEmpty(txtContraseña.Texts) ||
                string.IsNullOrEmpty(txtNombreApellido.Texts) || string.IsNullOrEmpty(txtCorreo.Texts))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que las contraseñas coincidan
            if (txtContraseña.Texts.Trim() != txtConfirmarContraseña.Texts.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContraseña.Texts = string.Empty;
                txtConfirmarContraseña.Texts = string.Empty;
                txtContraseña.Focus();
                return;
            }

            // Verificar si el nombre de usuario ya existe en la base de datos
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@usuario", txtUsuario.Texts.Trim());

                int resultado = Convert.ToInt32(comando.ExecuteScalar());
                if (resultado == 1)
                {
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Texts = string.Empty;
                    txtUsuario.Focus();
                    return;
                }
            }

            // Verificar si el correo electrónico ya existe en la base de datos
            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM usuarios WHERE email = @Email";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Email", txtCorreo.Texts.Trim());
                int resultado = Convert.ToInt32(comando.ExecuteScalar());
                if (resultado == 1)
                {
                    MessageBox.Show("El correo electrónico ya está registrado. Por favor, utilice otro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCorreo.Texts = string.Empty;
                    txtCorreo.Focus();
                    return;
                }
            }

            try
            {
                int retorna = 0;
                //string hash = Funciones.HashPassword(txtContraseña.Texts.Trim());

                using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "INSERT INTO Usuarios (Usuario, NombreApellido, Contraseña, Email) " +
                                   "VALUES (@Usuario, @NombreApellido, @Contraseña, @Email)";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@Usuario", txtUsuario.Texts.Trim());
                    comando.Parameters.AddWithValue("@NombreApellido", txtNombreApellido.Texts.Trim());
                    comando.Parameters.AddWithValue("@Contraseña", txtContraseña.Texts.Trim());
                    comando.Parameters.AddWithValue("@Email", txtCorreo.Texts.Trim());

                    // Ejecutar la inserción
                    retorna = comando.ExecuteNonQuery();
                }

                if (retorna > 0)
                {
                    MessageBox.Show("Usuario registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form iniciodesesion = new IniciodeSesion();
                    iniciodesesion.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        // Códigos para mostrar y ocultar la contraseña
        private void BtnVerContraseña1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar)
            {
                // Mostrar la contraseña
                txtContraseña.PasswordChar = false;
                BtnVerContraseña1.Image = Properties.Resources.hide; // Cambia a imagen de ojo cerrado
            }
            else
            {
                // Ocultar la contraseña
                txtContraseña.PasswordChar = true;
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
    }
}
