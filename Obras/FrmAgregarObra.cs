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
    public partial class FrmAgregarObra : Form
    {

        public FrmAgregarObra()
        {
            InitializeComponent();
            Funciones.RedondearForm(this);

        }
        private void FrmAgregarObra_Load(object sender, EventArgs e)
        {
            cbCliente.DataSource = ObrasDAL.CargarClientes();
            cbCliente.DisplayMember = "NombreApellido";
            cbCliente.ValueMember = "IDCliente";
            cbCliente.SelectedIndex = -1;
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

            obra.IDCliente = (int)cbCliente.SelectedValue;
            obra.NombreObra = txtNombre.Texts.Trim();
            obra.TipoObra = cbTipo.Texts.Trim();
            obra.Ubicacion = txtUbicacion.Texts.Trim();
            obra.MetrosCuadrados = txtMetros.Texts.Trim();
            obra.Presupuesto = txtPresupuesto.Texts.Trim();
            obra.FechaInicio = dtpFechaInicio.Value.ToString("dd/MM/yyyy").Trim();
            obra.FechaFinal = dtpFechaFinal.Value.ToString("dd/MM/yyyy").Trim();
            obra.Recordatorio = txtRecordatorio.Texts.Trim();

            int resultado = ObrasDAL.AgregarObra(obra);

            if (resultado > 0)
            {
                MessageBox.Show("Obra agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar la Obra. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
