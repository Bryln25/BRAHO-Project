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
            txtcorreo = new BRAHO_Project.RJControls.RJtextbox();
            label3 = new Label();
            txtcedula = new BRAHO_Project.RJControls.RJtextbox();
            label4 = new Label();
            txtcontraseña = new BRAHO_Project.RJControls.RJtextbox();
            label5 = new Label();
            txtconfirmarcontraseña = new BRAHO_Project.RJControls.RJtextbox();
            pictureBox1 = new PictureBox();
            MoverVentanaRegistrarse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BotonMinimizarRegistrarse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrarRegistrarse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            txtUsuario.TabIndex = 12;
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
            // txtcorreo
            // 
            txtcorreo.BackColor = Color.FromArgb(127, 127, 127);
            txtcorreo.BorderColor = Color.FromArgb(255, 165, 11);
            txtcorreo.BorderFocusColor = SystemColors.HotTrack;
            txtcorreo.BorderSize = 6;
            txtcorreo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcorreo.ForeColor = Color.Black;
            txtcorreo.Location = new Point(35, 357);
            txtcorreo.Margin = new Padding(2);
            txtcorreo.Multiline = false;
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Padding = new Padding(5, 4, 5, 4);
            txtcorreo.PasswordChar = false;
            txtcorreo.Size = new Size(192, 27);
            txtcorreo.TabIndex = 14;
            txtcorreo.Texts = "";
            txtcorreo.UnderlinedStyle = true;
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
            // txtcedula
            // 
            txtcedula.BackColor = Color.FromArgb(127, 127, 127);
            txtcedula.BorderColor = Color.FromArgb(255, 165, 11);
            txtcedula.BorderFocusColor = SystemColors.HotTrack;
            txtcedula.BorderSize = 6;
            txtcedula.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcedula.ForeColor = Color.Black;
            txtcedula.Location = new Point(35, 206);
            txtcedula.Margin = new Padding(2);
            txtcedula.Multiline = false;
            txtcedula.Name = "txtcedula";
            txtcedula.Padding = new Padding(5, 4, 5, 4);
            txtcedula.PasswordChar = false;
            txtcedula.Size = new Size(192, 27);
            txtcedula.TabIndex = 16;
            txtcedula.Texts = "";
            txtcedula.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(313, 179);
            label4.Name = "label4";
            label4.Size = new Size(119, 22);
            label4.TabIndex = 19;
            label4.Text = "Contraseña";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtcontraseña
            // 
            txtcontraseña.BackColor = Color.FromArgb(127, 127, 127);
            txtcontraseña.BorderColor = Color.FromArgb(255, 165, 11);
            txtcontraseña.BorderFocusColor = SystemColors.HotTrack;
            txtcontraseña.BorderSize = 6;
            txtcontraseña.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcontraseña.ForeColor = Color.Black;
            txtcontraseña.Location = new Point(313, 206);
            txtcontraseña.Margin = new Padding(2);
            txtcontraseña.Multiline = false;
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Padding = new Padding(5, 4, 5, 4);
            txtcontraseña.PasswordChar = true;
            txtcontraseña.Size = new Size(211, 27);
            txtcontraseña.TabIndex = 18;
            txtcontraseña.Texts = "";
            txtcontraseña.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(313, 252);
            label5.Name = "label5";
            label5.Size = new Size(211, 22);
            label5.TabIndex = 21;
            label5.Text = "Confirmar contraseña";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtconfirmarcontraseña
            // 
            txtconfirmarcontraseña.BackColor = Color.FromArgb(127, 127, 127);
            txtconfirmarcontraseña.BorderColor = Color.FromArgb(255, 165, 11);
            txtconfirmarcontraseña.BorderFocusColor = SystemColors.HotTrack;
            txtconfirmarcontraseña.BorderSize = 6;
            txtconfirmarcontraseña.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtconfirmarcontraseña.ForeColor = Color.Black;
            txtconfirmarcontraseña.Location = new Point(313, 279);
            txtconfirmarcontraseña.Margin = new Padding(2);
            txtconfirmarcontraseña.Multiline = false;
            txtconfirmarcontraseña.Name = "txtconfirmarcontraseña";
            txtconfirmarcontraseña.Padding = new Padding(5, 4, 5, 4);
            txtconfirmarcontraseña.PasswordChar = true;
            txtconfirmarcontraseña.Size = new Size(211, 27);
            txtconfirmarcontraseña.TabIndex = 20;
            txtconfirmarcontraseña.Texts = "";
            txtconfirmarcontraseña.UnderlinedStyle = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 38);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Registrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 127, 127);
            ClientSize = new Size(552, 463);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(txtconfirmarcontraseña);
            Controls.Add(label4);
            Controls.Add(txtcontraseña);
            Controls.Add(label3);
            Controls.Add(txtcedula);
            Controls.Add(label2);
            Controls.Add(txtcorreo);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(MoverVentanaRegistrarse);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registrarse";
            Opacity = 0.8D;
            Text = "Registrarse";
            Load += Registrarse_Load;
            MoverVentanaRegistrarse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BotonMinimizarRegistrarse).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrarRegistrarse).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private RJControls.RJtextbox txtcorreo;
        private Label label3;
        private RJControls.RJtextbox txtcedula;
        private Label label4;
        private RJControls.RJtextbox txtcontraseña;
        private Label label5;
        private RJControls.RJtextbox txtconfirmarcontraseña;
        private PictureBox pictureBox1;
    }
}