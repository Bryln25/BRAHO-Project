namespace BRAHO_Project
{
    partial class FrmUsuarios
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            BotonMininizar = new PictureBox();
            BotonCerrar = new PictureBox();
            BotonCerr = new BRAHO_Project.RJControls.RJButton();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtBuscar = new BRAHO_Project.RJControls.RJtextbox();
            btnProcesado = new BRAHO_Project.RJControls.RJButton();
            btnNuevo = new BRAHO_Project.RJControls.RJButton();
            panel2 = new Panel();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            txtOculto = new BRAHO_Project.RJControls.RJtextbox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            BotonCerr.Location = new Point(1061, 534);
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
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(btnProcesado);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(29, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 527);
            panel1.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(573, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(64, 64, 64);
            txtBuscar.BorderColor = Color.FromArgb(255, 165, 11);
            txtBuscar.BorderFocusColor = SystemColors.HotTrack;
            txtBuscar.BorderSize = 6;
            txtBuscar.CaretColor = Color.Black;
            txtBuscar.CaretCustom = false;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Gainsboro;
            txtBuscar.Location = new Point(618, 27);
            txtBuscar.Margin = new Padding(2, 3, 2, 3);
            txtBuscar.MaxLength = 32767;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.OnlyNumbers = false;
            txtBuscar.Padding = new Padding(6, 5, 6, 5);
            txtBuscar.PasswordChar = false;
            txtBuscar.Size = new Size(0, 35);
            txtBuscar.TabIndex = 18;
            txtBuscar.Texts = "";
            txtBuscar.UnderlinedStyle = true;
            txtBuscar._TextChanged += txtBuscar__TextChanged;
            // 
            // btnProcesado
            // 
            btnProcesado.BackColor = Color.FromArgb(127, 127, 127);
            btnProcesado.BackgroundColor = Color.FromArgb(127, 127, 127);
            btnProcesado.BorderColor = Color.FromArgb(102, 102, 102);
            btnProcesado.BorderRadius = 20;
            btnProcesado.BorderSize = 0;
            btnProcesado.Cursor = Cursors.Hand;
            btnProcesado.FlatAppearance.BorderSize = 0;
            btnProcesado.FlatStyle = FlatStyle.Flat;
            btnProcesado.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcesado.ForeColor = Color.White;
            btnProcesado.Location = new Point(189, 9);
            btnProcesado.Margin = new Padding(3, 4, 3, 4);
            btnProcesado.Name = "btnProcesado";
            btnProcesado.Size = new Size(168, 53);
            btnProcesado.TabIndex = 13;
            btnProcesado.Text = "Procesados";
            btnProcesado.TextColor = Color.White;
            btnProcesado.UseVisualStyleBackColor = false;
            btnProcesado.Click += btnProcesado_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(127, 127, 127);
            btnNuevo.BackgroundColor = Color.FromArgb(127, 127, 127);
            btnNuevo.BorderColor = Color.FromArgb(102, 102, 102);
            btnNuevo.BorderRadius = 20;
            btnNuevo.BorderSize = 0;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(12, 9);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(159, 53);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevos";
            btnNuevo.TextColor = Color.White;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnAgendado_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 471);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(163, 21);
            label6.TabIndex = 15;
            label6.Text = "Gestionar Usuarios";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // txtOculto
            // 
            txtOculto.BackColor = Color.FromArgb(64, 64, 64);
            txtOculto.BorderColor = Color.FromArgb(255, 165, 11);
            txtOculto.BorderFocusColor = SystemColors.HotTrack;
            txtOculto.BorderSize = 6;
            txtOculto.CaretColor = Color.Black;
            txtOculto.CaretCustom = false;
            txtOculto.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOculto.ForeColor = Color.Gainsboro;
            txtOculto.Location = new Point(1023, 11);
            txtOculto.Margin = new Padding(2, 3, 2, 3);
            txtOculto.MaxLength = 32767;
            txtOculto.Multiline = false;
            txtOculto.Name = "txtOculto";
            txtOculto.OnlyNumbers = false;
            txtOculto.Padding = new Padding(6, 5, 6, 5);
            txtOculto.PasswordChar = false;
            txtOculto.Size = new Size(0, 35);
            txtOculto.TabIndex = 20;
            txtOculto.Texts = "";
            txtOculto.UnderlinedStyle = true;
            // 
            // FrmTickets
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1041, 617);
            Controls.Add(txtOculto);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(BotonCerr);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTickets";
            Text = "FrmClientes";
            Load += FrmObras_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox BotonMininizar;
        private PictureBox BotonCerrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox BtnMinimizar;
        private PictureBox BtnSalir;
        private RJControls.RJButton BotonCerr;
        private Panel panel1;
        private Panel panel2;
        private RJControls.RJButton btnNuevo;
        private PictureBox pictureBox3;
        private RJControls.RJtextbox txtBuscar;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private RJControls.RJtextbox txtOculto;
        private RJControls.RJButton btnProcesado;
    }
}