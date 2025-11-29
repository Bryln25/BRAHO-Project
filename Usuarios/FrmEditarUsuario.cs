using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRAHO_Project.Auditoria;
using BRAHO_Project.Login;
using BRAHO_Project.RJControls;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BRAHO_Project
{
    public partial class FrmEditarUsuario : Form
    {
        Usuario usuario = new Usuario();
        private DataGridView dgvBuscar;
        private Usuario usuarioLogueado;
        string viejoUsuario;
        string viejoNombre;
        string viejoEmail;
        string viejoPuesto;

        public FrmEditarUsuario(Usuario usuario, DataGridView dataGridView, Usuario UsuarioLogueado)
        {
            InitializeComponent();
            Funciones.RedondearForm(this);
            usuarioLogueado = UsuarioLogueado;

            this.usuario = usuario;
            txtUsuario.Texts = usuario.Usuarioo;
            txtNombre.Texts = usuario.Nombre;
            cbRol.Texts = usuario.Puesto;
            txtEmail.Texts = usuario.Email;

            viejoUsuario = usuario.Usuarioo;
            viejoNombre = usuario.Nombre;
            viejoEmail = usuario.Email;
            viejoPuesto = usuario.Puesto;
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT FotoPerfil FROM Usuarios WHERE Usuario = @usuario";

                SqlCommand cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@usuario", usuario.Usuarioo);

                SqlDataReader dr = cm.ExecuteReader();

                if (dr.Read())
                {
                    usuario.Foto = dr["FotoPerfil"] as byte[];
                }
                else
                {
                    MessageBox.Show("Error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (usuario.Foto != null && usuario.Foto.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(usuario.Foto))
                {
                    logouser.Image = Image.FromStream(ms);
                }
            }
            Funciones.RedondearImagen(logouser);
        }

        // Codigo para mover el formulario
        private void FrmAgregarUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Texts) || string.IsNullOrEmpty(cbRol.Texts) ||
                string.IsNullOrEmpty(txtEmail.Texts) || string.IsNullOrEmpty(txtNombre.Texts))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Valores nuevos
            string nuevoUsuario = txtUsuario.Texts.Trim();
            string nuevoNombre = txtNombre.Texts.Trim();
            string nuevoEmail = txtEmail.Texts.Trim();
            string nuevoPuesto = cbRol.Texts.Trim();

            // Valores viejos del usuario cargado originalmente
            string viejoUsuario = this.usuario.Usuarioo;
            string viejoNombre = this.usuario.Nombre;
            string viejoEmail = this.usuario.Email;
            string viejoPuesto = this.usuario.Puesto;

            // Comparaciones CORRECTAS
            bool cambioUsuario = viejoUsuario != nuevoUsuario;
            bool cambioNombre = viejoNombre != nuevoNombre;
            bool cambioEmail = viejoEmail != nuevoEmail;
            bool cambioPuesto = viejoPuesto != nuevoPuesto;

            Usuario usuario = new Usuario();
            usuario.IdUsuario = this.usuario.IdUsuario;
            usuario.Usuarioo = nuevoUsuario;
            usuario.Nombre = nuevoNombre;
            usuario.Email = nuevoEmail;
            usuario.Puesto = nuevoPuesto;

            int resultado = UsuarioDAL.EditarUsuario(usuario);

            if (resultado > 0)
            {
                AuditoriaDAL auditoria = new AuditoriaDAL(usuarioLogueado);

                if (cambioUsuario)
                {
                    string detalle = $"{usuarioLogueado.Nombre}, editó el usuario de {usuario.Usuarioo} de {viejoUsuario} a {nuevoUsuario}";
                    auditoria.RAuditoria("Modificar", detalle);
                }

                if (cambioNombre)
                {
                    string detalle = $"{usuarioLogueado.Nombre}, editó el nombre de {usuario.Usuarioo} de {viejoNombre} a {nuevoNombre}";
                    auditoria.RAuditoria("Modificar", detalle);
                }

                if (cambioEmail)
                {
                    string detalle = $"{usuarioLogueado.Nombre}, editó el email de {usuario.Usuarioo} de {viejoEmail} a {nuevoEmail}";
                    auditoria.RAuditoria("Modificar", detalle);
                }

                if (cambioPuesto)
                {
                    string detalle = $"{usuarioLogueado.Nombre}, editó el puesto de {usuario.Usuarioo} de {viejoPuesto} a {nuevoPuesto}";
                    auditoria.RAuditoria("Modificar", detalle);
                }

                MessageBox.Show("Usuario modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al editar el Usuario. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
