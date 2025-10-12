namespace BRAHO_Project
{
    partial class FrmIniciado
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvObrasIniciadas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvObrasIniciadas).BeginInit();
            SuspendLayout();
            // 
            // dgvObrasIniciadas
            // 
            dgvObrasIniciadas.AllowUserToAddRows = false;
            dgvObrasIniciadas.AllowUserToDeleteRows = false;
            dgvObrasIniciadas.AllowUserToResizeColumns = false;
            dgvObrasIniciadas.AllowUserToResizeRows = false;
            dgvObrasIniciadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvObrasIniciadas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvObrasIniciadas.BackgroundColor = Color.FromArgb(102, 102, 102);
            dgvObrasIniciadas.BorderStyle = BorderStyle.None;
            dgvObrasIniciadas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvObrasIniciadas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvObrasIniciadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvObrasIniciadas.ColumnHeadersHeight = 35;
            dgvObrasIniciadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvObrasIniciadas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvObrasIniciadas.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvObrasIniciadas.EnableHeadersVisualStyles = false;
            dgvObrasIniciadas.Location = new Point(12, 12);
            dgvObrasIniciadas.Margin = new Padding(4);
            dgvObrasIniciadas.MultiSelect = false;
            dgvObrasIniciadas.Name = "dgvObrasIniciadas";
            dgvObrasIniciadas.ReadOnly = true;
            dgvObrasIniciadas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvObrasIniciadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvObrasIniciadas.RowHeadersVisible = false;
            dgvObrasIniciadas.RowHeadersWidth = 51;
            dgvObrasIniciadas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 165, 11);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvObrasIniciadas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvObrasIniciadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvObrasIniciadas.Size = new Size(955, 447);
            dgvObrasIniciadas.TabIndex = 13;
            dgvObrasIniciadas.TabStop = false;
            dgvObrasIniciadas.CellClick += dgvObrasIniciadas_CellClick;
            // 
            // FrmIniciado
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(979, 471);
            Controls.Add(dgvObrasIniciadas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmIniciado";
            Text = "FrmIniciado";
            ((System.ComponentModel.ISupportInitialize)dgvObrasIniciadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvObrasIniciadas;
    }
}