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
            txtFechaInicio.Texts = obras.FechaInicio;
            txtFechaFinal.Texts = obras.FechaFinal;
            txtRecordatorio.Texts = obras.Recordatorio;
            txtEstado.Texts = obras.Estado;
            txtTotal.Texts = GastosDAL.CalcularTotalGastosPorObra(obras.IdObra).ToString("F2");
            txtPresupuestoInicial.Texts = obras.Presupuesto;
        }

        private void FrmEditarObra_Load(object sender, EventArgs e)
        {
            txtCliente.Texts = cbCliente.Text;
            txtEncargado.Texts = cbEncargado.Text;

            string numero = new string(txtPresupuestoInicial.Texts.Replace("RD$", "")).Replace(",", "").Trim();
            double presupuestoInicial = Convert.ToDouble(numero);
            double totalGastos = Convert.ToDouble(txtTotal.Texts);
            double presupuestoActual = (presupuestoInicial - totalGastos);

            txtTotal.Texts = $"RD$ {totalGastos:N2}";
            txtPresupuestoActual.Texts = $"RD$ {presupuestoActual:N2}";
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
