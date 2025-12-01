namespace BRAHO_Project
{
    partial class FrmCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreditos));
            MoverVentana = new Panel();
            BtnMinimizar = new PictureBox();
            BtnSalir = new PictureBox();
            label1 = new Label();
            fotoAndrews = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            fotoBraylin = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            MoverVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoAndrews).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotoBraylin).BeginInit();
            SuspendLayout();
            // 
            // MoverVentana
            // 
            MoverVentana.BackColor = Color.FromArgb(102, 102, 102);
            MoverVentana.Controls.Add(BtnMinimizar);
            MoverVentana.Controls.Add(BtnSalir);
            MoverVentana.Dock = DockStyle.Top;
            MoverVentana.Location = new Point(0, 0);
            MoverVentana.Name = "MoverVentana";
            MoverVentana.Size = new Size(660, 45);
            MoverVentana.TabIndex = 2;
            MoverVentana.MouseDown += MoverVentana_MouseDown;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(577, 7);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(29, 33);
            BtnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinimizar.TabIndex = 6;
            BtnMinimizar.TabStop = false;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSalir.Cursor = Cursors.Hand;
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(620, 7);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(29, 33);
            BtnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSalir.TabIndex = 5;
            BtnSalir.TabStop = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 123);
            label1.Name = "label1";
            label1.Size = new Size(179, 69);
            label1.TabIndex = 4;
            label1.Text = "Andrews Thomas \r\nHernández Jerez\r\n100700000";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // fotoAndrews
            // 
            fotoAndrews.BackColor = Color.Transparent;
            fotoAndrews.Image = (Image)resources.GetObject("fotoAndrews.Image");
            fotoAndrews.Location = new Point(25, 123);
            fotoAndrews.Name = "fotoAndrews";
            fotoAndrews.Size = new Size(80, 80);
            fotoAndrews.SizeMode = PictureBoxSizeMode.Zoom;
            fotoAndrews.TabIndex = 5;
            fotoAndrews.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 61);
            label2.Name = "label2";
            label2.Size = new Size(161, 23);
            label2.TabIndex = 6;
            label2.Text = "Desarrolladores";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(102, 102, 102);
            label4.Location = new Point(25, 166);
            label4.Name = "label4";
            label4.Size = new Size(286, 54);
            label4.TabIndex = 8;
            label4.Text = "_____________";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fotoBraylin
            // 
            fotoBraylin.BackColor = Color.Transparent;
            fotoBraylin.Location = new Point(341, 123);
            fotoBraylin.Name = "fotoBraylin";
            fotoBraylin.Size = new Size(80, 80);
            fotoBraylin.SizeMode = PictureBoxSizeMode.Zoom;
            fotoBraylin.TabIndex = 10;
            fotoBraylin.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(427, 123);
            label5.Name = "label5";
            label5.Size = new Size(160, 69);
            label5.TabIndex = 9;
            label5.Text = "Braylin De Jesus\r\nNuñez Batista\r\n100698459";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(102, 102, 102);
            label6.Location = new Point(341, 166);
            label6.Name = "label6";
            label6.Size = new Size(277, 54);
            label6.TabIndex = 11;
            label6.Text = "_____________";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(39, 251);
            label8.Name = "label8";
            label8.Size = new Size(102, 23);
            label8.TabIndex = 13;
            label8.Text = "Contacto";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(39, 293);
            label9.Name = "label9";
            label9.Size = new Size(283, 46);
            label9.TabIndex = 14;
            label9.Text = "(849) 226-0404\r\nAndrews100404@gmail.com\r\n";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(342, 293);
            label10.Name = "label10";
            label10.Size = new Size(276, 46);
            label10.TabIndex = 15;
            label10.Text = "(829) 263-2599\r\nbraylinnunez72@gmail.com\r\n";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmCreditos
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(660, 381);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(fotoBraylin);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(fotoAndrews);
            Controls.Add(label1);
            Controls.Add(MoverVentana);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCreditos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clave administrador";
            MoverVentana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoAndrews).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotoBraylin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MoverVentana;
        private PictureBox BtnMinimizar;
        private PictureBox BtnSalir;
        private Label label1;
        private PictureBox fotoAndrews;
        private Label label2;
        private Label label4;
        private PictureBox fotoBraylin;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}