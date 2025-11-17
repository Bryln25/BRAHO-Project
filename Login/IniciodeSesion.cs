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
using System.Windows.Forms;
using BRAHO_Project.RJControls;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public partial class IniciodeSesion : Form
    {
        public IniciodeSesion()
        {
            InitializeComponent();
            Funciones.RedondearForm(this);
        }

        //Codigo para mover el formulario

        private void MoverVentanaInicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMininizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BotonRegistrarse_Click(object sender, EventArgs e)
        {
            Form FrmAdmin = new FrmAdmin();
            FrmAdmin.Show();
            this.Hide();
        }

        private void logueo()
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrEmpty(txtUsuario.Texts) || string.IsNullOrEmpty(txtContraseña.Texts))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string hash = Funciones.HashPassword(txtContraseña.Texts.Trim());

            try
            {
                using (SqlConnection cn = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "SELECT IdUsuario, NombreApellido, Email, Rol, FotoPerfil FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña AND Rol != 'Sin Rol'";

                    SqlCommand cm = new SqlCommand(query, cn);
                    cm.Parameters.AddWithValue("@usuario", txtUsuario.Texts.Trim());
                    cm.Parameters.AddWithValue("@contraseña", hash);

                    SqlDataReader dr = cm.ExecuteReader();

                    if (dr.Read())
                    {
                        int id = Convert.ToInt32(dr["IdUsuario"]);
                        string nombre = dr["NombreApellido"].ToString();
                        string puesto = dr["Rol"].ToString();
                        string email = dr["Email"].ToString();
                        byte[] fotoBytes = dr["FotoPerfil"] as byte[];

                        Usuario usuarioLogueado = new Usuario(id, nombre, puesto, email, fotoBytes);

                        PaginaPrincipal m = new PaginaPrincipal(usuarioLogueado);
                        this.Hide();
                        txtUsuario.Texts = string.Empty;
                        txtContraseña.Texts = string.Empty;
                        m.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtUsuario.Texts = string.Empty;
                        txtContraseña.Texts = string.Empty;
                        txtUsuario.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void BotonLoguear_Click(object sender, EventArgs e)
        {
            logueo();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form recuperar = new RecuperarContraseña();
            recuperar.Show();
            this.Hide();
        }

        // Mostrar u ocultar la contraseña al hacer clic en el botón
        private void BtnVerContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar)
            {
                // Mostrar la contraseña
                txtContraseña.PasswordChar = false;
                BtnVerContraseña.Image = Properties.Resources.hide; // Cambia a imagen de ojo cerrado
            }
            else
            {
                // Ocultar la contraseña
                txtContraseña.PasswordChar = true;
                BtnVerContraseña.Image = Properties.Resources.visible; // Cambia a imagen de ojo abierto
            }
        }
    }
}
