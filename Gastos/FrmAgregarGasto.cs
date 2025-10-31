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
            cbGastos.DataSource = GastosDAL.CargarObras();
            cbGastos.DisplayMember = "NombreObra";
            cbGastos.ValueMember = "IdObra";
            cbGastos.SelectedIndex = -1;

          
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

            if (cbGastos.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una obra antes de agregar un gasto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                gasto.IdGasto = (int)cbGastos.SelectedValue;


                int resultado = GastosDAL.AgregarGasto(gasto);

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

        private void txtPresupuesto__Leave(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtPresupuesto.Texts.Trim());

            txtPresupuesto.Texts = $"RD$ {numero:N2}";
        }

        private void txtPresupuesto__Enter(object sender, EventArgs e)
        {
            string numero = new string(txtPresupuesto.Texts.Replace(",", "").Replace("$", "").Replace(".00", "").Where(char.IsDigit).ToArray());

            txtPresupuesto.Texts = numero;
        }







        //private void txtMetros__KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Allow control keys (e.g., backspace), digits, and one dot
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        //    {
        //        e.Handled = true;
        //    }
        //    // Only allow one dot
        //    if (e.KeyChar == '.' && ((sender as Control).Text.Contains(".")))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
