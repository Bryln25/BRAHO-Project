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
            UsuarioSesion = new TextBox();
            ContrasenaSesion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            MoverVentanaInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).BeginInit();
            SuspendLayout();
            // 
            // MoverVentanaInicioSesion
            // 
            MoverVentanaInicioSesion.BackColor = Color.FromArgb(102, 102, 102);
            MoverVentanaInicioSesion.Controls.Add(BotonMininizar);
            MoverVentanaInicioSesion.Controls.Add(BotonCerrar);
            MoverVentanaInicioSesion.Dock = DockStyle.Top;
            MoverVentanaInicioSesion.Location = new Point(0, 0);
            MoverVentanaInicioSesion.Name = "MoverVentanaInicioSesion";
            MoverVentanaInicioSesion.Size = new Size(473, 45);
            MoverVentanaInicioSesion.TabIndex = 0;
            // 
            // BotonMininizar
            // 
            BotonMininizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BotonMininizar.Cursor = Cursors.Hand;
            BotonMininizar.Image = (Image)resources.GetObject("BotonMininizar.Image");
            BotonMininizar.Location = new Point(398, 9);
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
            BotonCerrar.Location = new Point(441, 9);
            BotonCerrar.Name = "BotonCerrar";
            BotonCerrar.Size = new Size(29, 33);
            BotonCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BotonCerrar.TabIndex = 1;
            BotonCerrar.TabStop = false;
            // 
            // UsuarioSesion
            // 
            UsuarioSesion.BackColor = Color.FromArgb(127, 127, 127);
            UsuarioSesion.BorderStyle = BorderStyle.None;
            UsuarioSesion.Cursor = Cursors.IBeam;
            UsuarioSesion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsuarioSesion.Location = new Point(48, 238);
            UsuarioSesion.Name = "UsuarioSesion";
            UsuarioSesion.Size = new Size(375, 25);
            UsuarioSesion.TabIndex = 1;
            UsuarioSesion.TextChanged += UsuarioSesion_TextChanged;
            // 
            // ContrasenaSesion
            // 
            ContrasenaSesion.BackColor = Color.FromArgb(127, 127, 127);
            ContrasenaSesion.BorderStyle = BorderStyle.None;
            ContrasenaSesion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContrasenaSesion.Location = new Point(48, 387);
            ContrasenaSesion.Name = "ContrasenaSesion";
            ContrasenaSesion.Size = new Size(375, 25);
            ContrasenaSesion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 217);
            label1.Name = "label1";
            label1.Size = new Size(95, 27);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 354);
            label2.Name = "label2";
            label2.Size = new Size(145, 27);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 165, 11);
            label4.Location = new Point(48, 246);
            label4.Name = "label4";
            label4.Size = new Size(375, 35);
            label4.TabIndex = 6;
            label4.Text = "________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 165, 11);
            label3.Location = new Point(48, 387);
            label3.Name = "label3";
            label3.Size = new Size(375, 35);
            label3.TabIndex = 7;
            label3.Text = "________________________";
            // 
            // IniciodeSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 127, 127);
            ClientSize = new Size(473, 620);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ContrasenaSesion);
            Controls.Add(UsuarioSesion);
            Controls.Add(MoverVentanaInicioSesion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IniciodeSesion";
            Opacity = 0.7D;
            Text = "IniciodeSesion";
            MoverVentanaInicioSesion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BotonMininizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BotonCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MoverVentanaInicioSesion;
        private PictureBox BotonCerrar;
        private PictureBox BotonMininizar;
        private TextBox UsuarioSesion;
        private TextBox ContrasenaSesion;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}