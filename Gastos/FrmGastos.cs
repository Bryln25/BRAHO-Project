using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRAHO_Project.Auditoria;
using Microsoft.Data.SqlClient;
using SpreadsheetLight;
using Excel = DocumentFormat.OpenXml.Spreadsheet;

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
            string fechaInicio = dtpFechaInicio.Value.ToString("dd/MM/yyyy");
            string fechaFinal = dtpFechaFinal.Value.ToString("dd/MM/yyyy");

            listaGastos = GastosDAL.MostrarGastosPorRango(fechaInicio, fechaFinal) ?? new List<Gastos>();

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

            decimal sumaMontos = CalcularSumaMontos();
            lblTotalMontos.Text = $"Total: {sumaMontos:C}";
            ExportarExcel(dgvBuscar, $"Registros_Gastos_{fechaInicio}_a_{fechaFinal}", sumaMontos);
        }

        private decimal CalcularSumaMontos()
        {
            decimal sumaMontos = 0m;
            foreach (DataGridViewRow row in dgvBuscar.Rows)
            {
                if (row.IsNewRow) continue;
                var montoCell = row.Cells["Monto"].Value;
                if (montoCell != null)
                {
                    string montoStr = montoCell.ToString().Replace("RD$", "").Replace(",", "").Trim();
                    if (decimal.TryParse(montoStr, out decimal monto))
                    {
                        sumaMontos += monto;
                    }
                }
            }
            return sumaMontos;
        }

        private static string filePath = AppDomain.CurrentDomain.BaseDirectory;
        private static string folderPath = @$"{filePath}\Exportaciones";

        public static void ExportarExcel(DataGridView dgvBuscar, string name, decimal sumaMontos)
        {
            if (dgvBuscar.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string nombreSeguro = name.Replace("/", "-").Replace("\\", "-").Replace(":", "-");
            string fileName = $"{nombreSeguro}.xlsx";
            string filePath = Path.Combine(folderPath, fileName);

            try
            {
                SLDocument sl = new SLDocument();

                // Solo exportar las primeras columnas con información (no imágenes)
                int columnasExportar = dgvBuscar.Columns.Count - 3;

                sl.SetCellValue(1, 1, $"{name}");
                sl.MergeWorksheetCells(1, 1, 1, columnasExportar);
                sl.SetCellStyle(1, 1, GetTitleStyle());

                for (int i = 0; i < columnasExportar; i++)
                {
                    sl.SetCellValue(3, i + 1, dgvBuscar.Columns[i].HeaderText);
                    sl.SetCellStyle(3, i + 1, GetHeaderStyle());
                }

                for (int row = 0; row < dgvBuscar.Rows.Count; row++)
                {
                    for (int col = 0; col < columnasExportar; col++)
                    {
                        sl.SetCellValue(row + 4, col + 1, dgvBuscar.Rows[row].Cells[col].Value?.ToString());
                        sl.SetCellStyle(row + 4, col + 1, GetDataStyle());
                    }
                }

                // Fila Total
                int totalRow = dgvBuscar.Rows.Count + 4;
                sl.SetCellValue(totalRow, 1, "Total");
                sl.SetCellStyle(totalRow, 1, GetHeaderStyle());
                // Dejar celdas vacías hasta la columna de Monto
                for (int col = 1; col < columnasExportar - 1; col++)
                {
                    sl.SetCellValue(totalRow, col + 1, "");
                    sl.SetCellStyle(totalRow, col + 1, GetDataStyle());
                }
                // Colocar suma de montos en la columna de Monto
                sl.SetCellValue(totalRow, columnasExportar - 1, $"RD$ {sumaMontos:N2}");
                sl.SetCellStyle(totalRow, columnasExportar - 1, GetDataStyle());

                // Ajustar solo las columnas exportadas
                for (int col = 0; col < columnasExportar; col++)
                {
                    double maxColumnWidth = 0;
                    double headerWidth = CalcularAnchoTexto(dgvBuscar.Columns[col].HeaderText);
                    maxColumnWidth = Math.Max(maxColumnWidth, headerWidth);

                    for (int row = 0; row < dgvBuscar.Rows.Count; row++)
                    {
                        string cellValue = dgvBuscar.Rows[row].Cells[col].Value?.ToString();
                        double cellWidth = CalcularAnchoTexto(cellValue);
                        maxColumnWidth = Math.Max(maxColumnWidth, cellWidth);
                    }

                    // Considerar ancho de la fila Total
                    if (col == 0)
                    {
                        maxColumnWidth = Math.Max(maxColumnWidth, CalcularAnchoTexto("Total"));
                    }
                    if (col == columnasExportar - 1)
                    {
                        maxColumnWidth = Math.Max(maxColumnWidth, CalcularAnchoTexto(sumaMontos.ToString("C")));
                    }

                    sl.SetColumnWidth(col + 1, maxColumnWidth);
                }

                SLStyle borderStyle = new SLStyle();
                borderStyle.SetBottomBorder(Excel.BorderStyleValues.Thin, SLThemeColorIndexValues.Dark1Color);
                for (int row = 3; row <= dgvBuscar.Rows.Count + 4; row++)
                {
                    for (int col = 1; col <= columnasExportar; col++)
                    {
                        sl.SetCellStyle(row, col, borderStyle);
                    }
                }

                sl.SaveAs(filePath);

                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static SLStyle GetTitleStyle()
        {
            SLStyle style = new SLStyle();
            style.Font.FontName = "Arial";
            style.Font.FontSize = 16;
            style.Font.Bold = true;
            style.Alignment.Horizontal = Excel.HorizontalAlignmentValues.Center;
            style.Alignment.Vertical = Excel.VerticalAlignmentValues.Center;
            return style;
        }

        private static SLStyle GetHeaderStyle()
        {
            SLStyle style = new SLStyle();
            style.Font.FontName = "Century Gothic";
            style.Font.FontSize = 12;
            style.Font.Bold = true;
            style.Fill.SetPattern(Excel.PatternValues.Solid, System.Drawing.Color.LightGray, System.Drawing.Color.Gray);
            style.Alignment.Horizontal = Excel.HorizontalAlignmentValues.Center;
            style.Alignment.Vertical = Excel.VerticalAlignmentValues.Center;
            return style;
        }

        private static SLStyle GetDataStyle()
        {
            SLStyle style = new SLStyle();
            style.Font.FontName = "Century Gothic";
            style.Font.FontSize = 11;
            return style;
        }

        private static void AjustarAnchoColumnas(SLDocument sl, DataGridView dgvBuscar)
        {
            for (int col = 0; col < dgvBuscar.Columns.Count; col++)
            {
                double maxColumnWidth = 0;

                double headerWidth = CalcularAnchoTexto(dgvBuscar.Columns[col].HeaderText);
                maxColumnWidth = Math.Max(maxColumnWidth, headerWidth);

                for (int row = 0; row < dgvBuscar.Rows.Count; row++)
                {
                    string cellValue = dgvBuscar.Rows[row].Cells[col].Value?.ToString();
                    double cellWidth = CalcularAnchoTexto(cellValue);
                    maxColumnWidth = Math.Max(maxColumnWidth, cellWidth);
                }

                sl.SetColumnWidth(col + 1, maxColumnWidth);
            }
        }

        private static double CalcularAnchoTexto(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return 0;
            }
            return texto.Length * 1.5;
        }
    }
}
