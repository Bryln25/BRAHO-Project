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
        public FrmEditarUsuario(Usuario usuario, DataGridView dataGridView)
        {
            InitializeComponent();
            Funciones.RedondearForm(this);
            this.usuario = usuario;

            txtUsuario.Texts = usuario.UsuarioNombre;
            txtNombre.Texts = usuario.Nombre;
            cbRol.Texts = usuario.Puesto;
            txtEmail.Texts = usuario.Email;
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = ConexionBRAHOBD.ObtenerConexion())
            {
                string query = "SELECT FotoPerfil FROM Usuarios WHERE Usuario = @usuario";

                SqlCommand cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@usuario", usuario.UsuarioNombre);

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
            if (string.IsNullOrEmpty(txtUsuario.Texts) || string.IsNullOrEmpty(cbRol.Texts) || string.IsNullOrEmpty(txtEmail.Texts) ||
               string.IsNullOrEmpty(txtNombre.Texts))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Usuario usuario = new Usuario();
            usuario.IdUsuario = this.usuario.IdUsuario;
            usuario.UsuarioNombre = txtUsuario.Texts.Trim();
            usuario.Nombre = txtNombre.Texts.Trim();
            usuario.Email = txtEmail.Texts.Trim();
            usuario.Puesto = cbRol.Texts.Trim();

            int resultado = UsuarioDAL.EditarUsuario(usuario);

            if (resultado > 0)
            {
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
