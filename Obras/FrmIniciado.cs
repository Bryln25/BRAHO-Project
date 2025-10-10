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
    public partial class FrmIniciado : Form
    {
        private List<Obras> listaObras;
        private List<Obras> listaObrasOriginal = new List<Obras>();

        public FrmIniciado()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            MostrarObras();
        }

        private void ConfigurarDataGridView()
        {

            dgvObrasIniciadas.EnableHeadersVisualStyles = false;
            dgvObrasIniciadas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvObrasIniciadas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvObrasIniciadas.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dgvObrasIniciadas.GridColor = Color.Silver;
            dgvObrasIniciadas.RowHeadersVisible = false;
            dgvObrasIniciadas.BorderStyle = BorderStyle.FixedSingle;
            dgvObrasIniciadas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvObrasIniciadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Crear columnas para tus datos de clientes
            dgvObrasIniciadas.Columns.Clear();

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
            //dgvObrasIniciadas.Columns.Insert(5, colEstado); // Insertar en posición 5 (antes de botones)

            // Agregar todas las columnas
            dgvObrasIniciadas.Columns.AddRange(new DataGridViewColumn[] {
                colTipo, colUbicacion, colFechaInicio, colFechaFinal,
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
            dgvObrasIniciadas.Rows.Clear();

            foreach (var obra in listaObras)
            {
                // Normalizar el estado (convertir a mayúsculas y quitar espacios)
                string estadoNormalizado = (obra.Estado ?? "AGENDADO").ToUpper().Trim();

                // Si el estado no está en la lista, usar uno por defecto
                if (!new[] { "AGENDADO", "INICIADO", "TERMINADO" }.Contains(estadoNormalizado))
                {
                    estadoNormalizado = "AGENDADO";
                }

                int rowIndex = dgvObrasIniciadas.Rows.Add(
                    obra.TipoObra,
                    obra.Ubicacion,
                    obra.FechaInicio,
                    obra.FechaFinal,
                    estadoNormalizado
                );

                // Asignar imágenes a las columnas de botones
                if (dgvObrasIniciadas.Rows[rowIndex].Cells["Ver"] is DataGridViewImageCell verCell)
                {
                    dgvObrasIniciadas.Cursor = Cursors.Hand;
                    verCell.Value = Properties.Resources.visible; // Tu imagen de ver
                    verCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                if (dgvObrasIniciadas.Rows[rowIndex].Cells["Editar"] is DataGridViewImageCell editarCell)
                {
                    dgvObrasIniciadas.Cursor = Cursors.Hand;
                    editarCell.Value = Properties.Resources.editar; // Tu imagen de editar
                    editarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                if (dgvObrasIniciadas.Rows[rowIndex].Cells["Eliminar"] is DataGridViewImageCell eliminarCell)
                {
                    dgvObrasIniciadas.Cursor = Cursors.Hand;
                    eliminarCell.Value = Properties.Resources.cerrar; // Tu imagen de eliminar
                    eliminarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }

        private void dgvObrasIniciadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var obra = listaObras[e.RowIndex];

                switch (dgvObrasIniciadas.Columns[e.ColumnIndex].Name)
                {
                    case "Ver":
                        break;

                    case "Editar":
                        //if (dgvObrasIniciadas.CurrentRow != null) // valida que haya fila seleccionada
                        //{
                        //    DataGridViewRow fila = dgvObrasIniciadas.CurrentRow;

                        //    // Crear el formulario destino

                        //    FrmEditarClientes frm = new FrmEditarClientes(cliente, dgvObrasIniciadas);
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

        private void dgvObrasIniciadas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvObrasIniciadas.CurrentCell.ColumnIndex == dgvObrasIniciadas.Columns["Estado"].Index)
            {
                if (e.Control is ComboBox combo)
                {
                    // Aquí puedes llenar dinámicamente el ComboBox según la fila
                    combo.Items.Clear();
                    combo.Items.Add("AGENDADO");
                    combo.Items.Add("INACTIVO");
                    combo.Items.Add("PENDIENTE");
                }
            }
        }

        private void dgvObrasIniciadas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvObrasIniciadas.Columns[e.ColumnIndex].Name;

                if (columnName == "Estado")
                {
                    var selectedValue = dgvObrasIniciadas.Rows[e.RowIndex].Cells["Estado"].Value?.ToString();
                    var obra = listaObras[e.RowIndex];

                    // Actualizar el estado de la obra
                    obra.Estado = selectedValue;

                    // Aquí puedes actualizar en la base de datos si lo deseas
                    // ObrasDAL.ActualizarEstado(obra.IDObra, selectedValue);
                }
            }
        }
    }
}
