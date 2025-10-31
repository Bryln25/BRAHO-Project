namespace BRAHO_Project
{
    partial class FrmCambiarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarContrasena));
            MoverVentanaRecuperarContraseña = new Panel();
            BotonMininizar = new PictureBox();
            BotonCerrar = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BotonEnviarCodigo = new BRAHO_Project.RJControls.RJButton();
            rjButton1 = new BRAHO_Project.RJControls.RJButton();
            BtnVerContraseña2 = new PictureBox();
            BtnVerContraseña1 = new PictureBox();
            label5 = new Label();
            txtConfirmarContraseña = new BRAHO_Project.RJControls.RJtextbox();
            label4 = new Label();
            txtNuevaContraseña = new BRAHO_Project.RJControls.RJtextbox();
            MoverVentanaRecuperarContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnVerContraseña2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnVerContraseña1).BeginInit();
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
            MoverVentanaRecuperarContraseña.Size = new Size(431, 45);
            MoverVentanaRecuperarContraseña.TabIndex = 1;
            MoverVentanaRecuperarContraseña.MouseDown += MoverVentanaRecuperarContraseña_MouseDown;
            // 
            // BotonMininizar
            // 
            BotonMininizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonMininizar.Cursor = Cursors.Hand;
            BotonMininizar.Image = (Image)resources.GetObject("BotonMininizar.Image");
            BotonMininizar.Location = new Point(363, 9);
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
            BotonCerrar.Location = new Point(399, 7);
            BotonCerrar.Name = "BotonCerrar";
            BotonCerrar.Size = new Size(29, 33);
            BotonCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BotonCerrar.TabIndex = 1;
            BotonCerrar.TabStop = false;
            BotonCerrar.Click += BotonCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 287);
            label1.Name = "label1";
            label1.Size = new Size(0, 27);
            label1.TabIndex = 12;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 68);
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
            BotonEnviarCodigo.Location = new Point(231, 508);
            BotonEnviarCodigo.Margin = new Padding(3, 4, 3, 4);
            BotonEnviarCodigo.Name = "BotonEnviarCodigo";
            BotonEnviarCodigo.Size = new Size(145, 53);
            BotonEnviarCodigo.TabIndex = 2;
            BotonEnviarCodigo.Text = "Actualizar";
            BotonEnviarCodigo.TextColor = Color.White;
            BotonEnviarCodigo.UseVisualStyleBackColor = false;
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
            rjButton1.Location = new Point(58, 508);
            rjButton1.Margin = new Padding(3, 4, 3, 4);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(142, 53);
            rjButton1.TabIndex = 1;
            rjButton1.Text = "Cancelar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // BtnVerContraseña2
            // 
            BtnVerContraseña2.Cursor = Cursors.Hand;
            BtnVerContraseña2.Image = Properties.Resources.visible1;
            BtnVerContraseña2.Location = new Point(323, 369);
            BtnVerContraseña2.Margin = new Padding(3, 4, 3, 4);
            BtnVerContraseña2.Name = "BtnVerContraseña2";
            BtnVerContraseña2.Size = new Size(40, 47);
            BtnVerContraseña2.SizeMode = PictureBoxSizeMode.Zoom;
            BtnVerContraseña2.TabIndex = 32;
            BtnVerContraseña2.TabStop = false;
            BtnVerContraseña2.Click += BtnVerContraseña2_Click;
            // 
            // BtnVerContraseña1
            // 
            BtnVerContraseña1.Cursor = Cursors.Hand;
            BtnVerContraseña1.Image = Properties.Resources.visible1;
            BtnVerContraseña1.Location = new Point(323, 251);
            BtnVerContraseña1.Margin = new Padding(3, 4, 3, 4);
            BtnVerContraseña1.Name = "BtnVerContraseña1";
            BtnVerContraseña1.Size = new Size(40, 47);
            BtnVerContraseña1.SizeMode = PictureBoxSizeMode.Zoom;
            BtnVerContraseña1.TabIndex = 31;
            BtnVerContraseña1.TabStop = false;
            BtnVerContraseña1.Click += BtnVerContraseña1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(64, 345);
            label5.Name = "label5";
            label5.Size = new Size(260, 27);
            label5.TabIndex = 30;
            label5.Text = "Confirmar contraseña";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.BackColor = Color.FromArgb(127, 127, 127);
            txtConfirmarContraseña.BorderColor = Color.FromArgb(255, 165, 11);
            txtConfirmarContraseña.BorderFocusColor = SystemColors.HotTrack;
            txtConfirmarContraseña.BorderSize = 6;
            txtConfirmarContraseña.CaretColor = Color.Black;
            txtConfirmarContraseña.CaretCustom = false;
            txtConfirmarContraseña.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConfirmarContraseña.ForeColor = Color.Black;
            txtConfirmarContraseña.Location = new Point(64, 381);
            txtConfirmarContraseña.Margin = new Padding(2, 3, 2, 3);
            txtConfirmarContraseña.MaxLength = 32767;
            txtConfirmarContraseña.Multiline = false;
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.OnlyNumbers = false;
            txtConfirmarContraseña.Padding = new Padding(6, 5, 6, 5);
            txtConfirmarContraseña.PasswordChar = true;
            txtConfirmarContraseña.Size = new Size(241, 35);
            txtConfirmarContraseña.TabIndex = 28;
            txtConfirmarContraseña.Texts = "";
            txtConfirmarContraseña.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(64, 227);
            label4.Name = "label4";
            label4.Size = new Size(228, 27);
            label4.TabIndex = 29;
            label4.Text = "Nueva Contraseña";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.BackColor = Color.FromArgb(127, 127, 127);
            txtNuevaContraseña.BorderColor = Color.FromArgb(255, 165, 11);
            txtNuevaContraseña.BorderFocusColor = SystemColors.HotTrack;
            txtNuevaContraseña.BorderSize = 6;
            txtNuevaContraseña.CaretColor = Color.Black;
            txtNuevaContraseña.CaretCustom = false;
            txtNuevaContraseña.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNuevaContraseña.ForeColor = Color.Black;
            txtNuevaContraseña.Location = new Point(64, 263);
            txtNuevaContraseña.Margin = new Padding(2, 3, 2, 3);
            txtNuevaContraseña.MaxLength = 32767;
            txtNuevaContraseña.Multiline = false;
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.OnlyNumbers = false;
            txtNuevaContraseña.Padding = new Padding(6, 5, 6, 5);
            txtNuevaContraseña.PasswordChar = true;
            txtNuevaContraseña.Size = new Size(241, 35);
            txtNuevaContraseña.TabIndex = 27;
            txtNuevaContraseña.Texts = "";
            txtNuevaContraseña.UnderlinedStyle = true;
            // 
            // FrmCambiarContrasena
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(127, 127, 127);
            ClientSize = new Size(431, 600);
            Controls.Add(BtnVerContraseña2);
            Controls.Add(BtnVerContraseña1);
            Controls.Add(label5);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(label4);
            Controls.Add(txtNuevaContraseña);
            Controls.Add(rjButton1);
            Controls.Add(BotonEnviarCodigo);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(MoverVentanaRecuperarContraseña);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCambiarContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar contraseña";
            MoverVentanaRecuperarContraseña.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnVerContraseña2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnVerContraseña1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MoverVentanaRecuperarContraseña;
        private PictureBox BotonMininizar;
        private PictureBox BotonCerrar;
        private Label label1;
        private PictureBox pictureBox1;
        private RJControls.RJButton BotonEnviarCodigo;
        private RJControls.RJButton rjButton1;
        private PictureBox BtnVerContraseña2;
        private PictureBox BtnVerContraseña1;
        private Label label5;
        private RJControls.RJtextbox txtConfirmarContraseña;
        private Label label4;
        private RJControls.RJtextbox txtNuevaContraseña;
    }
}