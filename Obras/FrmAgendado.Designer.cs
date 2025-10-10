namespace BRAHO_Project
{
    partial class FrmAgendado
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
            dgvObrasAgendadas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvObrasAgendadas).BeginInit();
            SuspendLayout();
            // 
            // dgvObrasAgendadas
            // 
            dgvObrasAgendadas.AllowUserToAddRows = false;
            dgvObrasAgendadas.AllowUserToDeleteRows = false;
            dgvObrasAgendadas.AllowUserToResizeColumns = false;
            dgvObrasAgendadas.AllowUserToResizeRows = false;
            dgvObrasAgendadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvObrasAgendadas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvObrasAgendadas.BackgroundColor = Color.FromArgb(102, 102, 102);
            dgvObrasAgendadas.BorderStyle = BorderStyle.None;
            dgvObrasAgendadas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvObrasAgendadas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvObrasAgendadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvObrasAgendadas.ColumnHeadersHeight = 35;
            dgvObrasAgendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvObrasAgendadas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvObrasAgendadas.EnableHeadersVisualStyles = false;
            dgvObrasAgendadas.Location = new Point(11, 13);
            dgvObrasAgendadas.Margin = new Padding(4);
            dgvObrasAgendadas.Name = "dgvObrasAgendadas";
            dgvObrasAgendadas.ReadOnly = true;
            dgvObrasAgendadas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvObrasAgendadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvObrasAgendadas.RowHeadersVisible = false;
            dgvObrasAgendadas.RowHeadersWidth = 51;
            dgvObrasAgendadas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 165, 11);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvObrasAgendadas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvObrasAgendadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvObrasAgendadas.Size = new Size(955, 447);
            dgvObrasAgendadas.TabIndex = 12;
            dgvObrasAgendadas.TabStop = false;
            // 
            // FrmAgendado
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(979, 471);
            Controls.Add(dgvObrasAgendadas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAgendado";
            Text = "Frmagendado";
            ((System.ComponentModel.ISupportInitialize)dgvObrasAgendadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvObrasAgendadas;
    }
}