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
using static BRAHO_Project.ConexionBRAHOBD;

namespace BRAHO_Project
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        //Codigo para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        private void MoverVentanaRegistrarse_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Registrarse_Load(object sender, EventArgs e)
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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form iniciodesesion = new IniciodeSesion();
            iniciodesesion.Show();
            this.Close();
        }

        private void BotonCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                int retorna = 0;

                using (SqlConnection conexion = ConexionCOALogin.ObtenerConexion())
                {
                    string query = "INSERT INTO Usuarios (Usuario, NombreApellido, Contraseña, Email) " +
                                   "VALUES (@Usuario, @NombreApellido, @Contraseña, @Email)";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@Usuario", txtUsuario.Texts.Trim());
                    comando.Parameters.AddWithValue("@NombreApellido", txtnombreapellido.Texts.Trim());
                    comando.Parameters.AddWithValue("@Contraseña", txtcontraseña.Texts.Trim()); // ahora string
                    comando.Parameters.AddWithValue("@Email", txtcorreo.Texts.Trim());

                    // Ejecutar la inserción
                    retorna = comando.ExecuteNonQuery();
                }

                if (retorna > 0)
                {
                    MessageBox.Show("✅ Usuario registrado correctamente.");
                    Form iniciodesesion = new IniciodeSesion();
                    iniciodesesion.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("❌ No se insertó el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la base de datos");
            }

        }
    }
}
