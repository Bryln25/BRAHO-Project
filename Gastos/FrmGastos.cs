using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRAHO_Project.Auditoria;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public partial class FrmGastos : Form
    {
        private List<Gastos> listaGastos;
        private List<Gastos> listaGastosOriginal = new List<Gastos>();
        private Usuario usuario;

        private Dictionary<int, string> obraCache = new Dictionary<int, string>();
        private System.Windows.Forms.Timer searchTimer;

        public FrmGastos(Usuario usuarioLogueado)
        {
            InitializeComponent();
            ConfigurarDataGridView();

            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 300;
            searchTimer.Tick += SearchTimer_Tick;

            MostrarGastos();
            usuario = usuarioLogueado;
        }

        private void ConfigurarDataGridView()
        {

            dgvBuscar.EnableHeadersVisualStyles = false;
            dgvBuscar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvBuscar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBuscar.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dgvBuscar.GridColor = Color.Silver;
            dgvBuscar.RowHeadersVisible = false;
            dgvBuscar.BorderStyle = BorderStyle.FixedSingle;
            dgvBuscar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Crear columnas para tus datos de clientes
            dgvBuscar.Columns.Clear();

            DataGridViewTextBoxColumn colObra = new DataGridViewTextBoxColumn();
            colObra.Name = "Obra";
            colObra.HeaderText = "OBRA";
            colObra.FillWeight = 20;

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.Name = "Fecha";
            colFecha.HeaderText = "FECHA";
            colFecha.FillWeight = 20;

            DataGridViewTextBoxColumn colTipo = new DataGridViewTextBoxColumn();
            colTipo.Name = "TipoGasto";
            colTipo.HeaderText = "TIPO GASTO";
            colTipo.FillWeight = 18;

            DataGridViewTextBoxColumn colMonto = new DataGridViewTextBoxColumn();
            colMonto.Name = "Monto";
            colMonto.HeaderText = "MONTO";
            colMonto.FillWeight = 20;

            DataGridViewTextBoxColumn colDescripcion = new DataGridViewTextBoxColumn();
            colDescripcion.Name = "Descripcion";
            colDescripcion.HeaderText = "DESCRIPCION";
            colDescripcion.FillWeight = 20;



            // Columnas de botones (usaremos imágenes)
            DataGridViewImageColumn colVer = new DataGridViewImageColumn();
            colVer.Name = "Ver";
            colVer.HeaderText = "";
            colVer.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colVer.FillWeight = 8;

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
            dgvBuscar.Columns.AddRange(new DataGridViewColumn[] {
                colObra, colFecha, colTipo, colMonto, colDescripcion,
                colVer, colEditar, colEliminar
            });
        }

        public void MostrarGastos()
        {
            listaGastos = GastosDAL.MostrarGastos() ?? new List<Gastos>();

            obraCache.Clear();
            foreach (var g in listaGastos)
            {
                if (!obraCache.ContainsKey(g.IdObra))
                {
                    obraCache[g.IdObra] = GastosDAL.ObtenerNombreObraPorId(g.IdObra) ?? string.Empty;
                }
            }

            listaGastosOriginal = new List<Gastos>(listaGastos);
            ActualizarDataGridView();
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();

            string patron = txtBuscar.Texts?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(patron))
            {
                listaGastos = new List<Gastos>(listaGastosOriginal);
                ActualizarDataGridView();
                return;
            }

            string patronLocal = patron;
            Task.Run(() =>
            {
                var res = new List<Gastos>();
                foreach (var g in listaGastosOriginal)
                {
                    obraCache.TryGetValue(g.IdObra, out var nombreObra);
                    nombreObra ??= string.Empty;

                    bool encontrado =
                        nombreObra.Contains(patronLocal, StringComparison.OrdinalIgnoreCase) ||
                        (g.Fecha?.Contains(patronLocal, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (g.TipoGasto?.Replace(" ", "").Replace(")", "").Contains(patronLocal, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (g.Monto?.Contains(patronLocal, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (g.Descripcion?.Contains(patronLocal, StringComparison.OrdinalIgnoreCase) ?? false);

                    if (encontrado) res.Add(g);
                }
                return res;
            }).ContinueWith(t =>
            {
                listaGastos = t.Result;
                ActualizarDataGridView();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void ActualizarDataGridView()
        {
            dgvBuscar.Rows.Clear();

            dgvBuscar.Cursor = Cursors.Default;

            foreach (var gastos in listaGastos)
            {
                int rowIndex = dgvBuscar.Rows.Add(
                    obraCache.TryGetValue(gastos.IdObra, out var nombre) ? nombre : string.Empty,
                    gastos.Fecha,
                    gastos.TipoGasto,
                    gastos.Monto,
                    gastos.Descripcion
                );

                if (dgvBuscar.Rows[rowIndex].Cells["Ver"] is DataGridViewImageCell verCell)
                {
                    verCell.Value = Properties.Resources.visible;
                    verCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                if (dgvBuscar.Rows[rowIndex].Cells["Editar"] is DataGridViewImageCell editarCell)
                {
                    editarCell.Value = Properties.Resources.editar;
                    editarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                if (dgvBuscar.Rows[rowIndex].Cells["Eliminar"] is DataGridViewImageCell eliminarCell)
                {
                    eliminarCell.Value = Properties.Resources.cerrar;
                    eliminarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var gastos = listaGastos[e.RowIndex];

                switch (dgvBuscar.Columns[e.ColumnIndex].Name)
                {
                    case "Ver":
                        if (dgvBuscar.CurrentRow != null)
                        {
                            DataGridViewRow fila = dgvBuscar.CurrentRow;

                            FrmVerGastos frm = new FrmVerGastos(gastos, dgvBuscar);
                            frm.ShowDialog();
                            MostrarGastos();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una fila antes de visualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case "Editar":
                        if (dgvBuscar.CurrentRow != null)
                        {
                            DataGridViewRow fila = dgvBuscar.CurrentRow;

                            FrmEditarGastos frm = new FrmEditarGastos(gastos, dgvBuscar, usuario);
                            Clientes clientes = new Clientes();
                            frm.ShowDialog();
                            MostrarGastos();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una fila antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                        break;

                    case "Eliminar":
                        if (MessageBox.Show($"¿Está seguro que desea eliminar el gasto?",
                            "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int resultado = GastosDAL.EliminarGasto(gastos.IdGasto);

                            if (resultado > 0)
                            {
                                MessageBox.Show("Gasto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                string detalle = $"El usuario {usuario.Nombre}, eliminó un gasto de la obra {GastosDAL.ObtenerNombreObraPorId(gastos.IdObra)}";
                                AuditoriaDAL auditoria = new AuditoriaDAL(usuario);
                                auditoria.RAuditoria("Eliminar", detalle);
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el gasto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            listaGastos.RemoveAt(e.RowIndex);
                            ActualizarDataGridView();
                        }
                        break;
                }
            }
        }

        private void BotonCerr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAgregarGastos_Click(object sender, EventArgs e)
        {
            FrmAgregarGasto frmAgregarGasto = new FrmAgregarGasto(usuario);
            frmAgregarGasto.ShowDialog();
            MostrarGastos();
        }

        private void dgvBuscar_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvBuscar.Columns[e.ColumnIndex].Name;

                if (columnName == "Editar" || columnName == "Eliminar")
                {
                    dgvBuscar.Cursor = Cursors.Hand;
                }
            }
        }

        private void dgvBuscar_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvBuscar.Columns[e.ColumnIndex].Name;

                if (columnName == "Editar" || columnName == "Eliminar")
                {
                    dgvBuscar.Cursor = Cursors.Default;
                }
            }
        }

        private bool barraExpandida = false;

        private void btnLupa_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (!barraExpandida)
            {
                txtBuscar.Focus();
            }
            else
            {
                txtBuscar.Texts = string.Empty;
                txtOculto.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barraExpandida)
            {
                txtBuscar.Width -= 20;
                if (txtBuscar.Width <= 0)
                {
                    txtBuscar.Width = 0;
                    txtBuscar.ActiveControl = null;
                    barraExpandida = false;
                    timer1.Stop();
                }
            }
            else
            {
                txtBuscar.Visible = true;
                txtBuscar.Width += 20;
                if (txtBuscar.Width >= 347)
                {
                    txtBuscar.Width = 347;
                    barraExpandida = true;
                    timer1.Stop();
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string mes = cbMes.Texts;
            string mesNumero = ObtenerNumeroMes(mes);

            string año = cbAño.Texts;
            txtBuscar.Texts = $"{mesNumero}/{año}";
        }

        public string ObtenerNumeroMes(string mes)
        {
            switch (mes.ToLower())
            {
                case "enero": return "01";
                case "febrero": return "02";
                case "marzo": return "03";
                case "abril": return "04";
                case "mayo": return "05";
                case "junio": return "06";
                case "julio": return "07";
                case "agosto": return "08";
                case "septiembre": return "09";
                case "octubre": return "10";
                case "noviembre": return "11";
                case "diciembre": return "12";

                default:
                    throw new ArgumentException("El nombre del mes no es válido.");
            }
        }
    }
}
