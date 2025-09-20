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
            dgvObrasIniciadas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvObrasIniciadas).BeginInit();
            SuspendLayout();
            // 
            // dgvObrasIniciadas
            // 
            dgvObrasIniciadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObrasIniciadas.Location = new Point(12, 12);
            dgvObrasIniciadas.Name = "dgvObrasIniciadas";
            dgvObrasIniciadas.RowHeadersWidth = 51;
            dgvObrasIniciadas.Size = new Size(955, 447);
            dgvObrasIniciadas.TabIndex = 2;
            // 
            // FrmTerminado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(979, 471);
            Controls.Add(dgvObrasIniciadas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTerminado";
            Text = "FrmTerminado";
            ((System.ComponentModel.ISupportInitialize)dgvObrasIniciadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvObrasIniciadas;
    }
}