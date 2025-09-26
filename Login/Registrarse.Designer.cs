namespace BRAHO_Project
{
    partial class Registrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrarse));
            MoverVentanaRegistrarse = new Panel();
            BotonMinimizarRegistrarse = new PictureBox();
            BotonCerrarRegistrarse = new PictureBox();
            txtUsuario = new BRAHO_Project.RJControls.RJtextbox();
            label1 = new Label();
            label2 = new Label();
            txtCorreo = new BRAHO_Project.RJControls.RJtextbox();
            label3 = new Label();
            txtNombreApellido = new BRAHO_Project.RJControls.RJtextbox();
            label4 = new Label();
            txtContraseña = new BRAHO_Project.RJControls.RJtextbox();
            label5 = new Label();
            txtConfirmarContraseña = new BRAHO_Project.RJControls.RJtextbox();
            pictureBox1 = new PictureBox();
            BotonCrearCuenta = new BRAHO_Project.RJControls.RJButton();
            rjButton1 = new BRAHO_Project.RJControls.RJButton();
            BtnVerContraseña1 = new PictureBox();
            BtnVerContraseña2 = new PictureBox();
            MoverVentanaRegistrarse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BotonMinimizarRegistrarse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrarRegistrarse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnVerContraseña1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnVerContraseña2).BeginInit();
            SuspendLayout();
            // 
            // MoverVentanaRegistrarse
            // 
            MoverVentanaRegistrarse.BackColor = Color.FromArgb(102, 102, 102);
            MoverVentanaRegistrarse.Controls.Add(BotonMinimizarRegistrarse);
            MoverVentanaRegistrarse.Controls.Add(BotonCerrarRegistrarse);
            MoverVentanaRegistrarse.Dock = DockStyle.Top;
            MoverVentanaRegistrarse.Location = new Point(0, 0);
            MoverVentanaRegistrarse.Margin = new Padding(3, 2, 3, 2);
            MoverVentanaRegistrarse.Name = "MoverVentanaRegistrarse";
            MoverVentanaRegistrarse.Size = new Size(552, 34);
            MoverVentanaRegistrarse.TabIndex = 1;
            MoverVentanaRegistrarse.MouseDown += MoverVentanaRegistrarse_MouseDown;
            // 
            // BotonMinimizarRegistrarse
            // 
            BotonMinimizarRegistrarse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonMinimizarRegistrarse.Cursor = Cursors.Hand;
            BotonMinimizarRegistrarse.Image = (Image)resources.GetObject("BotonMinimizarRegistrarse.Image");
            BotonMinimizarRegistrarse.Location = new Point(487, 4);
            BotonMinimizarRegistrarse.Margin = new Padding(3, 2, 3, 2);
            BotonMinimizarRegistrarse.Name = "BotonMinimizarRegistrarse";
            BotonMinimizarRegistrarse.Size = new Size(25, 25);
            BotonMinimizarRegistrarse.SizeMode = PictureBoxSizeMode.Zoom;
            BotonMinimizarRegistrarse.TabIndex = 4;
            BotonMinimizarRegistrarse.TabStop = false;
            BotonMinimizarRegistrarse.Click += BotonMinimizarRegistrarse_Click;
            // 
            // BotonCerrarRegistrarse
            // 
            BotonCerrarRegistrarse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonCerrarRegistrarse.Cursor = Cursors.Hand;
            BotonCerrarRegistrarse.Image = (Image)resources.GetObject("BotonCerrarRegistrarse.Image");
            BotonCerrarRegistrarse.Location = new Point(524, 4);
            BotonCerrarRegistrarse.Margin = new Padding(3, 2, 3, 2);
            BotonCerrarRegistrarse.Name = "BotonCerrarRegistrarse";
            BotonCerrarRegistrarse.Size = new Size(25, 25);
            BotonCerrarRegistrarse.SizeMode = PictureBoxSizeMode.Zoom;
            BotonCerrarRegistrarse.TabIndex = 3;
            BotonCerrarRegistrarse.TabStop = false;
            BotonCerrarRegistrarse.Click += BotonCerrarRegistrarse_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(127, 127, 127);
            txtUsuario.BorderColor = Color.FromArgb(255, 165, 11);
            txtUsuario.BorderFocusColor = SystemColors.HotTrack;
            txtUsuario.BorderSize = 6;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(35, 284);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(5, 4, 5, 4);
            txtUsuario.PasswordChar = false;
            txtUsuario.Size = new Size(192, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.Texts = "";
            txtUsuario.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 257);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 13;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 330);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 15;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(127, 127, 127);
            txtCorreo.BorderColor = Color.FromArgb(255, 165, 11);
            txtCorreo.BorderFocusColor = SystemColors.HotTrack;
            txtCorreo.BorderSize = 6;
            txtCorreo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(35, 357);
            txtCorreo.Margin = new Padding(2);
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(5, 4, 5, 4);
            txtCorreo.PasswordChar = false;
            txtCorreo.Size = new Size(192, 27);
            txtCorreo.TabIndex = 2;
            txtCorreo.Texts = "";
            txtCorreo.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 179);
            label3.Name = "label3";
            label3.Size = new Size(191, 22);
            label3.TabIndex = 17;
            label3.Text = "Nombres y apellidos";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.BackColor = Color.FromArgb(127, 127, 127);
            txtNombreApellido.BorderColor = Color.FromArgb(255, 165, 11);
            txtNombreApellido.BorderFocusColor = SystemColors.HotTrack;
            txtNombreApellido.BorderSize = 6;
            txtNombreApellido.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreApellido.ForeColor = Color.Black;
            txtNombreApellido.Location = new Point(35, 206);
            txtNombreApellido.Margin = new Padding(2);
            txtNombreApellido.Multiline = false;
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Padding = new Padding(5, 4, 5, 4);
            txtNombreApellido.PasswordChar = false;
            txtNombreApellido.Size = new Size(192, 27);
            txtNombreApellido.TabIndex = 0;
            txtNombreApellido.Texts = "";
            txtNombreApellido.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(267, 179);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 19;
            label4.Text = "Contraseña";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(127, 127, 127);
            txtContraseña.BorderColor = Color.FromArgb(255, 165, 11);
            txtContraseña.BorderFocusColor = SystemColors.HotTrack;
            txtContraseña.BorderSize = 6;
            txtContraseña.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.Location = new Point(267, 206);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Padding = new Padding(5, 4, 5, 4);
            txtContraseña.PasswordChar = true;
            txtContraseña.Size = new Size(211, 27);
            txtContraseña.TabIndex = 3;
            txtContraseña.Texts = "";
            txtContraseña.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(267, 257);
            label5.Name = "label5";
            label5.Size = new Size(211, 22);
            label5.TabIndex = 21;
            label5.Text = "Confirmar contraseña";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.BackColor = Color.FromArgb(127, 127, 127);
            txtConfirmarContraseña.BorderColor = Color.FromArgb(255, 165, 11);
            txtConfirmarContraseña.BorderFocusColor = SystemColors.HotTrack;
            txtConfirmarContraseña.BorderSize = 6;
            txtConfirmarContraseña.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConfirmarContraseña.ForeColor = Color.Black;
            txtConfirmarContraseña.Location = new Point(267, 284);
            txtConfirmarContraseña.Margin = new Padding(2);
            txtConfirmarContraseña.Multiline = false;
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Padding = new Padding(5, 4, 5, 4);
            txtConfirmarContraseña.PasswordChar = true;
            txtConfirmarContraseña.Size = new Size(211, 27);
            txtConfirmarContraseña.TabIndex = 4;
            txtConfirmarContraseña.Texts = "";
            txtConfirmarContraseña.UnderlinedStyle = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 46);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // BotonCrearCuenta
            // 
            BotonCrearCuenta.BackColor = Color.FromArgb(255, 165, 11);
            BotonCrearCuenta.BackgroundColor = Color.FromArgb(255, 165, 11);
            BotonCrearCuenta.BorderColor = Color.PaleVioletRed;
            BotonCrearCuenta.BorderRadius = 20;
            BotonCrearCuenta.BorderSize = 0;
            BotonCrearCuenta.FlatAppearance.BorderSize = 0;
            BotonCrearCuenta.FlatStyle = FlatStyle.Flat;
            BotonCrearCuenta.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonCrearCuenta.ForeColor = Color.White;
            BotonCrearCuenta.Location = new Point(302, 418);
            BotonCrearCuenta.Name = "BotonCrearCuenta";
            BotonCrearCuenta.Size = new Size(162, 40);
            BotonCrearCuenta.TabIndex = 5;
            BotonCrearCuenta.Text = "Crear cuenta";
            BotonCrearCuenta.TextColor = Color.White;
            BotonCrearCuenta.UseVisualStyleBackColor = false;
            BotonCrearCuenta.Click += BotonCrearCuenta_Click;
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
            rjButton1.Location = new Point(78, 418);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 6;
            rjButton1.Text = "Cancelar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // BtnVerContraseña1
            // 
            BtnVerContraseña1.Cursor = Cursors.Hand;
            BtnVerContraseña1.Image = Properties.Resources.visible1;
            BtnVerContraseña1.Location = new Point(490, 206);
            BtnVerContraseña1.Name = "BtnVerContraseña1";
            BtnVerContraseña1.Size = new Size(35, 35);
            BtnVerContraseña1.SizeMode = PictureBoxSizeMode.Zoom;
            BtnVerContraseña1.TabIndex = 25;
            BtnVerContraseña1.TabStop = false;
            BtnVerContraseña1.Click += BtnVerContraseña1_Click;
            // 
            // BtnVerContraseña2
            // 
            BtnVerContraseña2.Cursor = Cursors.Hand;
            BtnVerContraseña2.Image = Properties.Resources.visible1;
            BtnVerContraseña2.Location = new Point(490, 284);
            BtnVerContraseña2.Name = "BtnVerContraseña2";
            BtnVerContraseña2.Size = new Size(35, 35);
            BtnVerContraseña2.SizeMode = PictureBoxSizeMode.Zoom;
            BtnVerContraseña2.TabIndex = 26;
            BtnVerContraseña2.TabStop = false;
            BtnVerContraseña2.Click += BtnVerContraseña2_Click;
            // 
            // Registrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 127, 127);
            ClientSize = new Size(552, 491);
            Controls.Add(BtnVerContraseña2);
            Controls.Add(BtnVerContraseña1);
            Controls.Add(rjButton1);
            Controls.Add(BotonCrearCuenta);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(label4);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(txtNombreApellido);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(MoverVentanaRegistrarse);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registrarse";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            MoverVentanaRegistrarse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BotonMinimizarRegistrarse).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrarRegistrarse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnVerContraseña1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnVerContraseña2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MoverVentanaRegistrarse;
        private PictureBox BotonMinimizarRegistrarse;
        private PictureBox BotonCerrarRegistrarse;
        private RJControls.RJtextbox txtUsuario;
        private Label label1;
        private Label label2;
        private RJControls.RJtextbox txtCorreo;
        private Label label3;
        private RJControls.RJtextbox txtNombreApellido;
        private Label label4;
        private RJControls.RJtextbox txtContraseña;
        private Label label5;
        private RJControls.RJtextbox txtConfirmarContraseña;
        private PictureBox pictureBox1;
        private RJControls.RJButton BotonCrearCuenta;
        private RJControls.RJButton rjButton1;
        private PictureBox BtnVerContraseña1;
        private PictureBox BtnVerContraseña2;
    }
}