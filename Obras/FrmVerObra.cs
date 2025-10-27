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
    public partial class FrmVerObra : Form
    {
        Obras obras = new Obras();
        public FrmVerObra(Obras obras, DataGridView dataGridView)
        {
            InitializeComponent();
            Funciones.RedondearForm(this);

            cbCliente.DataSource = ObrasDAL.CargarClientes();
            cbCliente.DisplayMember = "NombreApellido";
            cbCliente.ValueMember = "IDCliente";
            cbCliente.SelectedValue = obras.IDCliente;

            cbEncargado.DataSource = ObrasDAL.CargarEncargados();
            cbEncargado.DisplayMember = "NombreApellido";
            cbEncargado.ValueMember = "IdUsuario";
            cbEncargado.SelectedValue = obras.IdUsuario;

            txtNombre.Texts = obras.NombreObra;
            txtTipo.Texts = obras.TipoObra;
            txtUbicacion.Texts = obras.Ubicacion;
            txtMetros.Texts = obras.MetrosCuadrados;
            txtPresupuesto.Texts = obras.Presupuesto;
            txtFechaInicio.Texts = obras.FechaInicio;
            txtFechaFinal.Texts = obras.FechaFinal;
            txtRecordatorio.Texts = obras.Recordatorio;
            txtEstado.Texts = obras.Estado;
        }

        private void FrmEditarObra_Load(object sender, EventArgs e)
        {
            txtCliente.Texts = cbCliente.Text;
            txtEncargado.Texts = cbEncargado.Text;
        }

        private void FrmAgregarObra_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void btnEditarObra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
