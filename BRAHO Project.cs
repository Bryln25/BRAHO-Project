using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace BRAHO_Project
{
    public partial class PaginaPrincipal : Form
    {
        private Usuario usuario;

        public PaginaPrincipal(Usuario usuarioLogueado)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
        }


        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            lblNombre.Text = $"Bienvenido, {usuario.Nombre}";
            lblPuesto.Text = $"Rol: {usuario.Puesto}";
            lblEmail.Text = $"Email: {usuario.Email}";

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

        //Codigo para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        bool menuExpandido = true;

        private void BotonSlide_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }


        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMininizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                // Reducir el ancho hasta llegar a 65
                MenuVertical.Width -= 6;
                if (MenuVertical.Width <= 65)
                {
                    menuExpandido = false;
                    logouser.Visible = false;
                    lblNombre.Visible = false;
                    lblPuesto.Visible = false;
                    lblEmail.Visible = false;
                    pictureBox3.Visible = false;
                    timer1.Stop();
                }
            }
            else
            {
                // Aumentar el ancho hasta llegar a 260
                MenuVertical.Width += 6;
                if (MenuVertical.Width >= 260)
                {
                    menuExpandido = true;
                    menuExpandido = true;
                    logouser.Visible = true;
                    lblNombre.Visible = true;
                    lblPuesto.Visible = true;
                    lblEmail.Visible = true;
                    pictureBox3.Visible = true;
                    timer1.Stop();
                }
            }
        }

        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
