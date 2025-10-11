using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRAHO_Project.RJControls;

namespace BRAHO_Project
{
    public partial class FrmAgendado : Form
    {
        
        private List<Obras> listaObras;
        private List<Obras> listaObrasOriginal = new List<Obras>();

        public FrmAgendado()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            MostrarObras();
        }

        public DataGridView dgv
        {
            get { return dgvObrasAgendadas; }
        }

        private void ConfigurarDataGridView()
        {
            dgvObrasAgendadas.EnableHeadersVisualStyles = false;
            dgvObrasAgendadas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvObrasAgendadas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvObrasAgendadas.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dgvObrasAgendadas.GridColor = Color.Silver;
            dgvObrasAgendadas.RowHeadersVisible = false;
            dgvObrasAgendadas.BorderStyle = BorderStyle.FixedSingle;
            dgvObrasAgendadas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvObrasAgendadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Crear columnas para tus datos de clientes
            dgvObrasAgendadas.Columns.Clear();

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "NOMBRE";
            colNombre.FillWeight = 20;

            DataGridViewTextBoxColumn colTipo = new DataGridViewTextBoxColumn();
            colTipo.Name = "TipoObra";
            colTipo.HeaderText = "TIPO";
            colTipo.FillWeight = 20;

            DataGridViewTextBoxColumn colUbicacion = new DataGridViewTextBoxColumn();
            colUbicacion.Name = "Ubicacion";
            colUbicacion.HeaderText = "UBICACIÓN";
            colUbicacion.FillWeight = 18;

            DataGridViewTextBoxColumn colFechaInicio = new DataGridViewTextBoxColumn();
            colFechaInicio.Name = "FechaInicio";
            colFechaInicio.HeaderText = "FECHA INICIO";
            colFechaInicio.FillWeight = 20;

            DataGridViewTextBoxColumn colFechaFinal = new DataGridViewTextBoxColumn();
            colFechaFinal.Name = "FechaFinal";
            colFechaFinal.HeaderText = "FECHA FINAL";
            colFechaFinal.FillWeight = 20;

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado";
            colEstado.HeaderText = "ESTADO";
            colEstado.FillWeight = 20;
            


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
            dgvObrasAgendadas.Columns.AddRange(new DataGridViewColumn[] {
                colNombre, colTipo, colUbicacion, colFechaInicio, colFechaFinal,
                colEstado, colVer, colEditar, colEliminar
            });
        }


        public void MostrarObras()
        {
            listaObras = ObrasDAL.Mostrar();

            if (listaObras != null)
            {
                listaObrasOriginal = new List<Obras>(listaObras);
            }
            else
            {
                listaObrasOriginal = new List<Obras>();
            }

            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            dgvObrasAgendadas.Rows.Clear();

            foreach (var obra in listaObras)
            {

                int rowIndex = dgvObrasAgendadas.Rows.Add(
                    obra.NombreObra,
                    obra.TipoObra,
                    obra.Ubicacion,
                    obra.FechaInicio,
                    obra.FechaFinal,
                    obra.Estado
                );

                // Asignar imágenes a las columnas de botones
                if (dgvObrasAgendadas.Rows[rowIndex].Cells["Ver"] is DataGridViewImageCell verCell)
                {
                    dgvObrasAgendadas.Cursor = Cursors.Hand;
                    verCell.Value = Properties.Resources.visible; // Tu imagen de ver
                    verCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                if (dgvObrasAgendadas.Rows[rowIndex].Cells["Editar"] is DataGridViewImageCell editarCell)
                {
                    dgvObrasAgendadas.Cursor = Cursors.Hand;
                    editarCell.Value = Properties.Resources.editar; // Tu imagen de editar
                    editarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                if (dgvObrasAgendadas.Rows[rowIndex].Cells["Eliminar"] is DataGridViewImageCell eliminarCell)
                {
                    dgvObrasAgendadas.Cursor = Cursors.Hand;
                    eliminarCell.Value = Properties.Resources.cerrar; // Tu imagen de eliminar
                    eliminarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }

        private void dgvObrasAgendadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var obra = listaObras[e.RowIndex];

                switch (dgvObrasAgendadas.Columns[e.ColumnIndex].Name)
                {
                    case "Ver":
                        break;
                        //jodemos depue

                    case "Editar":
                        if (dgvObrasAgendadas.CurrentRow != null) // valida que haya fila seleccionada
                        {
                            DataGridViewRow fila = dgvObrasAgendadas.CurrentRow;

                            // Crear el formulario destino

                            FrmEditarObra frm = new FrmEditarObra(obra, dgvObrasAgendadas);
                            frm.ShowDialog();
                            MostrarObras(); // Refrescar la lista después de editar
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una fila antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                        break;

                    case "Eliminar":
                        if (MessageBox.Show($"¿Está seguro que desea eliminar esta obra?",
                            "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Eliminar de la base de datos
                            int resultado = ObrasDAL.EliminarObra(obra.IdObra);

                            if (resultado > 0)
                            {
                                MessageBox.Show("Obra eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar la obra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            listaObras.RemoveAt(e.RowIndex);
                            ActualizarDataGridView();
                        }
                        break;
                }
            }
        }




    }
}
