namespace BRAHO_Project
{
    partial class FrmNuevos
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
            dgvNuevos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvNuevos).BeginInit();
            SuspendLayout();
            // 
            // dgvNuevos
            // 
            dgvNuevos.AllowUserToAddRows = false;
            dgvNuevos.AllowUserToDeleteRows = false;
            dgvNuevos.AllowUserToResizeColumns = false;
            dgvNuevos.AllowUserToResizeRows = false;
            dgvNuevos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNuevos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNuevos.BackgroundColor = Color.FromArgb(102, 102, 102);
            dgvNuevos.BorderStyle = BorderStyle.None;
            dgvNuevos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNuevos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvNuevos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvNuevos.ColumnHeadersHeight = 35;
            dgvNuevos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvNuevos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvNuevos.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvNuevos.EnableHeadersVisualStyles = false;
            dgvNuevos.Location = new Point(12, 12);
            dgvNuevos.Margin = new Padding(4);
            dgvNuevos.MultiSelect = false;
            dgvNuevos.Name = "dgvNuevos";
            dgvNuevos.ReadOnly = true;
            dgvNuevos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Transparent;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvNuevos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvNuevos.RowHeadersVisible = false;
            dgvNuevos.RowHeadersWidth = 51;
            dgvNuevos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 165, 11);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dgvNuevos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvNuevos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNuevos.Size = new Size(955, 447);
            dgvNuevos.TabIndex = 12;
            dgvNuevos.TabStop = false;
            dgvNuevos.CellClick += dgvUsuariosAgendadas_CellClick;
            dgvNuevos.CellPainting += dgvUsuariosAgendadas_CellPainting;
            // 
            // FrmNuevos
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(979, 471);
            Controls.Add(dgvNuevos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNuevos";
            Text = "Frmagendado";
            ((System.ComponentModel.ISupportInitialize)dgvNuevos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNuevos;
    }
}