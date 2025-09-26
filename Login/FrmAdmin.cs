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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
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

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrEmpty(txtClave.Texts))
            {
                MessageBox.Show("Por favor, introduzca la clave.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (SqlConnection cn = ConexionBRAHOBD.ObtenerConexion())
                {
                    string query = "SELECT Clave FROM Administrador WHERE Clave = @clave";

                    SqlCommand cm = new SqlCommand(query, cn);
                    cm.Parameters.AddWithValue("@clave", txtClave.Texts.Trim());

                    SqlDataReader dr = cm.ExecuteReader();

                    if (dr.Read())
                    {
                        Form registrarse = new Registrarse();
                        registrarse.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Clave incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtClave.Texts = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
