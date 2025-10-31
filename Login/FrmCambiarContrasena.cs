using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using static BRAHO_Project.ConexionBRAHOBD;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public partial class FrmCambiarContrasena : Form
    {
        string email;
        public FrmCambiarContrasena(string email)
        {
            InitializeComponent();
            Funciones.RedondearForm(this);
            this.email = email;
        }

        //Codigo para mover el formulario
        private void MoverVentanaRecuperarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            Funciones.MoverForm(this);
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Form iniciodesesion = new IniciodeSesion();
            iniciodesesion.Show();
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form iniciodesesion = new IniciodeSesion();
            iniciodesesion.Show();
            this.Close();
        }

    }
}
