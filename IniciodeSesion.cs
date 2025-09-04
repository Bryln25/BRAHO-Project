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
            Form registrarse = new Registrarse();
            registrarse.Show();
            this.Hide();



        }

        private void logueo()
        {

            try
            {
                using (SqlConnection cn = ConexionBRAHOBD.ConexionCOALogin.ObtenerConexion())
                {
                    string query = "SELECT Usuario, Contraseña FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña";

                    SqlCommand cm = new SqlCommand(query, cn);
                    cm.Parameters.AddWithValue("@usuario", txtUsuario.Texts.Trim());
                    cm.Parameters.AddWithValue("@contraseña", txtContraseña.Texts.Trim());

                    SqlDataReader dr = cm.ExecuteReader();

                    if (dr.Read())
                    {
                        PaginaPrincipal m = new PaginaPrincipal();
                        this.Hide();
                        m.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecta");
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
    }
}
