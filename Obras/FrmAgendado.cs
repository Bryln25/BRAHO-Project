using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            DataGridViewComboBoxColumn colEstado = new DataGridViewComboBoxColumn();
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

            // Añadir valores al ComboBox
            colEstado.Items.Add("AGENDADO");
            colEstado.Items.Add("INICIADO");
            colEstado.Items.Add("TERMINADO");

            // Asegurar que sea editable
            colEstado.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;

            // Insertar la columna donde quieras (antes de los botones)
            //dgvObrasAgendadas.Columns.Insert(5, colEstado); // Insertar en posición 5 (antes de botones)

            // Agregar todas las columnas
            dgvObrasAgendadas.Columns.AddRange(new DataGridViewColumn[] {
                colTipo, colUbicacion, colFechaInicio, colFechaFinal,
                colVer, colEditar, colEliminar, colEstado
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
                    obra.TipoObra,
                    obra.Ubicacion,
                    obra.FechaInicio,
                    obra.FechaFinal,
                    null, // ← Aquí va el valor del boton ver
                    null, // ← Aquí va el valor del botón Editar
                    null, // ← Aquí va el valor del botón Eliminar
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

                    case "Editar":
                        //if (dgvObrasAgendadas.CurrentRow != null) // valida que haya fila seleccionada
                        //{
                        //    DataGridViewRow fila = dgvObrasAgendadas.CurrentRow;

                        //    // Crear el formulario destino

                        //    FrmEditarClientes frm = new FrmEditarClientes(cliente, dgvObrasAgendadas);
                        //    Clientes clientes = new Clientes();


                        //    // Pasar valores

                        //    cliente.NombreApellido = fila.Cells["NombreApellido"].Value?.ToString();
                        //    cliente.Telefono = fila.Cells["Telefono"].Value?.ToString();
                        //    cliente.Email = fila.Cells["Email"].Value?.ToString();
                        //    cliente.Direccion = fila.Cells["Direccion"].Value?.ToString();
                        //    cliente.Cedula = fila.Cells["Cedula"].Value?.ToString();


                        //    // Mostrar el formulario
                        //    frm.ShowDialog();
                        //    MostrarClientes(); // Refrescar la lista después de editar
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Seleccione una fila antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}



                        break;

                    case "Eliminar":
                        //if (MessageBox.Show($"¿Está seguro que desea eliminar a {cliente.NombreApellido}?",
                        //    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        //{
                        //    // Eliminar de la base de datos
                        //    int resultado = ClientesDAL.EliminarCliente(cliente.IDCliente);

                        //    if (resultado > 0)
                        //    {
                        //        MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //        return;
                        //    }

                        //    listaClientes.RemoveAt(e.RowIndex);
                        //    ActualizarDataGridView();
                        //}
                        break;
                }
            }
        }

        private void dgvObrasAgendadas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvObrasAgendadas.CurrentCell.ColumnIndex == dgvObrasAgendadas.Columns["Estado"].Index)
            {
                if (e.Control is ComboBox combo)
                {
                    // Aquí puedes llenar dinámicamente el ComboBox según la fila
                    combo.Items.Clear();
                    combo.Items.Add("ACTIVO");
                    combo.Items.Add("INACTIVO");
                    combo.Items.Add("PENDIENTE");
                }
            }
        }
    }
}
