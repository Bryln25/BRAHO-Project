namespace BRAHO_Project
{
    partial class FrmObras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObras));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            BotonMininizar = new PictureBox();
            BotonCerrar = new PictureBox();
            BotonAgregarCliente = new BRAHO_Project.RJControls.RJButton();
            BotonCerr = new BRAHO_Project.RJControls.RJButton();
            panel1 = new Panel();
            btnTerminado = new BRAHO_Project.RJControls.RJButton();
            btnIniciado = new BRAHO_Project.RJControls.RJButton();
            btnAgendado = new BRAHO_Project.RJControls.RJButton();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1002, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // BotonMininizar
            // 
            BotonMininizar.Location = new Point(0, 0);
            BotonMininizar.Name = "BotonMininizar";
            BotonMininizar.Size = new Size(100, 50);
            BotonMininizar.TabIndex = 0;
            BotonMininizar.TabStop = false;
            // 
            // BotonCerrar
            // 
            BotonCerrar.Location = new Point(0, 0);
            BotonCerrar.Name = "BotonCerrar";
            BotonCerrar.Size = new Size(100, 50);
            BotonCerrar.TabIndex = 0;
            BotonCerrar.TabStop = false;
            // 
            // BotonAgregarCliente
            // 
            BotonAgregarCliente.BackColor = Color.FromArgb(255, 165, 11);
            BotonAgregarCliente.BackgroundColor = Color.FromArgb(255, 165, 11);
            BotonAgregarCliente.BorderColor = Color.PaleVioletRed;
            BotonAgregarCliente.BorderRadius = 20;
            BotonAgregarCliente.BorderSize = 0;
            BotonAgregarCliente.Cursor = Cursors.Hand;
            BotonAgregarCliente.FlatAppearance.BorderSize = 0;
            BotonAgregarCliente.FlatStyle = FlatStyle.Flat;
            BotonAgregarCliente.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonAgregarCliente.ForeColor = Color.White;
            BotonAgregarCliente.Location = new Point(1061, 167);
            BotonAgregarCliente.Margin = new Padding(3, 4, 3, 4);
            BotonAgregarCliente.Name = "BotonAgregarCliente";
            BotonAgregarCliente.Size = new Size(151, 53);
            BotonAgregarCliente.TabIndex = 12;
            BotonAgregarCliente.Text = "Agregar";
            BotonAgregarCliente.TextColor = Color.White;
            BotonAgregarCliente.UseVisualStyleBackColor = false;
            // 
            // BotonCerr
            // 
            BotonCerr.BackColor = Color.Transparent;
            BotonCerr.BackgroundColor = Color.Transparent;
            BotonCerr.BorderColor = Color.PaleVioletRed;
            BotonCerr.BorderRadius = 20;
            BotonCerr.BorderSize = 0;
            BotonCerr.Cursor = Cursors.Hand;
            BotonCerr.FlatAppearance.BorderSize = 0;
            BotonCerr.FlatStyle = FlatStyle.Flat;
            BotonCerr.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonCerr.ForeColor = Color.White;
            BotonCerr.Location = new Point(1061, 320);
            BotonCerr.Margin = new Padding(3, 4, 3, 4);
            BotonCerr.Name = "BotonCerr";
            BotonCerr.Size = new Size(151, 53);
            BotonCerr.TabIndex = 13;
            BotonCerr.Text = "Cerrar";
            BotonCerr.TextColor = Color.White;
            BotonCerr.UseVisualStyleBackColor = false;
            BotonCerr.Click += BotonCerr_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTerminado);
            panel1.Controls.Add(btnIniciado);
            panel1.Controls.Add(btnAgendado);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(29, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 542);
            panel1.TabIndex = 14;
            // 
            // btnTerminado
            // 
            btnTerminado.BackColor = Color.FromArgb(255, 165, 11);
            btnTerminado.BackgroundColor = Color.FromArgb(255, 165, 11);
            btnTerminado.BorderColor = Color.PaleVioletRed;
            btnTerminado.BorderRadius = 20;
            btnTerminado.BorderSize = 0;
            btnTerminado.Cursor = Cursors.Hand;
            btnTerminado.FlatAppearance.BorderSize = 0;
            btnTerminado.FlatStyle = FlatStyle.Flat;
            btnTerminado.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTerminado.ForeColor = Color.White;
            btnTerminado.Location = new Point(327, 9);
            btnTerminado.Margin = new Padding(3, 4, 3, 4);
            btnTerminado.Name = "btnTerminado";
            btnTerminado.Size = new Size(151, 53);
            btnTerminado.TabIndex = 13;
            btnTerminado.Text = "Terminado";
            btnTerminado.TextColor = Color.White;
            btnTerminado.UseVisualStyleBackColor = false;
            btnTerminado.Click += btnTerminado_Click;
            // 
            // btnIniciado
            // 
            btnIniciado.BackColor = Color.FromArgb(255, 165, 11);
            btnIniciado.BackgroundColor = Color.FromArgb(255, 165, 11);
            btnIniciado.BorderColor = Color.PaleVioletRed;
            btnIniciado.BorderRadius = 20;
            btnIniciado.BorderSize = 0;
            btnIniciado.Cursor = Cursors.Hand;
            btnIniciado.FlatAppearance.BorderSize = 0;
            btnIniciado.FlatStyle = FlatStyle.Flat;
            btnIniciado.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciado.ForeColor = Color.White;
            btnIniciado.Location = new Point(169, 9);
            btnIniciado.Margin = new Padding(3, 4, 3, 4);
            btnIniciado.Name = "btnIniciado";
            btnIniciado.Size = new Size(151, 53);
            btnIniciado.TabIndex = 14;
            btnIniciado.Text = "Iniciado";
            btnIniciado.TextColor = Color.White;
            btnIniciado.UseVisualStyleBackColor = false;
            btnIniciado.Click += btnIniciado_Click;
            // 
            // btnAgendado
            // 
            btnAgendado.BackColor = Color.FromArgb(255, 165, 11);
            btnAgendado.BackgroundColor = Color.FromArgb(255, 165, 11);
            btnAgendado.BorderColor = Color.PaleVioletRed;
            btnAgendado.BorderRadius = 20;
            btnAgendado.BorderSize = 0;
            btnAgendado.Cursor = Cursors.Hand;
            btnAgendado.FlatAppearance.BorderSize = 0;
            btnAgendado.FlatStyle = FlatStyle.Flat;
            btnAgendado.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgendado.ForeColor = Color.White;
            btnAgendado.Location = new Point(12, 9);
            btnAgendado.Margin = new Padding(3, 4, 3, 4);
            btnAgendado.Name = "btnAgendado";
            btnAgendado.Size = new Size(151, 53);
            btnAgendado.TabIndex = 13;
            btnAgendado.Text = "Agendado";
            btnAgendado.TextColor = Color.White;
            btnAgendado.UseVisualStyleBackColor = false;
            btnAgendado.Click += btnAgendado_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 471);
            panel2.TabIndex = 0;
            // 
            // FrmObras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1041, 617);
            Controls.Add(panel1);
            Controls.Add(BotonCerr);
            Controls.Add(BotonAgregarCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmObras";
            Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox BotonMininizar;
        private PictureBox BotonCerrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox BtnMinimizar;
        private PictureBox BtnSalir;
        private RJControls.RJButton BotonAgregarCliente;
        private RJControls.RJButton BotonCerr;
        private Panel panel1;
        private Panel panel2;
        private RJControls.RJButton btnTerminado;
        private RJControls.RJButton btnIniciado;
        private RJControls.RJButton btnAgendado;
    }
}