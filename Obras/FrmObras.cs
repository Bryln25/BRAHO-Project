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
    public partial class FrmObras : Form
    {
        private RJButton botonActivo = null;
        private List<Obras> listaObrasAgendado;
        private List<Obras> listaObrasOriginalAgendado = new List<Obras>();
        private List<Obras> listaObrasIniciado;
        private List<Obras> listaObrasOriginalIniciado = new List<Obras>();
        private List<Obras> listaObrasTerminado;
        private List<Obras> listaObrasOriginalTerminado = new List<Obras>();

        public FrmObras()
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
            FrmAgendado frmAgendado = Application.OpenForms["FrmAgendado"] as FrmAgendado;
            FrmIniciado frmIniciado = Application.OpenForms["FrmIniciado"] as FrmIniciado;
            FrmTerminado frmTerminado = Application.OpenForms["FrmTerminado"] as FrmTerminado;

            listaObrasAgendado = ObrasDAL.MostrarAgendado();
            if (listaObrasAgendado != null)
            {
                listaObrasOriginalAgendado = new List<Obras>(listaObrasAgendado);
            }
            else
            {
                listaObrasOriginalAgendado = new List<Obras>();
            }

            listaObrasIniciado = ObrasDAL.MostrarIniciado();
            if (listaObrasIniciado != null)
            {
                listaObrasOriginalIniciado = new List<Obras>(listaObrasIniciado);
            }
            else
            {
                listaObrasOriginalIniciado = new List<Obras>();
            }

            listaObrasTerminado = ObrasDAL.MostrarTerminado();
            if (listaObrasTerminado != null)
            {
                listaObrasOriginalTerminado = new List<Obras>(listaObrasTerminado);
            }
            else
            {
                listaObrasOriginalTerminado = new List<Obras>();
            }

            if (string.IsNullOrEmpty(filtro))
            {
                listaObrasAgendado = new List<Obras>(listaObrasOriginalAgendado);
            }
            else
            {
                listaObrasAgendado = listaObrasOriginalAgendado.Where(c =>
                    (c.NombreObra?.ToLower() ?? "").Contains(filtro) ||
                    (c.TipoObra?.ToLower() ?? "").Contains(filtro) ||
                    (c.Ubicacion?.ToLower() ?? "").Contains(filtro) ||
                    (c.FechaInicio?.ToLower() ?? "").Contains(filtro) ||
                    (c.FechaFinal?.ToLower() ?? "").Contains(filtro)
                ).ToList();
            }

            if (string.IsNullOrEmpty(filtro))
            {
                listaObrasIniciado = new List<Obras>(listaObrasOriginalIniciado);
            }
            else
            {
                listaObrasIniciado = listaObrasOriginalIniciado.Where(c =>
                    (c.NombreObra?.ToLower() ?? "").Contains(filtro) ||
                    (c.TipoObra?.ToLower() ?? "").Contains(filtro) ||
                    (c.Ubicacion?.ToLower() ?? "").Contains(filtro) ||
                    (c.FechaInicio?.ToLower() ?? "").Contains(filtro) ||
                    (c.FechaFinal?.ToLower() ?? "").Contains(filtro)
                ).ToList();
            }

            if (string.IsNullOrEmpty(filtro))
            {
                listaObrasTerminado = new List<Obras>(listaObrasOriginalTerminado);
            }
            else
            {
                listaObrasTerminado = listaObrasOriginalTerminado.Where(c =>
                    (c.NombreObra?.ToLower() ?? "").Contains(filtro) ||
                    (c.TipoObra?.ToLower() ?? "").Contains(filtro) ||
                    (c.Ubicacion?.ToLower() ?? "").Contains(filtro) ||
                    (c.FechaInicio?.ToLower() ?? "").Contains(filtro) ||
                    (c.FechaFinal?.ToLower() ?? "").Contains(filtro)
                ).ToList();
            }


            if (frmAgendado != null)
            {
                frmAgendado.ActualizarListaObras(listaObrasAgendado);
                frmAgendado.ActualizarDataGridView();
            }


            if (frmIniciado != null)
            {
                frmIniciado.ActualizarListaObras(listaObrasIniciado);

                frmIniciado.ActualizarDataGridView();
            }


            if (frmTerminado != null)
            {
                frmTerminado.ActualizarListaObras(listaObrasTerminado);
                frmTerminado.ActualizarDataGridView();
            }
        }

        private void btnAgendado_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmAgendado());
            ActivarBoton(btnAgendado);
        }

        private void btnIniciado_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmIniciado());
            ActivarBoton(btnIniciado);
        }

        private void btnTerminado_Click(object sender, EventArgs e)
        {
            abrirformhijo(new FrmTerminado());
            ActivarBoton(btnTerminado);
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
