using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BRAHO_Project.Auditoria;
using Microsoft.Data.SqlClient;

namespace BRAHO_Project
{
    public partial class FrmAuditoria : Form
    {
        private List<Log> listaLog;
        private List<Log> listaLogOriginal = new List<Log>();

        public FrmAuditoria()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            MostrarGastos();
        }

        private void ConfigurarDataGridView()
        {

            dgvBuscar.EnableHeadersVisualStyles = false;
            dgvBuscar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvBuscar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBuscar.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dgvBuscar.GridColor = Color.Silver;
            dgvBuscar.RowHeadersVisible = false;
            dgvBuscar.BorderStyle = BorderStyle.FixedSingle;
            dgvBuscar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Crear columnas para tus datos de clientes
            dgvBuscar.Columns.Clear();

            DataGridViewTextBoxColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.Name = "Usuario";
            colUsuario.HeaderText = "USUARIO";
            colUsuario.FillWeight = 20;

            DataGridViewTextBoxColumn colAccion = new DataGridViewTextBoxColumn();
            colAccion.Name = "Acción";
            colAccion.HeaderText = "ACCIÖN";
            colAccion.FillWeight = 20;

            DataGridViewTextBoxColumn colDetalle = new DataGridViewTextBoxColumn();
            colDetalle.Name = "Detalle";
            colDetalle.HeaderText = "DETALLE";
            colDetalle.FillWeight = 18;

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.Name = "Fecha";
            colFecha.HeaderText = "FECHA";
            colFecha.FillWeight = 20;

            DataGridViewTextBoxColumn colEquipo = new DataGridViewTextBoxColumn();
            colEquipo.Name = "Equipo";
            colEquipo.HeaderText = "EQUIPO";
            colEquipo.FillWeight = 20;



            // Columnas de botones (usaremos imágenes)
            DataGridViewImageColumn colVer = new DataGridViewImageColumn();
            colVer.Name = "Ver";
            colVer.HeaderText = "";
            colVer.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colVer.FillWeight = 8;

            // Agregar todas las columnas
            dgvBuscar.Columns.AddRange(new DataGridViewColumn[] {
                colUsuario, colAccion, colDetalle, colFecha, colEquipo,colVer
            });
        }

        public void MostrarGastos()
        {
            listaLog = AuditoriaDAL.MostrarLog();

            if (listaLog != null)
            {
                listaLogOriginal = new List<Log>(listaLog);
            }
            else
            {
                listaLogOriginal = new List<Log>();
            }

            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            dgvBuscar.Rows.Clear();

            foreach (var log in listaLog)
            {
                int rowIndex = dgvBuscar.Rows.Add(
                    
                    log.Usuario,
                    log.Accion,
                    log.Detalle,
                    log.Fecha,
                    log.Equipo
                );

                // Asignar imágenes a las columnas de botones
                if (dgvBuscar.Rows[rowIndex].Cells["Ver"] is DataGridViewImageCell verCell)
                {
                    dgvBuscar.Cursor = Cursors.Hand;
                    verCell.Value = Properties.Resources.visible; // Tu imagen de ver
                    verCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    var log = listaLog[e.RowIndex];

            //    switch (dgvBuscar.Columns[e.ColumnIndex].Name)
            //    {
            //        case "Ver":
            //            if (dgvBuscar.CurrentRow != null)
            //            {
            //                DataGridViewRow fila = dgvBuscar.CurrentRow;

            //                FrmVerGastos frm = new FrmVerGastos(log, dgvBuscar);
            //                frm.ShowDialog();
            //                MostrarGastos();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Seleccione una fila antes de visualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            break;
            //    }
            //}
        }

        private void BotonCerr_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dgvBuscar_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita encabezados
            {
                string columnName = dgvBuscar.Columns[e.ColumnIndex].Name;

                if (columnName == "Ver")
                {
                    dgvBuscar.Cursor = Cursors.Hand; // cambia a mano SOLO en esas celdas
                }
            }
        }

        private void dgvBuscar_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvBuscar.Columns[e.ColumnIndex].Name;

                if (columnName == "Ver")
                {
                    dgvBuscar.Cursor = Cursors.Default; 
                }
            }
        }

  

        private bool FuerzaBruta(string texto, string patron)
        {
            if (string.IsNullOrEmpty(texto) || string.IsNullOrEmpty(patron))
                return false;

            int n = texto.Length;
            int m = patron.Length;

            for (int i = 0; i <= n - m; i++)
            {
                int j;

                for (j = 0; j < m; j++)
                {
                    if (texto[i + j] != patron[j])
                        break;
                }

                if (j == m)
                    return true;
            }

            return false;
        }

        private bool barraExpandida = false;

        private void btnLupa_Click(object sender, EventArgs e)
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

    }
}
