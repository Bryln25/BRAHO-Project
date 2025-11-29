using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRAHO_Project.Login;
using BRAHO_Project.RJControls;

namespace BRAHO_Project
{
    public partial class FrmProcesados : Form
    {     


        private List<Usuario> listaUsuarios;
        private List<Usuario> listaUsuariosOriginal = new List<Usuario>();
        private Usuario usuarioLog;
        public FrmProcesados(Usuario usuarioLogueado)
        {
            InitializeComponent();
            ConfigurarDataGridView();
            MostrarUsuarios();
            usuarioLog = usuarioLogueado;
        }

        public DataGridView dgv
        {
            get { return dgvProcesados; }
        }

        private void ConfigurarDataGridView()
        {
            dgvProcesados.EnableHeadersVisualStyles = false;
            dgvProcesados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvProcesados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProcesados.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dgvProcesados.GridColor = Color.Silver;
            dgvProcesados.RowHeadersVisible = false;
            dgvProcesados.BorderStyle = BorderStyle.FixedSingle;
            dgvProcesados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProcesados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Crear columnas para tus datos de clientes
            dgvProcesados.Columns.Clear();

            DataGridViewTextBoxColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.Name = "Usuario";
            colUsuario.HeaderText = "USUARIO";
            colUsuario.FillWeight = 20;

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "NOMBRE";
            colNombre.FillWeight = 20;

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "Email";
            colEmail.HeaderText = "EMAIL";
            colEmail.FillWeight = 20;

            DataGridViewTextBoxColumn colRol = new DataGridViewTextBoxColumn();
            colRol.Name = "Rol";
            colRol.HeaderText = "ROL";
            colRol.FillWeight = 18;


            // Columnas de botones (usaremos imágenes)
            DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
            colEditar.Name = "Editar";
            colEditar.HeaderText = "";
            colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEditar.FillWeight = 8;

            DataGridViewImageColumn colEliminar = new DataGridViewImageColumn();
            colEliminar.Name = "Eliminar";
            colEliminar.HeaderText = "";
            colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEliminar.FillWeight = 8;

            // Agregar todas las columnas
            dgvProcesados.Columns.AddRange(new DataGridViewColumn[] {
                colUsuario, colNombre, colEmail, colRol,
                colEditar, colEliminar
            });
        }


        public void MostrarUsuarios()
        {
            listaUsuarios = UsuarioDAL.MostrarProcesados();

            if (listaUsuarios != null)
            {
                listaUsuariosOriginal = new List<Usuario>(listaUsuarios);
            }
            else
            {
                listaUsuariosOriginal = new List<Usuario>();
            }

            ActualizarDataGridView();
        }

        public void FiltarDataGridView(string filtro)
        {
            listaUsuarios = UsuarioDAL.MostrarProcesados();
            if (listaUsuarios != null)
            {
                listaUsuariosOriginal = new List<Usuario>(listaUsuarios);
            }
            else
            {
                listaUsuariosOriginal = new List<Usuario>();
            }

            if (string.IsNullOrEmpty(filtro))
            {
                listaUsuarios = new List<Usuario>(listaUsuariosOriginal);
            }

            else
            {
                listaUsuarios = listaUsuariosOriginal.Where(c =>
                    (c.Usuarioo?.ToLower() ?? "").Contains(filtro) ||
                    (c.Nombre?.ToLower() ?? "").Contains(filtro) ||
                    (c.Email?.ToLower() ?? "").Contains(filtro) ||
                    (c.Puesto?.ToLower() ?? "").Contains(filtro)
                ).ToList();
            }

            ActualizarDataGridView();
        }


        public void ActualizarDataGridView()
        {
            dgvProcesados.Rows.Clear();

            foreach (var usuario in listaUsuarios)
            {
                int rowIndex = dgvProcesados.Rows.Add(
                    usuario.Usuarioo,
                    usuario.Nombre,
                    usuario.Email,
                    usuario.Puesto
                );

                // Asignar imágenes a las columnas de botones
                if (dgvProcesados.Rows[rowIndex].Cells["Editar"] is DataGridViewImageCell editarCell)
                {
                    dgvProcesados.Cursor = Cursors.Hand;
                    editarCell.Value = Properties.Resources.editar; // Tu imagen de editar
                    editarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                if (dgvProcesados.Rows[rowIndex].Cells["Eliminar"] is DataGridViewImageCell eliminarCell)
                {
                    dgvProcesados.Cursor = Cursors.Hand;
                    eliminarCell.Value = Properties.Resources.cerrar; // Tu imagen de eliminar
                    eliminarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }

        private void dgvUsuariosAgendadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var usuario = listaUsuarios[e.RowIndex];

                switch (dgvProcesados.Columns[e.ColumnIndex].Name)
                {
                    case "Editar":
                        if (usuarioLog.IdUsuario != usuario.IdUsuario) // valida que haya fila seleccionada
                        {
                            DataGridViewRow fila = dgvProcesados.CurrentRow;

                            // Crear el formulario destino

                            FrmEditarUsuario frm = new FrmEditarUsuario(usuario, dgvProcesados, usuarioLog);
                            frm.ShowDialog();
                            MostrarUsuarios(); // Refrescar la lista después de editar
                        }
                        else
                        {
                            MessageBox.Show("No puedes editarte a ti mismo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case "Eliminar":
                        if (usuarioLog.IdUsuario != usuario.IdUsuario) // valida que haya fila seleccionada
                        {
                            if (MessageBox.Show($"¿Está seguro que desea eliminar este usuario?",
                            "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // Eliminar de la base de datos
                                int resultado = UsuarioDAL.EliminarUsuario(usuario.IdUsuario);

                                if (resultado > 0)
                                {
                                    MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error al eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                listaUsuarios.RemoveAt(e.RowIndex);
                                ActualizarDataGridView();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No puedes eliminarte a ti mismo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }                        
                        break;
                }
            }
        }

        private void dgvUsuariosAgendadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                if (dgv.Columns[e.ColumnIndex].Name == "Estado")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                    string texto = e.Value?.ToString() ?? "";
                    Color colorFondo = Color.FromArgb(255, 213, 46);

                    // Crear badge redondeado
                    int padding = 8;
                    Size textSize = TextRenderer.MeasureText(texto, e.CellStyle.Font);
                    int badgeWidth = textSize.Width + padding * 2;
                    int badgeHeight = textSize.Height + 4;

                    Rectangle badgeRect = new Rectangle(
                        e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2,
                        e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2,
                        badgeWidth,
                        badgeHeight
                    );

                    using (GraphicsPath path = Funciones.GetRoundedRectangle(badgeRect, 12))
                    {
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        using (Brush brush = new SolidBrush(colorFondo))
                        {
                            e.Graphics.FillPath(brush, path);
                        }
                    }

                    TextRenderer.DrawText(e.Graphics, texto,
                        new Font("Segoe UI", 8, FontStyle.Bold),
                        badgeRect, Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;
                }
            }
        }
    }
}
