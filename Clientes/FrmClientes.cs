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
        private List<Clientes> listaClientesOriginal = new List<Clientes>();
        private Usuario usuario;


        public FrmClientes(Usuario usuarioLogueado)
        {
            InitializeComponent();
            ConfigurarDataGridView();
            MostrarClientes();
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

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "NombreApellido";
            colNombre.HeaderText = "NOMBRE";
            colNombre.FillWeight = 20;

            DataGridViewTextBoxColumn colTelefono = new DataGridViewTextBoxColumn();
            colTelefono.Name = "Telefono";
            colTelefono.HeaderText = "TELÉFONO";
            colTelefono.FillWeight = 18;

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "Email";
            colEmail.HeaderText = "EMAIL";
            colEmail.FillWeight = 20;

            DataGridViewTextBoxColumn colDireccion = new DataGridViewTextBoxColumn();
            colDireccion.Name = "Direccion";
            colDireccion.HeaderText = "DIRECCIÓN";
            colDireccion.FillWeight = 20;

            DataGridViewTextBoxColumn colCedula = new DataGridViewTextBoxColumn();
            colCedula.Name = "Cedula";
            colCedula.HeaderText = "CÉDULA";
            colCedula.FillWeight = 13;

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
            dgvBuscar.Columns.AddRange(new DataGridViewColumn[] {
                colNombre, colTelefono, colEmail, colDireccion, colCedula,
                colEditar, colEliminar
            });
        }

        public void MostrarClientes()
        {
            listaClientes = ClientesDAL.Mostrar();

            if (listaClientes != null)
            {
                listaClientesOriginal = new List<Clientes>(listaClientes);
            }
            else
            {
                listaClientesOriginal = new List<Clientes>();
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
                        if (dgvBuscar.CurrentRow != null) 
                        {
                            DataGridViewRow fila = dgvBuscar.CurrentRow;


                            FrmEditarClientes frm = new FrmEditarClientes(cliente, dgvBuscar);
                            frm.ShowDialog();
                            MostrarClientes(); 
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una fila antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case "Eliminar":
                        if (MessageBox.Show($"¿Está seguro que desea eliminar a {cliente.NombreApellido}?",
                            "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
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
            FrmAgregarClientes formularioAgregar = new FrmAgregarClientes(dgvBuscar, usuario);
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
                    dgvBuscar.Cursor = Cursors.Default; 
                }
            }
        }



        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            string patron = txtBuscar.Texts.Trim().ToLower();
            listaClientes = new List<Clientes>();

            if (string.IsNullOrEmpty(patron))
            {
                listaClientes = new List<Clientes>(listaClientesOriginal);
            }
            else
            {
                foreach (var cliente in listaClientesOriginal)
                {
                    
                    bool encontrado =
                        FuerzaBruta(cliente.NombreApellido?.ToLower(), patron) ||
                        FuerzaBruta(cliente.Telefono?.ToLower().Replace(" ", "").Replace(")", ""), patron) ||
                        FuerzaBruta(cliente.Email?.ToLower(), patron) ||
                        FuerzaBruta(cliente.Direccion?.ToLower(), patron) ||
                        FuerzaBruta(cliente.Cedula?.ToLower().Replace("-", ""), patron);
                    
                    if (encontrado)
                        listaClientes.Add(cliente);
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

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
