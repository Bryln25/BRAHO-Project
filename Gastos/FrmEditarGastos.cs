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
    public partial class FrmEditarGastos : Form
    {
        Gastos gastos = new Gastos();

        public FrmEditarGastos(Gastos gastos, DataGridView dataGridView)
        {
            InitializeComponent();
            Funciones.RedondearForm(this);

            cbObras.DataSource = GastosDAL.CargarObras();
            cbObras.DisplayMember = "NombreObra";
            cbObras.ValueMember = "IdObra";
            cbObras.SelectedIndex = -1;

            this.gastos = gastos;
            cbObras.SelectedValue = gastos.IdObra;
            dtpFecha.Value = DateTime.Parse(gastos.Fecha);
            txtDescripcion.Texts = gastos.Descripcion;
            cbTipoGasto.Texts = gastos.TipoGasto;
            txtMonto.Texts = gastos.Monto;
        }

        private void FrmEditarGastos_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void txtMonto__Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonto.Texts))
                return;

            double numero = Convert.ToDouble(txtMonto.Texts.Trim());

            txtMonto.Texts = $"RD$ {numero:N2}";
        }

        private void txtMonto__Enter(object sender, EventArgs e)
        {
            string numero = new string(txtMonto.Texts.Replace(",", "").Replace("$", "").Replace(".00", "").Where(char.IsDigit).ToArray());

            txtMonto.Texts = numero;
        }

        private void btnEditarGasto_Click(object sender, EventArgs e)
        {
            if (cbObras.SelectedValue == null || string.IsNullOrEmpty(txtDescripcion.Texts) || string.IsNullOrEmpty(txtMonto.Texts) ||
               string.IsNullOrEmpty(cbTipoGasto.Texts))

            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Gastos gasto = new Gastos();

            gasto.IdGasto = gastos.IdGasto;
            gasto.IdObra = (int)cbObras.SelectedValue;
            gasto.Fecha = dtpFecha.Value.ToString("dd/MM/yyyy").Trim();
            gasto.Descripcion = txtDescripcion.Texts.Trim();
            gasto.TipoGasto = cbTipoGasto.Texts.Trim();
            gasto.Monto = txtMonto.Texts.Trim();

            int resultado = GastosDAL.EditarGasto(gasto);

            if (resultado > 0)
            {

                MessageBox.Show("Gasto modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al editar la obra. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
