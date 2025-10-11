using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRAHO_Project
{
    public partial class FrmObras : Form
    {
        public FrmObras()
        {
            InitializeComponent();
            abrirformhijo(new FrmAgendado());
        }

        private Form formularioactivo = null;
        private void abrirformhijo(Form formulariohijo)
        {
            if (formularioactivo != null)
                formularioactivo.Close();
            formularioactivo = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.FormBorderStyle = FormBorderStyle.None;
            formulariohijo.Dock = DockStyle.Fill;
            panel2.Controls.Add(formulariohijo);
            panel2.Tag = formulariohijo;
            formulariohijo.BringToFront();
            formulariohijo.Show();
        }

        private void btnAgendado_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmAgendado());
        }

        private void btnIniciado_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmIniciado());
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmTerminado());
        }

        private void BotonCerr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonAgendarObra_Click(object sender, EventArgs e)
        {
            FrmAgregarObra frmAgregarObra = new FrmAgregarObra();
            frmAgregarObra.ShowDialog();
        }


    }
}
