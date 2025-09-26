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
    public partial class FrmAgregarClientes : Form
    {
        private DataGridView dgvBuscar;

        public FrmAgregarClientes(DataGridView dataGridView)
        {
            dgvBuscar = dataGridView;
            InitializeComponent();
            Funciones.RedondearForm(this);
        }

        // Codigo para mover el formulario
        private void FrmAgregarClientes_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();

            cliente.NombreApellido = txtNombre.Texts.Trim();
            cliente.Telefono = txtTelefono.Texts.Trim();
            cliente.Email = txtEmail.Texts.Trim();
            cliente.Direccion = txtDireccion.Texts.Trim();
            cliente.Cedula = txtCedula.Texts.Trim();
            int resultado = ClientesDAL.AgregarClientes(cliente);

            if (resultado > 0)
            {
                MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBuscar.Refresh(); // Refresca el DataGridView para mostrar el nuevo cliente
                this.Close(); // Cierra el formulario después de agregar el cliente
            }
            else
            {
                MessageBox.Show("Error al agregar el cliente. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            // Tomamos solo los dígitos del texto
            string numero = new string(txtTelefono.Texts.Where(char.IsDigit).ToArray());

            if (numero.Length == 10)
            {
                string codigoArea = numero.Substring(0, 3);
                string parte1 = numero.Substring(3, 3);
                string parte2 = numero.Substring(6, 4);

                txtTelefono.Texts = $"+1 ({codigoArea}) {parte1} {parte2}";
            }
            else
            {
                MessageBox.Show("El numero de teléfono debe tener 10 dígitos.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
            }
        }

        private void txtCedula__Leave(object sender, EventArgs e)
        {
            // Tomamos solo los dígitos
            string numero = new string(txtCedula.Texts.Where(char.IsDigit).ToArray());

            if (numero.Length == 11)
            {
                string parte1 = numero.Substring(0, 3);
                string parte2 = numero.Substring(3, 7);
                string parte3 = numero.Substring(10, 1);

                txtCedula.Texts = $"{parte1}-{parte2}-{parte3}";
            }
            else
            {
                MessageBox.Show("La cédula debe tener 11 dígitos.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
            }
        }

        private void txtTelefono__Enter(object sender, EventArgs e)
        {
            string numero = new string(txtTelefono.Texts.Replace("+1", "").Where(char.IsDigit).ToArray());
            txtTelefono.Texts = numero;
        }

        private void txtCedula__Enter(object sender, EventArgs e)
        {
            string numero = new string(txtCedula.Texts.Replace("-", "").Where(char.IsDigit).ToArray());
            txtCedula.Texts = numero;
        }
    }
}
