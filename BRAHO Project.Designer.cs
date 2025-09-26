namespace BRAHO_Project
{
    partial class PaginaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            MenuVertical = new Panel();
            lblEmail = new Label();
            lblPuesto = new Label();
            BotonSlide = new PictureBox();
            logouser = new PictureBox();
            lblNombre = new Label();
            BotonCerrarSesion = new Button();
            BotonVentas = new Button();
            BotonRegistrarObra = new Button();
            BotonClientes = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            BarraTitulo = new Panel();
            BotonMininizar = new PictureBox();
            BotonCerrar = new PictureBox();
            Contenedor = new Panel();
            lblFecha = new Label();
            lblHora = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            horaFecha = new System.Windows.Forms.Timer(components);
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BotonSlide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logouser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).BeginInit();
            Contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(127, 127, 127);
            MenuVertical.Controls.Add(lblEmail);
            MenuVertical.Controls.Add(lblPuesto);
            MenuVertical.Controls.Add(BotonSlide);
            MenuVertical.Controls.Add(logouser);
            MenuVertical.Controls.Add(lblNombre);
            MenuVertical.Controls.Add(BotonCerrarSesion);
            MenuVertical.Controls.Add(BotonVentas);
            MenuVertical.Controls.Add(BotonRegistrarObra);
            MenuVertical.Controls.Add(BotonClientes);
            MenuVertical.Controls.Add(pictureBox3);
            MenuVertical.Controls.Add(label1);
            MenuVertical.Controls.Add(label2);
            MenuVertical.Controls.Add(label3);
            MenuVertical.Controls.Add(label4);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 34);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(260, 617);
            MenuVertical.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoEllipsis = true;
            lblEmail.BackColor = Color.FromArgb(64, 64, 64);
            lblEmail.Font = new Font("Century Gothic", 9F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(12, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(240, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoEllipsis = true;
            lblPuesto.BackColor = Color.FromArgb(64, 64, 64);
            lblPuesto.Font = new Font("Century Gothic", 9F);
            lblPuesto.ForeColor = Color.White;
            lblPuesto.Location = new Point(12, 170);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(240, 20);
            lblPuesto.TabIndex = 2;
            lblPuesto.Text = "Puesto";
            // 
            // BotonSlide
            // 
            BotonSlide.Cursor = Cursors.Hand;
            BotonSlide.Image = (Image)resources.GetObject("BotonSlide.Image");
            BotonSlide.Location = new Point(12, 12);
            BotonSlide.Name = "BotonSlide";
            BotonSlide.Size = new Size(35, 35);
            BotonSlide.SizeMode = PictureBoxSizeMode.Zoom;
            BotonSlide.TabIndex = 0;
            BotonSlide.TabStop = false;
            BotonSlide.Click += BotonSlide_Click;
            // 
            // logouser
            // 
            logouser.BackColor = Color.FromArgb(64, 64, 64);
            logouser.Image = (Image)resources.GetObject("logouser.Image");
            logouser.Location = new Point(81, 65);
            logouser.Name = "logouser";
            logouser.Size = new Size(80, 80);
            logouser.SizeMode = PictureBoxSizeMode.Zoom;
            logouser.TabIndex = 1;
            logouser.TabStop = false;
            logouser.Click += logouser_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoEllipsis = true;
            lblNombre.BackColor = Color.FromArgb(64, 64, 64);
            lblNombre.Font = new Font("Century Gothic", 9F);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(12, 150);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(240, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // BotonCerrarSesion
            // 
            BotonCerrarSesion.FlatAppearance.BorderSize = 0;
            BotonCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 102, 102);
            BotonCerrarSesion.FlatStyle = FlatStyle.Flat;
            BotonCerrarSesion.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonCerrarSesion.ForeColor = Color.White;
            BotonCerrarSesion.Image = (Image)resources.GetObject("BotonCerrarSesion.Image");
            BotonCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            BotonCerrarSesion.Location = new Point(0, 555);
            BotonCerrarSesion.Name = "BotonCerrarSesion";
            BotonCerrarSesion.Size = new Size(250, 52);
            BotonCerrarSesion.TabIndex = 5;
            BotonCerrarSesion.Text = "    Cerrar Sesión";
            BotonCerrarSesion.UseVisualStyleBackColor = true;
            BotonCerrarSesion.Click += BotonCerrarSesion_Click;
            // 
            // BotonVentas
            // 
            BotonVentas.FlatAppearance.BorderSize = 0;
            BotonVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 102, 102);
            BotonVentas.FlatStyle = FlatStyle.Flat;
            BotonVentas.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonVentas.ForeColor = Color.White;
            BotonVentas.Image = (Image)resources.GetObject("BotonVentas.Image");
            BotonVentas.ImageAlign = ContentAlignment.MiddleLeft;
            BotonVentas.Location = new Point(1, 444);
            BotonVentas.Name = "BotonVentas";
            BotonVentas.Size = new Size(256, 52);
            BotonVentas.TabIndex = 4;
            BotonVentas.Text = "Ventas";
            BotonVentas.UseVisualStyleBackColor = true;
            // 
            // BotonRegistrarObra
            // 
            BotonRegistrarObra.FlatAppearance.BorderSize = 0;
            BotonRegistrarObra.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 102, 102);
            BotonRegistrarObra.FlatStyle = FlatStyle.Flat;
            BotonRegistrarObra.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonRegistrarObra.ForeColor = Color.White;
            BotonRegistrarObra.Image = (Image)resources.GetObject("BotonRegistrarObra.Image");
            BotonRegistrarObra.ImageAlign = ContentAlignment.MiddleLeft;
            BotonRegistrarObra.Location = new Point(1, 371);
            BotonRegistrarObra.Name = "BotonRegistrarObra";
            BotonRegistrarObra.Size = new Size(256, 52);
            BotonRegistrarObra.TabIndex = 2;
            BotonRegistrarObra.Text = "Obras";
            BotonRegistrarObra.UseVisualStyleBackColor = true;
            BotonRegistrarObra.Click += BotonRegistrarObra_Click;
            // 
            // BotonClientes
            // 
            BotonClientes.FlatAppearance.BorderSize = 0;
            BotonClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 102, 102);
            BotonClientes.FlatStyle = FlatStyle.Flat;
            BotonClientes.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonClientes.ForeColor = Color.White;
            BotonClientes.Image = (Image)resources.GetObject("BotonClientes.Image");
            BotonClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BotonClientes.Location = new Point(1, 298);
            BotonClientes.Name = "BotonClientes";
            BotonClientes.Size = new Size(256, 52);
            BotonClientes.TabIndex = 3;
            BotonClientes.Text = "Clientes";
            BotonClientes.UseVisualStyleBackColor = true;
            BotonClientes.Click += BotonClientes_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(64, 64, 64);
            pictureBox3.Location = new Point(0, 53);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(264, 171);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(102, 102, 102);
            label1.Location = new Point(-16, 238);
            label1.Name = "label1";
            label1.Size = new Size(299, 54);
            label1.TabIndex = 1;
            label1.Text = "_____________";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(102, 102, 102);
            label2.Location = new Point(-16, 311);
            label2.Name = "label2";
            label2.Size = new Size(299, 54);
            label2.TabIndex = 7;
            label2.Text = "_____________";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(102, 102, 102);
            label3.Location = new Point(-16, 384);
            label3.Name = "label3";
            label3.Size = new Size(299, 54);
            label3.TabIndex = 8;
            label3.Text = "_____________";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(102, 102, 102);
            label4.Location = new Point(-16, 457);
            label4.Name = "label4";
            label4.Size = new Size(299, 54);
            label4.TabIndex = 8;
            label4.Text = "_____________";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(716, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(102, 102, 102);
            BarraTitulo.Controls.Add(BotonMininizar);
            BarraTitulo.Controls.Add(BotonCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1301, 34);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // BotonMininizar
            // 
            BotonMininizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonMininizar.Cursor = Cursors.Hand;
            BotonMininizar.Image = (Image)resources.GetObject("BotonMininizar.Image");
            BotonMininizar.Location = new Point(1221, 3);
            BotonMininizar.Name = "BotonMininizar";
            BotonMininizar.Size = new Size(29, 28);
            BotonMininizar.SizeMode = PictureBoxSizeMode.Zoom;
            BotonMininizar.TabIndex = 1;
            BotonMininizar.TabStop = false;
            BotonMininizar.Click += BotonMininizar_Click;
            // 
            // BotonCerrar
            // 
            BotonCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonCerrar.Cursor = Cursors.Hand;
            BotonCerrar.Image = (Image)resources.GetObject("BotonCerrar.Image");
            BotonCerrar.Location = new Point(1260, 3);
            BotonCerrar.Name = "BotonCerrar";
            BotonCerrar.Size = new Size(29, 28);
            BotonCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BotonCerrar.TabIndex = 0;
            BotonCerrar.TabStop = false;
            BotonCerrar.Click += BotonCerrar_Click;
            // 
            // Contenedor
            // 
            Contenedor.Controls.Add(lblFecha);
            Contenedor.Controls.Add(lblHora);
            Contenedor.Controls.Add(pictureBox1);
            Contenedor.Dock = DockStyle.Fill;
            Contenedor.Location = new Point(260, 34);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1041, 617);
            Contenedor.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.FromArgb(255, 165, 11);
            lblFecha.Location = new Point(12, 34);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(84, 21);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "lblFecha";
            lblFecha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.ForeColor = Color.FromArgb(255, 165, 11);
            lblHora.Location = new Point(8, 7);
            lblHora.Margin = new Padding(4, 0, 4, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(94, 27);
            lblHora.TabIndex = 1;
            lblHora.Text = "lblHora";
            lblHora.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // PaginaPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1301, 651);
            Controls.Add(Contenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PaginaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio - BRAHO Project";
            Load += PaginaPrincipal_Load;
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BotonSlide).EndInit();
            ((System.ComponentModel.ISupportInitialize)logouser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).EndInit();
            Contenedor.ResumeLayout(false);
            Contenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel BarraTitulo;
        private Panel Contenedor;
        private PictureBox BotonSlide;
        private PictureBox pictureBox1;
        private PictureBox BotonCerrar;
        private PictureBox BotonMininizar;
        private Button BotonRegistrarObra;
        private Button BotonClientes;
        private Button BotonVentas;
        private System.Windows.Forms.Timer timer1;
        private Button BotonCerrarSesion;
        private PictureBox logouser;
        private PictureBox pictureBox3;
        private Label lblEmail;
        private Label lblPuesto;
        private Label lblNombre;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer horaFecha;
    }
}
