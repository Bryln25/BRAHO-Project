using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRAHO_Project
{
    public partial class FrmEditarClientes : Form
    {
        Clientes clientes = new Clientes();
        private DataGridView dgvBuscar;
        public FrmEditarClientes(Clientes clientes, DataGridView dataGridView)
        {
            InitializeComponent();
            this.clientes = clientes;
            txtNombre.Texts = clientes.NombreApellido;
            txtTelefono.Texts = clientes.Telefono;
            txtEmail.Texts = clientes.Email;
            txtDireccion.Texts = clientes.Direccion;
            txtCedula.Texts = clientes.Cedula;

            dgvBuscar = dataGridView;




            //txtNombre.Texts = nombre;
        }

        //Codigo para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmAgregarClientes_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmAgregarClientes_Load(object sender, EventArgs e)
        {
            // Redondear bordes del formulario
            int radio = 30; // Ajusta el nivel de redondeado
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();

                // Esquinas redondeadas
                path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
                path.AddArc(new Rectangle(this.Width - radio, 0, radio, radio), 270, 90);
                path.AddArc(new Rectangle(this.Width - radio, this.Height - radio, radio, radio), 0, 90);
                path.AddArc(new Rectangle(0, this.Height - radio, radio, radio), 90, 90);

                path.CloseFigure();
                this.Region = new Region(path);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            
            cliente.IDCliente = clientes.IDCliente;
            cliente.NombreApellido = txtNombre.Texts.Trim();
            cliente.Telefono = txtTelefono.Texts.Trim();
            cliente.Email = txtEmail.Texts.Trim();
            cliente.Direccion = txtDireccion.Texts.Trim();
            cliente.Cedula = txtCedula.Texts.Trim();
            int resultado = ClientesDAL.EditarClientes(cliente);

            if (resultado > 0)
            {
               
                MessageBox.Show("Cliente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario después de agregar el cliente
            }
            else
            {
                MessageBox.Show("Error al editar el cliente. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }
}
