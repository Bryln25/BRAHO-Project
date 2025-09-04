namespace BRAHO_Project
{
    partial class IniciodeSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciodeSesion));
            MoverVentanaInicioSesion = new Panel();
            BotonMininizar = new PictureBox();
            BotonCerrar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtUsuario = new BRAHO_Project.RJControls.RJtextbox();
            txtContraseña = new BRAHO_Project.RJControls.RJtextbox();
            linkLabel1 = new LinkLabel();
            BotonLoguear = new BRAHO_Project.RJControls.RJButton();
            BotonRegistrarse = new BRAHO_Project.RJControls.RJButton();
            MoverVentanaInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MoverVentanaInicioSesion
            // 
            MoverVentanaInicioSesion.BackColor = Color.FromArgb(102, 102, 102);
            MoverVentanaInicioSesion.Controls.Add(BotonMininizar);
            MoverVentanaInicioSesion.Controls.Add(BotonCerrar);
            MoverVentanaInicioSesion.Dock = DockStyle.Top;
            MoverVentanaInicioSesion.Location = new Point(0, 0);
            MoverVentanaInicioSesion.Margin = new Padding(3, 2, 3, 2);
            MoverVentanaInicioSesion.Name = "MoverVentanaInicioSesion";
            MoverVentanaInicioSesion.Size = new Size(414, 34);
            MoverVentanaInicioSesion.TabIndex = 0;
            MoverVentanaInicioSesion.MouseDown += MoverVentanaInicioSesion_MouseDown;
            // 
            // BotonMininizar
            // 
            BotonMininizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonMininizar.Cursor = Cursors.Hand;
            BotonMininizar.Image = (Image)resources.GetObject("BotonMininizar.Image");
            BotonMininizar.Location = new Point(349, 7);
            BotonMininizar.Margin = new Padding(3, 2, 3, 2);
            BotonMininizar.Name = "BotonMininizar";
            BotonMininizar.Size = new Size(25, 25);
            BotonMininizar.SizeMode = PictureBoxSizeMode.Zoom;
            BotonMininizar.TabIndex = 2;
            BotonMininizar.TabStop = false;
            BotonMininizar.Click += BotonMininizar_Click;
            // 
            // BotonCerrar
            // 
            BotonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonCerrar.Cursor = Cursors.Hand;
            BotonCerrar.Image = (Image)resources.GetObject("BotonCerrar.Image");
            BotonCerrar.Location = new Point(386, 7);
            BotonCerrar.Margin = new Padding(3, 2, 3, 2);
            BotonCerrar.Name = "BotonCerrar";
            BotonCerrar.Size = new Size(25, 25);
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
            label1.Location = new Point(39, 157);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 247);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 46);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(127, 127, 127);
            txtUsuario.BorderColor = Color.FromArgb(255, 165, 11);
            txtUsuario.BorderFocusColor = SystemColors.HotTrack;
            txtUsuario.BorderSize = 6;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(42, 182);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(5, 4, 5, 4);
            txtUsuario.PasswordChar = false;
            txtUsuario.Size = new Size(332, 27);
            txtUsuario.TabIndex = 11;
            txtUsuario.Texts = "";
            txtUsuario.UnderlinedStyle = true;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(127, 127, 127);
            txtContraseña.BorderColor = Color.FromArgb(255, 165, 11);
            txtContraseña.BorderFocusColor = SystemColors.HotTrack;
            txtContraseña.BorderSize = 6;
            txtContraseña.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.Location = new Point(42, 272);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.Multiline = false;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Padding = new Padding(5, 4, 5, 4);
            txtContraseña.PasswordChar = false;
            txtContraseña.Size = new Size(332, 27);
            txtContraseña.TabIndex = 12;
            txtContraseña.Texts = "";
            txtContraseña.UnderlinedStyle = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(137, 435);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 15);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste tu contraseña?";
            // 
            // BotonLoguear
            // 
            BotonLoguear.BackColor = Color.FromArgb(255, 165, 11);
            BotonLoguear.BackgroundColor = Color.FromArgb(255, 165, 11);
            BotonLoguear.BorderColor = Color.PaleVioletRed;
            BotonLoguear.BorderRadius = 20;
            BotonLoguear.BorderSize = 0;
            BotonLoguear.FlatAppearance.BorderSize = 0;
            BotonLoguear.FlatStyle = FlatStyle.Flat;
            BotonLoguear.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonLoguear.ForeColor = Color.White;
            BotonLoguear.Location = new Point(39, 332);
            BotonLoguear.Name = "BotonLoguear";
            BotonLoguear.Size = new Size(335, 40);
            BotonLoguear.TabIndex = 14;
            BotonLoguear.Text = "Inicio Sesion";
            BotonLoguear.TextColor = Color.White;
            BotonLoguear.UseVisualStyleBackColor = false;
            BotonLoguear.Click += BotonLoguear_Click;
            // 
            // BotonRegistrarse
            // 
            BotonRegistrarse.BackColor = Color.Transparent;
            BotonRegistrarse.BackgroundColor = Color.Transparent;
            BotonRegistrarse.BorderColor = Color.PaleVioletRed;
            BotonRegistrarse.BorderRadius = 20;
            BotonRegistrarse.BorderSize = 0;
            BotonRegistrarse.FlatAppearance.BorderSize = 0;
            BotonRegistrarse.FlatStyle = FlatStyle.Flat;
            BotonRegistrarse.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonRegistrarse.ForeColor = Color.FromArgb(255, 165, 11);
            BotonRegistrarse.Location = new Point(42, 385);
            BotonRegistrarse.Name = "BotonRegistrarse";
            BotonRegistrarse.Size = new Size(332, 40);
            BotonRegistrarse.TabIndex = 15;
            BotonRegistrarse.Text = "Registrase";
            BotonRegistrarse.TextColor = Color.FromArgb(255, 165, 11);
            BotonRegistrarse.UseVisualStyleBackColor = false;
            BotonRegistrarse.Click += BotonRegistrarse_Click;
            // 
            // IniciodeSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 127, 127);
            ClientSize = new Size(414, 475);
            Controls.Add(BotonRegistrarse);
            Controls.Add(BotonLoguear);
            Controls.Add(linkLabel1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MoverVentanaInicioSesion);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "IniciodeSesion";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IniciodeSesion";
            Load += IniciodeSesion_Load;
            MoverVentanaInicioSesion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MoverVentanaInicioSesion;
        private PictureBox BotonCerrar;
        private PictureBox BotonMininizar;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private RJControls.RJtextbox txtUsuario;
        private RJControls.RJtextbox txtContraseña;
        private LinkLabel linkLabel1;
        private RJControls.RJButton BotonLoguear;
        private RJControls.RJButton BotonRegistrarse;
    }
}