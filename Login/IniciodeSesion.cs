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
        }

        //Codigo para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMininizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MoverVentanaInicioSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IniciodeSesion_Load(object sender, EventArgs e)
        {
            int radio = 30; // Ajusta el nivel de redondeado
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();

                // Esquinas redondeadas
                path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
                path.AddArc(new Rectangle(this.Width - radio, 0, radio, radio), 270, 90);
                path.AddArc(new Rectangle(this.Width - radio, this.Height - radio, radio, radio), 0, 90);
                path.AddArc(new Rectangle(0, this.Height - radio, radio, radio), 90, 90);

                path.CloseFigure();
                this.Region = new Region(path);
            }


        }

        private void BotonRegistrarse_Click(object sender, EventArgs e)
        {
            Form FrmAdmin = new FrmAdmin();
            FrmAdmin.Show();
            this.Hide();

            //Form registrarse = new Registrarse();
            //registrarse.Show();
            //
        }

        private void logueo()
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrEmpty(txtUsuario.Texts) || string.IsNullOrEmpty(txtContraseña.Texts))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (SqlConnection cn = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "SELECT IdUsuario, NombreApellido, Email, Rol, FotoPerfil FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña";

                    SqlCommand cm = new SqlCommand(query, cn);
                    cm.Parameters.AddWithValue("@usuario", txtUsuario.Texts.Trim());
                    cm.Parameters.AddWithValue("@contraseña", txtContraseña.Texts.Trim());

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
