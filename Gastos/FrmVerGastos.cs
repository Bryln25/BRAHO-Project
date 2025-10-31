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
    public partial class FrmVerGastos : Form
    {
        Gastos gastos = new Gastos();

        public FrmVerGastos(Gastos gastos, DataGridView dataGridView)
        {
            InitializeComponent();
            Funciones.RedondearForm(this);
                        
            this.gastos = gastos;
            txtObra.Texts = GastosDAL.ObtenerNombreObraPorId(gastos.IdObra);
            dtpFecha.Value = DateTime.Parse(gastos.Fecha);
            txtDescripcion.Texts = gastos.Descripcion;
            txtTipoGasto.Texts = gastos.TipoGasto;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
