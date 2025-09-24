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
    public partial class FrmClientes : Form
    {
        private List<Clientes> listaClientes;

        public FrmClientes()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            MostrarClientes();
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

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "NombreApellido";
            colNombre.HeaderText = "NOMBRE";
            colNombre.FillWeight = 20;

            DataGridViewTextBoxColumn colTelefono = new DataGridViewTextBoxColumn();
            colTelefono.Name = "Telefono";
            colTelefono.HeaderText = "TELÉFONO";
            colTelefono.FillWeight = 15;

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "Email";
            colEmail.HeaderText = "EMAIL";
            colEmail.FillWeight = 20;

            DataGridViewTextBoxColumn colDireccion = new DataGridViewTextBoxColumn();
            colDireccion.Name = "Direccion";
            colDireccion.HeaderText = "DIRECCIÓN";
            colDireccion.FillWeight = 25;

            DataGridViewTextBoxColumn colCedula = new DataGridViewTextBoxColumn();
            colCedula.Name = "Cedula";
            colCedula.HeaderText = "CÉDULA";
            colCedula.FillWeight = 15;

            // Columnas de botones (usaremos imágenes)
            DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
            colEditar.Name = "Editar";
            colEditar.HeaderText = "";
            colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEditar.FillWeight = 10;

            DataGridViewImageColumn colEliminar = new DataGridViewImageColumn();
            colEliminar.Name = "Eliminar";
            colEliminar.HeaderText = "";
            colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEliminar.FillWeight = 10;

            // Agregar todas las columnas
            dgvBuscar.Columns.AddRange(new DataGridViewColumn[] {
                colNombre, colTelefono, colEmail, colDireccion, colCedula,
                colEditar, colEliminar
            });
        }

        public void MostrarClientes()
        {
            listaClientes = new List<Clientes>();

            using (SqlConnection conexion = ConexionBRAHOBD.ObtenerConexion())
            {
                var command = new SqlCommand("SELECT * FROM Clientes", conexion);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaClientes.Add(new Clientes(
                            reader.GetInt32("IDCliente"),
                            reader.GetString("NombreApellido"),
                            reader.GetString("Telefono"),
                            reader.GetString("Email"),
                            reader.GetString("Direccion"),
                            reader.GetString("Cedula")
                        ));
                    }
                }
            }

            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            dgvBuscar.Rows.Clear();

            foreach (var cliente in listaClientes)
            {
                int rowIndex = dgvBuscar.Rows.Add(
                    cliente.NombreApellido,
                    cliente.Telefono,
                    cliente.Email,
                    cliente.Direccion,
                    cliente.Cedula
                );

                // Asignar imágenes a las columnas de botones
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
                var cliente = listaClientes[e.RowIndex];

                switch (dgvBuscar.Columns[e.ColumnIndex].Name)
                {
                    case "Editar": 
                        // dale tu puede
                        break;

                    case "Eliminar":
                        if (MessageBox.Show($"¿Está seguro que desea eliminar a {cliente.NombreApellido}?",
                            "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Eliminar de la base de datos
                            int resultado = ClientesDAL.EliminarCliente(cliente.IDCliente);

                            if (resultado > 0)
                            {
                                MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            listaClientes.RemoveAt(e.RowIndex);
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

        private void BotonAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarClientes formularioAgregar = new FrmAgregarClientes(dgvBuscar);
            formularioAgregar.ShowDialog();
            MostrarClientes(); // Refrescar la lista después de agregar
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
                    dgvBuscar.Cursor = Cursors.Default; // vuelve al cursor normal
                }
            }
        }
    }
}
