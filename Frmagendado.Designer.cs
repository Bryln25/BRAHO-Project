namespace BRAHO_Project
{
    partial class Frmagendado
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
            dgvObrasAgendadas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvObrasAgendadas).BeginInit();
            SuspendLayout();
            // 
            // dgvObrasAgendadas
            // 
            dgvObrasAgendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObrasAgendadas.Location = new Point(12, 12);
            dgvObrasAgendadas.Name = "dgvObrasAgendadas";
            dgvObrasAgendadas.RowHeadersWidth = 51;
            dgvObrasAgendadas.Size = new Size(955, 447);
            dgvObrasAgendadas.TabIndex = 0;
            // 
            // Frmagendado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(979, 471);
            Controls.Add(dgvObrasAgendadas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmagendado";
            Text = "Frmagendado";
            ((System.ComponentModel.ISupportInitialize)dgvObrasAgendadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvObrasAgendadas;
    }
}