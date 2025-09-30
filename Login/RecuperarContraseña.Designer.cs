namespace BRAHO_Project
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            MoverVentanaRecuperarContraseña = new Panel();
            BotonMininizar = new PictureBox();
            BotonCerrar = new PictureBox();
            txtRecuperarcion = new BRAHO_Project.RJControls.RJtextbox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BotonEnviarCodigo = new BRAHO_Project.RJControls.RJButton();
            rjButton1 = new BRAHO_Project.RJControls.RJButton();
            MoverVentanaRecuperarContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MoverVentanaRecuperarContraseña
            // 
            MoverVentanaRecuperarContraseña.BackColor = Color.FromArgb(102, 102, 102);
            MoverVentanaRecuperarContraseña.Controls.Add(BotonMininizar);
            MoverVentanaRecuperarContraseña.Controls.Add(BotonCerrar);
            MoverVentanaRecuperarContraseña.Dock = DockStyle.Top;
            MoverVentanaRecuperarContraseña.Location = new Point(0, 0);
            MoverVentanaRecuperarContraseña.Name = "MoverVentanaRecuperarContraseña";
            MoverVentanaRecuperarContraseña.Size = new Size(366, 45);
            MoverVentanaRecuperarContraseña.TabIndex = 1;
            MoverVentanaRecuperarContraseña.MouseDown += MoverVentanaRecuperarContraseña_MouseDown;
            // 
            // BotonMininizar
            // 
            BotonMininizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonMininizar.Cursor = Cursors.Hand;
            BotonMininizar.Image = (Image)resources.GetObject("BotonMininizar.Image");
            BotonMininizar.Location = new Point(298, 9);
            BotonMininizar.Name = "BotonMininizar";
            BotonMininizar.Size = new Size(29, 33);
            BotonMininizar.SizeMode = PictureBoxSizeMode.Zoom;
            BotonMininizar.TabIndex = 2;
            BotonMininizar.TabStop = false;
            // 
            // BotonCerrar
            // 
            BotonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonCerrar.Cursor = Cursors.Hand;
            BotonCerrar.Image = (Image)resources.GetObject("BotonCerrar.Image");
            BotonCerrar.Location = new Point(334, 7);
            BotonCerrar.Name = "BotonCerrar";
            BotonCerrar.Size = new Size(29, 33);
            BotonCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BotonCerrar.TabIndex = 1;
            BotonCerrar.TabStop = false;
            BotonCerrar.Click += BotonCerrar_Click;
            // 
            // txtRecuperarcion
            // 
            txtRecuperarcion.BackColor = Color.FromArgb(127, 127, 127);
            txtRecuperarcion.BorderColor = Color.FromArgb(255, 165, 11);
            txtRecuperarcion.BorderFocusColor = SystemColors.HotTrack;
            txtRecuperarcion.BorderSize = 6;
            txtRecuperarcion.CaretColor = Color.Black;
            txtRecuperarcion.CaretCustom = false;
            txtRecuperarcion.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRecuperarcion.ForeColor = Color.Black;
            txtRecuperarcion.Location = new Point(29, 319);
            txtRecuperarcion.Margin = new Padding(2, 3, 2, 3);
            txtRecuperarcion.MaxLength = 32767;
            txtRecuperarcion.Multiline = false;
            txtRecuperarcion.Name = "txtRecuperarcion";
            txtRecuperarcion.OnlyNumbers = false;
            txtRecuperarcion.Padding = new Padding(6, 5, 6, 5);
            txtRecuperarcion.PasswordChar = false;
            txtRecuperarcion.Size = new Size(309, 35);
            txtRecuperarcion.TabIndex = 0;
            txtRecuperarcion.Texts = "";
            txtRecuperarcion.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 287);
            label1.Name = "label1";
            label1.Size = new Size(193, 27);
            label1.TabIndex = 12;
            label1.Text = "Ingresa tu email";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // BotonEnviarCodigo
            // 
            BotonEnviarCodigo.BackColor = Color.FromArgb(255, 165, 11);
            BotonEnviarCodigo.BackgroundColor = Color.FromArgb(255, 165, 11);
            BotonEnviarCodigo.BorderColor = Color.PaleVioletRed;
            BotonEnviarCodigo.BorderRadius = 20;
            BotonEnviarCodigo.BorderSize = 0;
            BotonEnviarCodigo.FlatAppearance.BorderSize = 0;
            BotonEnviarCodigo.FlatStyle = FlatStyle.Flat;
            BotonEnviarCodigo.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonEnviarCodigo.ForeColor = Color.White;
            BotonEnviarCodigo.Location = new Point(192, 508);
            BotonEnviarCodigo.Margin = new Padding(3, 4, 3, 4);
            BotonEnviarCodigo.Name = "BotonEnviarCodigo";
            BotonEnviarCodigo.Size = new Size(153, 53);
            BotonEnviarCodigo.TabIndex = 2;
            BotonEnviarCodigo.Text = "Recuperar";
            BotonEnviarCodigo.TextColor = Color.White;
            BotonEnviarCodigo.UseVisualStyleBackColor = false;
            BotonEnviarCodigo.Click += BotonEnviarCodigo_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(127, 127, 127);
            rjButton1.BackgroundColor = Color.FromArgb(127, 127, 127);
            rjButton1.BorderColor = Color.Red;
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(19, 508);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(142, 53);
            rjButton1.TabIndex = 1;
            rjButton1.Text = "Cancelar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // RecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(127, 127, 127);
            ClientSize = new Size(366, 600);
            Controls.Add(rjButton1);
            Controls.Add(BotonEnviarCodigo);
            Controls.Add(pictureBox1);
            Controls.Add(txtRecuperarcion);
            Controls.Add(label1);
            Controls.Add(MoverVentanaRecuperarContraseña);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecuperarContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar contraseña";
            MoverVentanaRecuperarContraseña.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MoverVentanaRecuperarContraseña;
        private PictureBox BotonMininizar;
        private PictureBox BotonCerrar;
        private RJControls.RJtextbox txtRecuperarcion;
        private Label label1;
        private PictureBox pictureBox1;
        private RJControls.RJButton BotonEnviarCodigo;
        private RJControls.RJButton rjButton1;
    }
}