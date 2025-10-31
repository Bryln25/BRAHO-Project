using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

namespace BRAHO_Project
{
    public partial class FrmAgregarGasto : Form
    {

        public FrmAgregarGasto()
        {
            InitializeComponent();
            Funciones.RedondearForm(this);

        }
        private void FrmAgregarObra_Load(object sender, EventArgs e)
        {
            cbObras.DataSource = GastosDAL.CargarObras();
            cbObras.DisplayMember = "NombreObra";
            cbObras.ValueMember = "IdObra";
            cbObras.SelectedIndex = -1;

          
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
            Gastos gasto = new Gastos();

            if (cbObras.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una obra antes de agregar un gasto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }  

            gasto.IdGasto = (int)cbObras.SelectedValue;
            gasto.IdObra = (int)cbObras.SelectedValue;
            gasto.Fecha = dtpFecha.Value.ToString("dd/MM/yyyy").Trim();
            gasto.Descripcion = txtDescripcion.Texts.Trim();
            gasto.TipoGasto = cbTipoGasto.Texts.Trim();
            gasto.Monto = txtMonto.Texts.Trim();

            int resultado = GastosDAL.AgregarGasto(gasto);

            if (resultado > 0)
            {
                MessageBox.Show("Gasto agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el Gasto. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
