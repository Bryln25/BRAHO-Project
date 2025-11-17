namespace BRAHO_Project
{
    partial class FrmProcesados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvProcesados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProcesados).BeginInit();
            SuspendLayout();
            // 
            // dgvProcesados
            // 
            dgvProcesados.AllowUserToAddRows = false;
            dgvProcesados.AllowUserToDeleteRows = false;
            dgvProcesados.AllowUserToResizeColumns = false;
            dgvProcesados.AllowUserToResizeRows = false;
            dgvProcesados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProcesados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProcesados.BackgroundColor = Color.FromArgb(102, 102, 102);
            dgvProcesados.BorderStyle = BorderStyle.None;
            dgvProcesados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProcesados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProcesados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProcesados.ColumnHeadersHeight = 35;
            dgvProcesados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvProcesados.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProcesados.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvProcesados.EnableHeadersVisualStyles = false;
            dgvProcesados.Location = new Point(12, 12);
            dgvProcesados.Margin = new Padding(4);
            dgvProcesados.MultiSelect = false;
            dgvProcesados.Name = "dgvProcesados";
            dgvProcesados.ReadOnly = true;
            dgvProcesados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Transparent;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvProcesados.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvProcesados.RowHeadersVisible = false;
            dgvProcesados.RowHeadersWidth = 51;
            dgvProcesados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 165, 11);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dgvProcesados.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvProcesados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProcesados.Size = new Size(955, 447);
            dgvProcesados.TabIndex = 12;
            dgvProcesados.TabStop = false;
            dgvProcesados.CellClick += dgvUsuariosAgendadas_CellClick;
            dgvProcesados.CellPainting += dgvUsuariosAgendadas_CellPainting;
            // 
            // FrmProcesados
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(979, 471);
            Controls.Add(dgvProcesados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProcesados";
            Text = "Frmagendado";
            ((System.ComponentModel.ISupportInitialize)dgvProcesados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProcesados;
    }
}