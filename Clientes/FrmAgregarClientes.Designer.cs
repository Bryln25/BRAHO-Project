namespace BRAHO_Project
{
    partial class FrmAgregarClientes
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
            txtNombre = new BRAHO_Project.RJControls.RJtextbox();
            label1 = new Label();
            txtTelefono = new BRAHO_Project.RJControls.RJtextbox();
            label2 = new Label();
            txtEmail = new BRAHO_Project.RJControls.RJtextbox();
            label3 = new Label();
            txtDireccion = new BRAHO_Project.RJControls.RJtextbox();
            label4 = new Label();
            txtCedula = new BRAHO_Project.RJControls.RJtextbox();
            label5 = new Label();
            label6 = new Label();
            btnAgregarCliente = new BRAHO_Project.RJControls.RJButton();
            btnCancelar = new BRAHO_Project.RJControls.RJButton();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(64, 64, 64);
            txtNombre.BorderColor = Color.FromArgb(255, 165, 11);
            txtNombre.BorderFocusColor = SystemColors.HotTrack;
            txtNombre.BorderSize = 6;
            txtNombre.CaretColor = Color.Black;
            txtNombre.CaretCustom = false;
            txtNombre.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(111, 120);
            txtNombre.Margin = new Padding(2, 3, 2, 3);
            txtNombre.MaxLength = 32767;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.OnlyNumbers = false;
            txtNombre.Padding = new Padding(6, 5, 6, 5);
            txtNombre.PasswordChar = false;
            txtNombre.Size = new Size(347, 35);
            txtNombre.TabIndex = 4;
            txtNombre.Texts = "";
            txtNombre.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(108, 86);
            label1.Name = "label1";
            label1.Size = new Size(222, 27);
            label1.TabIndex = 5;
            label1.Text = "Nombre completo";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(64, 64, 64);
            txtTelefono.BorderColor = Color.FromArgb(255, 165, 11);
            txtTelefono.BorderFocusColor = SystemColors.HotTrack;
            txtTelefono.BorderSize = 6;
            txtTelefono.CaretColor = Color.Black;
            txtTelefono.CaretCustom = false;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(108, 230);
            txtTelefono.Margin = new Padding(2, 3, 2, 3);
            txtTelefono.MaxLength = 10;
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.OnlyNumbers = true;
            txtTelefono.Padding = new Padding(6, 5, 6, 5);
            txtTelefono.PasswordChar = false;
            txtTelefono.Size = new Size(347, 35);
            txtTelefono.TabIndex = 6;
            txtTelefono.Texts = "";
            txtTelefono.UnderlinedStyle = true;
            txtTelefono._Enter += txtTelefono__Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(105, 196);
            label2.Name = "label2";
            label2.Size = new Size(154, 27);
            label2.TabIndex = 7;
            label2.Text = "No. Teléfono";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(64, 64, 64);
            txtEmail.BorderColor = Color.FromArgb(255, 165, 11);
            txtEmail.BorderFocusColor = SystemColors.HotTrack;
            txtEmail.BorderSize = 6;
            txtEmail.CaretColor = Color.Black;
            txtEmail.CaretCustom = false;
            txtEmail.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(111, 342);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.MaxLength = 50;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.OnlyNumbers = false;
            txtEmail.Padding = new Padding(6, 5, 6, 5);
            txtEmail.PasswordChar = false;
            txtEmail.Size = new Size(347, 35);
            txtEmail.TabIndex = 8;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(111, 312);
            label3.Name = "label3";
            label3.Size = new Size(74, 27);
            label3.TabIndex = 9;
            label3.Text = "Email";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(64, 64, 64);
            txtDireccion.BorderColor = Color.FromArgb(255, 165, 11);
            txtDireccion.BorderFocusColor = SystemColors.HotTrack;
            txtDireccion.BorderSize = 6;
            txtDireccion.CaretColor = Color.Black;
            txtDireccion.CaretCustom = false;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Location = new Point(557, 120);
            txtDireccion.Margin = new Padding(2, 3, 2, 3);
            txtDireccion.MaxLength = 32767;
            txtDireccion.Multiline = false;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.OnlyNumbers = false;
            txtDireccion.Padding = new Padding(6, 5, 6, 5);
            txtDireccion.PasswordChar = false;
            txtDireccion.Size = new Size(347, 35);
            txtDireccion.TabIndex = 10;
            txtDireccion.Texts = "";
            txtDireccion.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(554, 86);
            label4.Name = "label4";
            label4.Size = new Size(122, 27);
            label4.TabIndex = 11;
            label4.Text = "Dirección";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.FromArgb(64, 64, 64);
            txtCedula.BorderColor = Color.FromArgb(255, 165, 11);
            txtCedula.BorderFocusColor = SystemColors.HotTrack;
            txtCedula.BorderSize = 6;
            txtCedula.CaretColor = Color.Black;
            txtCedula.CaretCustom = false;
            txtCedula.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCedula.ForeColor = Color.Black;
            txtCedula.Location = new Point(557, 230);
            txtCedula.Margin = new Padding(2, 3, 2, 3);
            txtCedula.MaxLength = 11;
            txtCedula.Multiline = false;
            txtCedula.Name = "txtCedula";
            txtCedula.OnlyNumbers = true;
            txtCedula.Padding = new Padding(6, 5, 6, 5);
            txtCedula.PasswordChar = false;
            txtCedula.Size = new Size(347, 35);
            txtCedula.TabIndex = 12;
            txtCedula.Texts = "";
            txtCedula.UnderlinedStyle = true;
            txtCedula._Enter += txtCedula__Enter;
            txtCedula._Leave += txtCedula__Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(554, 196);
            label5.Name = "label5";
            label5.Size = new Size(142, 27);
            label5.TabIndex = 13;
            label5.Text = "No. Cédula";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(139, 21);
            label6.TabIndex = 14;
            label6.Text = "Agregar cliente";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.FromArgb(255, 165, 11);
            btnAgregarCliente.BackgroundColor = Color.FromArgb(255, 165, 11);
            btnAgregarCliente.BorderColor = Color.PaleVioletRed;
            btnAgregarCliente.BorderRadius = 20;
            btnAgregarCliente.BorderSize = 0;
            btnAgregarCliente.Cursor = Cursors.Hand;
            btnAgregarCliente.FlatAppearance.BorderSize = 0;
            btnAgregarCliente.FlatStyle = FlatStyle.Flat;
            btnAgregarCliente.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(694, 337);
            btnAgregarCliente.Margin = new Padding(3, 4, 3, 4);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(194, 53);
            btnAgregarCliente.TabIndex = 15;
            btnAgregarCliente.Text = "Guardar";
            btnAgregarCliente.TextColor = Color.White;
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BackgroundColor = Color.Transparent;
            btnCancelar.BorderColor = Color.PaleVioletRed;
            btnCancelar.BorderRadius = 20;
            btnCancelar.BorderSize = 0;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(691, 413);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(197, 53);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.White;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(957, 498);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarCliente);
            Controls.Add(label6);
            Controls.Add(txtCedula);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAgregarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAgregarClientes";
            MouseDown += FrmAgregarClientes_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RJControls.RJtextbox txtNombre;
        private Label label1;
        private RJControls.RJtextbox txtTelefono;
        private Label label2;
        private RJControls.RJtextbox txtEmail;
        private Label label3;
        private RJControls.RJtextbox txtDireccion;
        private Label label4;
        private RJControls.RJtextbox txtCedula;
        private Label label5;
        private Label label6;
        private RJControls.RJButton btnAgregarCliente;
        private RJControls.RJButton btnCancelar;
    }
}