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
        private List<Obras> listaObras;
        private List<Obras> listaObrasOriginal = new List<Obras>();
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

            FrmAgendado frmAgendado = Application.OpenForms["FrmAgendado"] as FrmAgendado;

            if (frmAgendado != null)
            {
                frmAgendado.MostrarObras();
            }
        }

        private bool barraExpandida = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barraExpandida)
            {
                txtBuscar.Width -= 20;
                if (txtBuscar.Width <= 0)
                {
                    txtBuscar.Width = 0;
                    txtBuscar.ActiveControl = null;
                    barraExpandida = false;
                    timer1.Stop();
                }
            }
            else
            {
                txtBuscar.Visible = true;
                txtBuscar.Width += 20;
                if (txtBuscar.Width >= 347)
                {
                    txtBuscar.Width = 347;
                    barraExpandida = true;
                    timer1.Stop();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Texts.Trim().ToLower();

            if (string.IsNullOrEmpty(filtro))
            {
                listaObras = new List<Obras>(listaObrasOriginal);
            }
            else
            {
                listaObras = listaObrasOriginal.Where(c =>
                    (c.NombreObra?.ToLower() ?? "").Contains(filtro)

                ).ToList();
            }

            FrmAgendado frmAgendado = Application.OpenForms["FrmAgendado"] as FrmAgendado;

            if (frmAgendado != null)
            {
                frmAgendado.ActualizarListaObras(listaObras);
                frmAgendado.ActualizarDataGridView();
            }

            FrmIniciado frmIniciado = Application.OpenForms["FrmIniciado"] as FrmIniciado;

            if (frmIniciado != null)
            {
                frmIniciado.ActualizarListaObras(listaObras);

                frmIniciado.ActualizarDataGridView();
            }

            FrmTerminado frmTerminado = Application.OpenForms["FrmTerminado"] as FrmTerminado;

            if (frmTerminado != null)
            {
                frmTerminado.ActualizarListaObras(listaObras);
                frmTerminado.ActualizarDataGridView();
            }
        }
    }
}
