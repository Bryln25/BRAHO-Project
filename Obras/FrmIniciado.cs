﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRAHO_Project
{
    public partial class FrmIniciado : Form
    {
        private List<Obras> listaObras;
        private List<Obras> listaObrasOriginal = new List<Obras>();

        public FrmIniciado()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            MostrarObras();

        }

        public DataGridView dgv
        {
            get { return dgvObrasIniciadas; }
        }

        private void ConfigurarDataGridView()
        {
            dgvObrasIniciadas.EnableHeadersVisualStyles = false;
            dgvObrasIniciadas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvObrasIniciadas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvObrasIniciadas.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dgvObrasIniciadas.GridColor = Color.Silver;
            dgvObrasIniciadas.RowHeadersVisible = false;
            dgvObrasIniciadas.BorderStyle = BorderStyle.FixedSingle;
            dgvObrasIniciadas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvObrasIniciadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Crear columnas para tus datos de clientes
            dgvObrasIniciadas.Columns.Clear();

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "Nombre";
            colNombre.HeaderText = "NOMBRE";
            colNombre.FillWeight = 20;

            DataGridViewTextBoxColumn colTipo = new DataGridViewTextBoxColumn();
            colTipo.Name = "TipoObra";
            colTipo.HeaderText = "TIPO";
            colTipo.FillWeight = 20;

            DataGridViewTextBoxColumn colUbicacion = new DataGridViewTextBoxColumn();
            colUbicacion.Name = "Ubicacion";
            colUbicacion.HeaderText = "UBICACIÓN";
            colUbicacion.FillWeight = 18;

            DataGridViewTextBoxColumn colFechaInicio = new DataGridViewTextBoxColumn();
            colFechaInicio.Name = "FechaInicio";
            colFechaInicio.HeaderText = "FECHA INICIO";
            colFechaInicio.FillWeight = 20;

            DataGridViewTextBoxColumn colFechaFinal = new DataGridViewTextBoxColumn();
            colFechaFinal.Name = "FechaFinal";
            colFechaFinal.HeaderText = "FECHA FINAL";
            colFechaFinal.FillWeight = 20;

            DataGridViewTextBoxColumn colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "Estado";
            colEstado.HeaderText = "ESTADO";
            colEstado.FillWeight = 20;

            // Columnas de botones (usaremos imágenes)
            DataGridViewImageColumn colVer = new DataGridViewImageColumn();
            colVer.Name = "Ver";
            colVer.HeaderText = "";
            colVer.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colVer.FillWeight = 8;

            DataGridViewImageColumn colEditar = new DataGridViewImageColumn();
            colEditar.Name = "Editar";
            colEditar.HeaderText = "";
            colEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEditar.FillWeight = 8;

            DataGridViewImageColumn colEliminar = new DataGridViewImageColumn();
            colEliminar.Name = "Eliminar";
            colEliminar.HeaderText = "";
            colEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEliminar.FillWeight = 8;

            // Agregar todas las columnas
            dgvObrasIniciadas.Columns.AddRange(new DataGridViewColumn[] {
                colNombre, colTipo, colUbicacion, colFechaInicio, colFechaFinal,
                colEstado, colVer, colEditar, colEliminar
            });
        }

        public void MostrarObras()
        {
            listaObras = ObrasDAL.MostrarIniciado();

            if (listaObras != null)
            {
                listaObrasOriginal = new List<Obras>(listaObras);
            }
            else
            {
                listaObrasOriginal = new List<Obras>();
            }

            ActualizarDataGridView();
        }

        public void FiltarDataGridView(string filtro)
        {
            listaObras = ObrasDAL.MostrarIniciado();
            if (listaObras != null)
            {
                listaObrasOriginal = new List<Obras>(listaObras);
            }
            else
            {
                listaObrasOriginal = new List<Obras>();
            }

            if (string.IsNullOrEmpty(filtro))
            {
                listaObras = new List<Obras>(listaObrasOriginal);
            }
            else
            {
                listaObras = listaObrasOriginal.Where(c =>
                    (c.NombreObra?.ToLower() ?? "").Contains(filtro) ||
                    (c.TipoObra?.ToLower() ?? "").Contains(filtro) ||
                    (c.Ubicacion?.ToLower() ?? "").Contains(filtro) ||
                    (c.FechaInicio?.ToLower() ?? "").Contains(filtro) ||
                    (c.FechaFinal?.ToLower() ?? "").Contains(filtro)
                ).ToList();
            }

            ActualizarDataGridView();
        }

        public void ActualizarDataGridView()
        {
            dgvObrasIniciadas.Rows.Clear();

            foreach (var obra in listaObras)
            {

                int rowIndex = dgvObrasIniciadas.Rows.Add(
                    obra.NombreObra,
                    obra.TipoObra,
                    obra.Ubicacion,
                    obra.FechaInicio,
                    obra.FechaFinal,
                    obra.Estado
                );

                // Asignar imágenes a las columnas de botones
                if (dgvObrasIniciadas.Rows[rowIndex].Cells["Ver"] is DataGridViewImageCell verCell)
                {
                    dgvObrasIniciadas.Cursor = Cursors.Hand;
                    verCell.Value = Properties.Resources.visible; // Tu imagen de ver
                    verCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                if (dgvObrasIniciadas.Rows[rowIndex].Cells["Editar"] is DataGridViewImageCell editarCell)
                {
                    dgvObrasIniciadas.Cursor = Cursors.Hand;
                    editarCell.Value = Properties.Resources.editar; // Tu imagen de editar
                    editarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }

                if (dgvObrasIniciadas.Rows[rowIndex].Cells["Eliminar"] is DataGridViewImageCell eliminarCell)
                {
                    dgvObrasIniciadas.Cursor = Cursors.Hand;
                    eliminarCell.Value = Properties.Resources.cerrar; // Tu imagen de eliminar
                    eliminarCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }

        private void dgvObrasIniciadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var obra = listaObras[e.RowIndex];

                switch (dgvObrasIniciadas.Columns[e.ColumnIndex].Name)
                {
                    case "Ver":
                        break;
                    //jodemos depue

                    case "Editar":
                        if (dgvObrasIniciadas.CurrentRow != null) // valida que haya fila seleccionada
                        {
                            DataGridViewRow fila = dgvObrasIniciadas.CurrentRow;

                            // Crear el formulario destino

                            FrmEditarObra frm = new FrmEditarObra(obra, dgvObrasIniciadas);
                            frm.ShowDialog();
                            MostrarObras(); // Refrescar la lista después de editar
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una fila antes de editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                        break;

                    case "Eliminar":
                        if (MessageBox.Show($"¿Está seguro que desea eliminar esta obra?",
                            "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Eliminar de la base de datos
                            int resultado = ObrasDAL.EliminarObra(obra.IdObra);

                            if (resultado > 0)
                            {
                                MessageBox.Show("Obra eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar la obra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            listaObras.RemoveAt(e.RowIndex);
                            ActualizarDataGridView();
                        }
                        break;
                }
            }
        }

        private void dgvObrasIniciadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                if (dgv.Columns[e.ColumnIndex].Name == "Estado")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                    string texto = e.Value?.ToString() ?? "";
                    Color colorFondo = Color.FromArgb(33, 150, 243);

                    // Crear badge redondeado
                    int padding = 8;
                    Size textSize = TextRenderer.MeasureText(texto, e.CellStyle.Font);
                    int badgeWidth = textSize.Width + padding * 2;
                    int badgeHeight = textSize.Height + 4;

                    Rectangle badgeRect = new Rectangle(
                        e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2,
                        e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2,
                        badgeWidth,
                        badgeHeight
                    );

                    using (GraphicsPath path = Funciones.GetRoundedRectangle(badgeRect, 12))
                    {
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        using (Brush brush = new SolidBrush(colorFondo))
                        {
                            e.Graphics.FillPath(brush, path);
                        }
                    }

                    TextRenderer.DrawText(e.Graphics, texto,
                        new Font("Segoe UI", 8, FontStyle.Bold),
                        badgeRect, Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;
                }
            }
        }
    }
}
