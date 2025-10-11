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
    public partial class FrmEditarObra : Form
    {
        Obras obras = new Obras();
        public FrmEditarObra(Obras obras, DataGridView dataGridView)
        {
            InitializeComponent();
            Funciones.RedondearForm(this);


            cbCliente.DataSource = ObrasDAL.CargarClientes();
            cbCliente.DisplayMember = "NombreApellido";
            cbCliente.ValueMember = "IDCliente";
            cbCliente.SelectedIndex = -1;
            this.obras = obras;
            txtNombre.Texts = obras.NombreObra;
            cbCliente.SelectedValue = obras.IDCliente;
            cbTipo.Texts = obras.TipoObra;
            txtUbicacion.Texts = obras.Ubicacion;
            txtMetros.Texts = obras.MetrosCuadrados;
            txtPresupuesto.Texts = obras.Presupuesto;
            dtpFechaInicio.Value = DateTime.Parse(obras.FechaInicio);
            dtpFechaFinal.Value = DateTime.Parse(obras.FechaFinal);
            txtRecordatorio.Texts = obras.Recordatorio;
            cbEstado.Texts = obras.Estado;
        }

        private void FrmEditarObra_Load(object sender, EventArgs e)
        {
        }

        private void FrmAgregarObra_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarObra_Click(object sender, EventArgs e)
        {
            Obras obra = new Obras();
            
            obra.IdObra = obras.IdObra;
            obra.IDCliente = (int)cbCliente.SelectedValue;
            obra.NombreObra = txtNombre.Texts.Trim();
            obra.TipoObra = cbTipo.Texts.Trim();
            obra.Ubicacion = txtUbicacion.Texts.Trim();
            obra.MetrosCuadrados = txtMetros.Texts.Trim();
            obra.Presupuesto = txtPresupuesto.Texts.Trim();
            obra.FechaInicio = dtpFechaInicio.Value.ToString("dd/MM/yyyy").Trim();
            obra.FechaFinal = dtpFechaFinal.Value.ToString("dd/MM/yyyy").Trim();
            obra.Recordatorio = txtRecordatorio.Texts.Trim();
            obra.Estado = cbEstado.Texts.Trim();
            int resultado = ObrasDAL.EditarObras(obra);

            if (resultado > 0)
            {

                MessageBox.Show("Obra modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Error al editar la obra. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
