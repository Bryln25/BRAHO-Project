using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRAHO_Project.Auditoria;
using Microsoft.IdentityModel.Tokens;

namespace BRAHO_Project
{
    public partial class FrmAgregarObra : Form
    {
        private Usuario usuario;


        public FrmAgregarObra(Usuario usuarioLogueado)
        {
            InitializeComponent();
            Funciones.RedondearForm(this);
            usuario = usuarioLogueado;


        }
        private void FrmAgregarObra_Load(object sender, EventArgs e)
        {
            cbCliente.DataSource = ObrasDAL.CargarClientes();
            cbCliente.DisplayMember = "NombreApellido";
            cbCliente.ValueMember = "IDCliente";
            cbCliente.SelectedIndex = -1;

            cbEncargado.DataSource = ObrasDAL.CargarEncargados();
            cbEncargado.DisplayMember = "NombreApellido";
            cbEncargado.ValueMember = "IdUsuario";
            cbEncargado.SelectedIndex = -1;
        }

        private void FrmAgregarObra_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarObra_Click(object sender, EventArgs e)
        {
            Obras obra = new Obras();

            if (cbCliente.SelectedValue == null || string.IsNullOrEmpty(cbEncargado.Texts) || string.IsNullOrEmpty(cbTipo.Texts) ||
               string.IsNullOrEmpty(txtNombre.Texts) || string.IsNullOrEmpty(txtUbicacion.Texts) || string.IsNullOrEmpty(txtMetros.Texts) || string.IsNullOrEmpty(txtPresupuesto.Texts))

            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dtpFechaInicio.Value > dtpFechaFinal.Value)
            {
                MessageBox.Show("La Fecha Inicial no puede ser mayor que la Fecha Final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            obra.IDCliente = (int)cbCliente.SelectedValue;
            obra.NombreObra = txtNombre.Texts.Trim();
            obra.TipoObra = cbTipo.Texts.Trim();
            obra.Ubicacion = txtUbicacion.Texts.Trim();
            obra.MetrosCuadrados = txtMetros.Texts.Trim();
            obra.Presupuesto = txtPresupuesto.Texts.Trim();
            obra.FechaInicio = dtpFechaInicio.Value.ToString("dd/MM/yyyy").Trim();
            obra.FechaFinal = dtpFechaFinal.Value.ToString("dd/MM/yyyy").Trim();
            obra.Recordatorio = txtRecordatorio.Texts.Trim();
            obra.IdUsuario = (int)cbEncargado.SelectedValue;

            int resultado = ObrasDAL.AgregarObra(obra);

            if (resultado > 0)
            {
                MessageBox.Show("Obra agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string detalle = $"El usuario {usuario.Nombre}, agregó una obra con el nombre de: {txtNombre.Texts.Trim()}";
                AuditoriaDAL auditoria = new AuditoriaDAL(usuario);
                auditoria.RAuditoria("Agregar", detalle);

                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar la Obra. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPresupuesto__Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPresupuesto.Texts))
                return;

            double numero = Convert.ToDouble(txtPresupuesto.Texts.Trim());

            txtPresupuesto.Texts = $"RD$ {numero:N2}";
        }

        private void txtPresupuesto__Enter(object sender, EventArgs e)
        {
            string numero = new string(txtPresupuesto.Texts.Replace("RD$", "")).Replace(",", "").Trim();

            txtPresupuesto.Texts = numero;
        }

        private void txtMetros__Enter(object sender, EventArgs e)
        {

            string numero = new string(txtMetros.Texts.Replace("m²", "")).Trim();

            txtMetros.Texts = numero;
        }

        private void txtMetros__Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetros.Texts))
                return;

            double numero = Convert.ToDouble(txtMetros.Texts.Trim());

            txtMetros.Texts = $"{numero:N2} m²";
        }

        private void txtMetros__KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (e.g., backspace), digits, and one dot
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Only allow one dot
            if (e.KeyChar == '.' && ((sender as Control).Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void txtPresupuesto__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && ((sender as Control).Text.Contains(".")))
            {
                e.Handled = true;
            }
        }
    }
}
