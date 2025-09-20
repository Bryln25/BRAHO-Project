using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace BRAHO_Project
{
    public partial class PaginaPrincipal : Form
    {
        private FrmClientes frmClientes;
        private Usuario usuario;
        bool desplazar = false;

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

            frmClientes = new FrmClientes();
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
            desplazar = !desplazar;
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

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
            //lblHora.Left = (this.ClientSize.Width - lblHora.Width) / 2;
            //lblFecha.Left = (this.ClientSize.Width - lblFecha.Width) / 2;
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private Form formularioactivo = null;
        private void abrirformhijo(Form formulariohijo)
        {
            if (formularioactivo != null)
                formularioactivo.Close();
            formularioactivo = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.FormBorderStyle = FormBorderStyle.None;
            formulariohijo.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(formulariohijo);
            Contenedor.Tag = formulariohijo;
            formulariohijo.BringToFront();
            formulariohijo.Show();
        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {
            abrirformhijo(frmClientes);

            if (!desplazar)
            {
                timer1.Start();
                desplazar = true;
            }
        }

        private void BotonRegistrarObra_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmObras());

            if (!desplazar)
            {
                timer1.Start();
                desplazar = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
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

        }
    }
}
