namespace BRAHO_Project
{
    partial class FrmTerminado
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
            dgvObrasTerminadas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvObrasTerminadas).BeginInit();
            SuspendLayout();
            // 
            // dgvObrasTerminadas
            // 
            dgvObrasTerminadas.AllowUserToAddRows = false;
            dgvObrasTerminadas.AllowUserToDeleteRows = false;
            dgvObrasTerminadas.AllowUserToResizeColumns = false;
            dgvObrasTerminadas.AllowUserToResizeRows = false;
            dgvObrasTerminadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvObrasTerminadas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvObrasTerminadas.BackgroundColor = Color.FromArgb(102, 102, 102);
            dgvObrasTerminadas.BorderStyle = BorderStyle.None;
            dgvObrasTerminadas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvObrasTerminadas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvObrasTerminadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvObrasTerminadas.ColumnHeadersHeight = 35;
            dgvObrasTerminadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvObrasTerminadas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvObrasTerminadas.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvObrasTerminadas.EnableHeadersVisualStyles = false;
            dgvObrasTerminadas.Location = new Point(12, 12);
            dgvObrasTerminadas.Margin = new Padding(4);
            dgvObrasTerminadas.MultiSelect = false;
            dgvObrasTerminadas.Name = "dgvObrasTerminadas";
            dgvObrasTerminadas.ReadOnly = true;
            dgvObrasTerminadas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvObrasTerminadas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvObrasTerminadas.RowHeadersVisible = false;
            dgvObrasTerminadas.RowHeadersWidth = 51;
            dgvObrasTerminadas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 165, 11);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvObrasTerminadas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvObrasTerminadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvObrasTerminadas.Size = new Size(955, 447);
            dgvObrasTerminadas.TabIndex = 13;
            dgvObrasTerminadas.TabStop = false;
            dgvObrasTerminadas.CellClick += dgvObrasTerminadas_CellClick;
            // 
            // FrmTerminado
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(979, 471);
            Controls.Add(dgvObrasTerminadas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTerminado";
            Text = "FrmTerminado";
            ((System.ComponentModel.ISupportInitialize)dgvObrasTerminadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvObrasTerminadas;
    }
}