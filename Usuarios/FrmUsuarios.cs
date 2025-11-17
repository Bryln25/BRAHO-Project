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
using BRAHO_Project.RJControls;

namespace BRAHO_Project
{
    public partial class FrmUsuarios : Form
    {
        private RJButton botonActivo = null;

        public FrmUsuarios()
        {
            InitializeComponent();
        }


        private void FrmObras_Load(object sender, EventArgs e)
        {
            btnAgendado_Click(sender, e);
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

        
        private void BotonCerr_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (!barraExpandida)
            {
                txtBuscar.Focus();
            }
            else
            {
                txtBuscar.Texts = string.Empty;
                txtOculto.Focus();
            }
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Texts.Trim().ToLower();

            if (btnNuevo.BorderSize == 5)
            {
                FrmAgendado frmAgendado = Application.OpenForms["FrmAgendado"] as FrmAgendado;
                if (frmAgendado != null)
                {
                    frmAgendado.FiltarDataGridView(filtro);
                }

            }
            else if (btnProcesado.BorderSize == 5)
            {
                FrmTerminado frmTerminado = Application.OpenForms["FrmTerminado"] as FrmTerminado;
                if (frmTerminado != null)
                {
                    frmTerminado.FiltarDataGridView(filtro);
                }
            }
        }

        private void btnAgendado_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmNuevos());
            ActivarBoton(btnNuevo);
        }

        //private void btnIniciado_Click(object sender, EventArgs e)
        //{
        //    abrirformhijo(new FrmIniciado());
        //    ActivarBoton(btnPendiente);
        //}

        private void btnProcesado_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmProcesados());
            ActivarBoton(btnProcesado);
        }

        private void ActivarBoton(RJButton boton)
        {
            if (botonActivo != null && botonActivo != boton)
            {
                DesactivarPropiedades(botonActivo);
            }
            ActivarPropiedades(boton);
            botonActivo = boton;
        }

        private void ActivarPropiedades(RJButton boton)
        {
            boton.BorderSize = 5;
            // Add other visual changes for active state if needed
        }

        private void DesactivarPropiedades(RJButton boton)
        {
            boton.BorderSize = 0;
            // Restore other properties for inactive state if needed
        }
    }
}
