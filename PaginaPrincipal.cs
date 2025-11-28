using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using BRAHO_Project.Auditoria;
using BRAHO_Project.RJControls;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public partial class PaginaPrincipal : Form
    {
        private Usuario usuario;
        bool desplazar = false;
        bool menuExpandido = true;
        private Button botonActivo = null;


        public PaginaPrincipal(Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            Funciones.RedondearForm(this);
            usuario = usuarioLogueado;

            if (usuario.Puesto == "Administrador" || usuario.Puesto == "TI")
            {
                btnControlUsuarios.Visible = true;
                label8.Visible = true;
            }
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            // Cargar la foto de perfil desde la base de datos
            if (usuario.Foto != null && usuario.Foto.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(usuario.Foto))
                {
                    logouser.Image = Image.FromStream(ms);
                }
            }
            Funciones.RedondearImagen(logouser);

            // Mostrar la información del usuario
            lblNombre.Text = $"Bienvenido, {usuario.Nombre}";
            lblPuesto.Text = $"Rol: {usuario.Puesto}";
            lblEmail.Text = $"Email: {usuario.Email}";

            AuditoriaDAL auditoria = new AuditoriaDAL(usuario);
            auditoria.RAuditoria("Inicio de Sesión", $"El usuario {usuario.Nombre} ha iniciado sesión.");
        }

        //Codigo para mover el formulario
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

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
            abrirformhijo(new FrmClientes());

            if (!desplazar)
            {
                timer1.Start();
                desplazar = true;
            }

            ActivarBoton(BotonClientes);
        }

        private void BotonRegistrarObra_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmObras());

            if (!desplazar)
            {
                timer1.Start();
                desplazar = true;
            }

            ActivarBoton(BotonRegistrarObra);
        }


        private void BotonVentas_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmGastos());

            if (!desplazar)
            {
                timer1.Start();
                desplazar = true;
            }

            ActivarBoton(BotonGastos);
        }

        private void btnControlUsuarios_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmUsuarios(usuario));

            if (!desplazar)
            {
                timer1.Start();
                desplazar = true;
            }

            ActivarBoton(btnControlUsuarios);
        }

        private void logouser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Desea cambiar la foto de perfil?", "Confirmar Cambiar Foto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] fotoBytes = File.ReadAllBytes(ofd.FileName);

                string query = "UPDATE Usuarios SET FotoPerfil = @foto WHERE IdUsuario = @id";
                using (SqlConnection cn = ConexionBRAHOBD.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@foto", fotoBytes);
                    cmd.Parameters.AddWithValue("@id", usuario.IdUsuario);
                    cmd.ExecuteNonQuery();
                }

                // Mostrar en PictureBox
                using (MemoryStream ms = new MemoryStream(fotoBytes))
                {
                    logouser.Image = Image.FromStream(ms);
                }
            }

            Funciones.RedondearImagen(logouser);
        }

        private void ActivarBoton(Button boton)
        {
            if (botonActivo != null && botonActivo != boton)
            {
                DesactivarPropiedades(botonActivo);
            }
            ActivarPropiedades(boton);
            botonActivo = boton;
        }

        private void ActivarPropiedades(Button boton)
        {
            boton.BackColor = Color.FromArgb(102, 102, 102);
        }

        private void DesactivarPropiedades(Button boton)
        {
            boton.BackColor = Color.FromArgb(127, 127, 127);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmAuditoria());

            if (!desplazar)
            {
                timer1.Start();
                desplazar = true;
            }

            ActivarBoton(BotonGastos);
        }
    }
}
