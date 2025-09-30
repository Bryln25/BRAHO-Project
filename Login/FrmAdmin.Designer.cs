namespace BRAHO_Project
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            MoverVentana = new Panel();
            BtnMinimizar = new PictureBox();
            BtnSalir = new PictureBox();
            txtClave = new BRAHO_Project.RJControls.RJtextbox();
            label1 = new Label();
            BtnVerificar = new BRAHO_Project.RJControls.RJButton();
            MoverVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
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
            MoverVentana.Size = new Size(453, 45);
            MoverVentana.TabIndex = 2;
            MoverVentana.MouseDown += MoverVentana_MouseDown;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinimizar.Cursor = Cursors.Hand;
            BtnMinimizar.Image = (Image)resources.GetObject("BtnMinimizar.Image");
            BtnMinimizar.Location = new Point(371, 7);
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
            BtnSalir.Location = new Point(413, 7);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(29, 33);
            BtnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSalir.TabIndex = 5;
            BtnSalir.TabStop = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.FromArgb(64, 64, 64);
            txtClave.BorderColor = Color.Red;
            txtClave.BorderFocusColor = Color.Red;
            txtClave.BorderSize = 3;
            txtClave.CaretColor = Color.Black;
            txtClave.CaretCustom = false;
            txtClave.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.ForeColor = Color.DimGray;
            txtClave.Location = new Point(67, 122);
            txtClave.MaxLength = 32767;
            txtClave.Multiline = false;
            txtClave.Name = "txtClave";
            txtClave.OnlyNumbers = false;
            txtClave.Padding = new Padding(7);
            txtClave.PasswordChar = true;
            txtClave.Size = new Size(312, 35);
            txtClave.TabIndex = 3;
            txtClave.Texts = "";
            txtClave.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 83);
            label1.Name = "label1";
            label1.Size = new Size(316, 23);
            label1.TabIndex = 4;
            label1.Text = "Ingrese clave de administrador";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnVerificar
            // 
            BtnVerificar.BackColor = Color.FromArgb(255, 165, 11);
            BtnVerificar.BackgroundColor = Color.FromArgb(255, 165, 11);
            BtnVerificar.BorderColor = Color.PaleVioletRed;
            BtnVerificar.BorderRadius = 20;
            BtnVerificar.BorderSize = 0;
            BtnVerificar.Cursor = Cursors.Hand;
            BtnVerificar.FlatAppearance.BorderSize = 0;
            BtnVerificar.FlatStyle = FlatStyle.Flat;
            BtnVerificar.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVerificar.ForeColor = Color.White;
            BtnVerificar.Location = new Point(145, 178);
            BtnVerificar.Margin = new Padding(3, 4, 3, 4);
            BtnVerificar.Name = "BtnVerificar";
            BtnVerificar.Size = new Size(154, 40);
            BtnVerificar.TabIndex = 5;
            BtnVerificar.Text = "Verificar";
            BtnVerificar.TextColor = Color.White;
            BtnVerificar.UseVisualStyleBackColor = false;
            BtnVerificar.Click += BtnVerificar_Click;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(453, 248);
            Controls.Add(BtnVerificar);
            Controls.Add(label1);
            Controls.Add(txtClave);
            Controls.Add(MoverVentana);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clave administrador";
            MoverVentana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MoverVentana;
        private PictureBox BtnMinimizar;
        private PictureBox BtnSalir;
        private RJControls.RJtextbox txtClave;
        private Label label1;
        private RJControls.RJButton BtnVerificar;
    }
}