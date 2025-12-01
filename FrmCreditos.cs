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
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public partial class FrmCreditos : Form
    {
        public FrmCreditos()
        {
            InitializeComponent();
            Funciones.RedondearForm(this);
            Funciones.RedondearImagen(fotoAndrews);
            Funciones.RedondearImagen(fotoBraylin);
        }

        //Codigo para mover el formulario
        private void MoverVentana_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form iniciodesesion = new IniciodeSesion();
            iniciodesesion.Show();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
