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

        private void FrmClientes_Load(object sender, EventArgs e)
        {
        }

        private void ConfigurarDataGridView()
        {
            // Estilo general
            dgvBuscar.EnableHeadersVisualStyles = false;
            dgvBuscar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvBuscar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dgvBuscar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvBuscar.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            //dgvBuscar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230);
            //dgvBuscar.DefaultCellStyle.SelectionForeColor = Color.Black;
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

            DataGridViewImageColumn colActivar = new DataGridViewImageColumn();
            colActivar.Name = "Aceptar";
            colActivar.HeaderText = "";
            colActivar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colActivar.FillWeight = 10;

            DataGridViewImageColumn colEliminar = new DataGridViewImageColumn();
            colEliminar.Name = "Eliminar";
            colEliminar.HeaderText = "";
            colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEliminar.FillWeight = 10;

            // Agregar todas las columnas
            dgvBuscar.Columns.AddRange(new DataGridViewColumn[] {
                colNombre, colTelefono, colEmail, colDireccion, colCedula,
                colEditar, colActivar, colEliminar
            });
        }

        private void MostrarClientes()
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


            // Por ahora usamos datos de ejemplo
            listaClientes.Add(new Clientes(1, "Juan Pérez", "0987654321", "juan@email.com", "Calle Principal 123", "1234567890"));
            listaClientes.Add(new Clientes(2, "María García", "0912345678", "maria@email.com", "Av. Secundaria 456", "0987654321"));

            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
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
                    editarCell.Value = Properties.Resources.editar; // Tu imagen de editar
                    editarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                if (dgvBuscar.Rows[rowIndex].Cells["Aceptar"] is DataGridViewImageCell verCell)
                {
                    verCell.Value = Properties.Resources.aceptar; // Tu imagen de ver
                    verCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                if (dgvBuscar.Rows[rowIndex].Cells["Eliminar"] is DataGridViewImageCell eliminarCell)
                {
                    eliminarCell.Value = Properties.Resources.cerrar; // Tu imagen de eliminar
                    eliminarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }

        private void dgvBuscar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBuscar.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                if (e.Value.ToString() == "ACTIVO")
                {
                    e.CellStyle.BackColor = Color.FromArgb(0, 123, 255); // Azul
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    e.CellStyle.Font = new Font(dgvBuscar.Font, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(108, 117, 125); // Gris
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    e.CellStyle.Font = new Font(dgvBuscar.Font, FontStyle.Bold);
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
                        // Aquí puedes abrir un formulario para editar el cliente
                        MessageBox.Show($"Editar cliente: {cliente.NombreApellido}\nID: {cliente.IDCliente}",
                            "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Ver":
                        // Aquí puedes mostrar detalles del cliente
                        string detalles = $"ID: {cliente.IDCliente}\n" +
                                        $"Nombre: {cliente.NombreApellido}\n" +
                                        $"Teléfono: {cliente.Telefono}\n" +
                                        $"Email: {cliente.Email}\n" +
                                        $"Dirección: {cliente.Direccion}\n" +
                                        $"Cédula: {cliente.Cedula}";
                        MessageBox.Show(detalles, "Detalles del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Eliminar":
                        if (MessageBox.Show($"¿Está seguro que desea eliminar a {cliente.NombreApellido}?",
                            "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Aquí va tu código para eliminar de la base de datos
                            /*
                            using (var connection = new SqlConnection(connectionString))
                            {
                                var command = new SqlCommand("DELETE FROM Clientes WHERE IDCliente = @id", connection);
                                command.Parameters.AddWithValue("@id", cliente.IDCliente);
                                command.ExecuteNonQuery();
                            }
                            */

                            // Eliminar de la lista local
                            listaClientes.RemoveAt(e.RowIndex);
                            ActualizarDataGridView();
                        }
                        break;
                }
            }
        }
    }
}
