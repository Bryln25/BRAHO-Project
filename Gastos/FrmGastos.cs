using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public partial class FrmGastos : Form
    {
        private List<Gastos> listaGastos;
        private List<Gastos> listaGastosOriginal = new List<Gastos>();

        public FrmGastos()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            MostrarGastos();
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
            listaGastos = GastosDAL.MostrarGastos();

            if (listaGastos != null)
            {
                listaGastosOriginal = new List<Gastos>(listaGastos);
            }
            else
            {
                listaGastosOriginal = new List<Gastos>();
            }

            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            dgvBuscar.Rows.Clear();

            foreach (var gastos in listaGastos)
            {
                int rowIndex = dgvBuscar.Rows.Add(
                    GastosDAL.ObtenerNombreObraPorId(gastos.IdObra),
                    gastos.Fecha,
                    gastos.TipoGasto,
                    gastos.Monto,
                    gastos.Descripcion
                );

                // Asignar imágenes a las columnas de botones
                if (dgvBuscar.Rows[rowIndex].Cells["Ver"] is DataGridViewImageCell verCell)
                {
                    dgvBuscar.Cursor = Cursors.Hand;
                    verCell.Value = Properties.Resources.visible; // Tu imagen de ver
                    verCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                if (dgvBuscar.Rows[rowIndex].Cells["Editar"] is DataGridViewImageCell editarCell)
                {
                    dgvBuscar.Cursor = Cursors.Hand;
                    editarCell.Value = Properties.Resources.editar; // Tu imagen de editar
                    editarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                if (dgvBuscar.Rows[rowIndex].Cells["Eliminar"] is DataGridViewImageCell eliminarCell)
                {
                    dgvBuscar.Cursor = Cursors.Hand;
                    eliminarCell.Value = Properties.Resources.cerrar; // Tu imagen de eliminar
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

                            FrmEditarGastos frm = new FrmEditarGastos(gastos, dgvBuscar);
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
            FrmAgregarGasto frmAgregarGasto = new FrmAgregarGasto();
            frmAgregarGasto.ShowDialog();
            MostrarGastos(); // Refrescar la lista después de agregar
        }

        private void dgvBuscar_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita encabezados
            {
                string columnName = dgvBuscar.Columns[e.ColumnIndex].Name;

                if (columnName == "Editar" || columnName == "Eliminar")
                {
                    dgvBuscar.Cursor = Cursors.Hand; // cambia a mano SOLO en esas celdas
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

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            string patron = txtBuscar.Texts.Trim().ToLower();
            listaGastos = new List<Gastos>();

            if (string.IsNullOrEmpty(patron))
            {
                listaGastos = new List<Gastos>(listaGastosOriginal);
            }
            else
            {
                foreach (var gastos in listaGastosOriginal)
                {

                    bool encontrado =
                        FuerzaBruta(GastosDAL.ObtenerNombreObraPorId(gastos.IdObra).ToLower(), patron) ||
                        FuerzaBruta(gastos.Fecha?.ToLower(), patron) ||
                        FuerzaBruta(gastos.TipoGasto?.ToLower().Replace(" ", "").Replace(")", ""), patron) ||
                        FuerzaBruta(gastos.Monto?.ToLower(), patron) ||
                        FuerzaBruta(gastos.Descripcion?.ToLower(), patron);                    
                    if (encontrado)
                        listaGastos.Add(gastos);
                }
            }

            ActualizarDataGridView();
        }

        private bool FuerzaBruta(string texto, string patron)
        {
            if (string.IsNullOrEmpty(texto) || string.IsNullOrEmpty(patron))
                return false;

            int n = texto.Length;
            int m = patron.Length;

            for (int i = 0; i <= n - m; i++)
            {
                int j;

                for (j = 0; j < m; j++)
                {
                    if (texto[i + j] != patron[j])
                        break;
                }

                if (j == m)
                    return true;
            }

            return false;
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

    }
}
