namespace BRAHO_Project
{
    partial class FrmEditarClientes
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
            btnEditarCliente = new BRAHO_Project.RJControls.RJButton();
            btnCancelar = new BRAHO_Project.RJControls.RJButton();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(127, 127, 127);
            txtNombre.BorderColor = Color.FromArgb(255, 165, 11);
            txtNombre.BorderFocusColor = SystemColors.HotTrack;
            txtNombre.BorderSize = 6;
            txtNombre.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(111, 120);
            txtNombre.Margin = new Padding(2, 3, 2, 3);
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
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
            txtTelefono.BackColor = Color.FromArgb(127, 127, 127);
            txtTelefono.BorderColor = Color.FromArgb(255, 165, 11);
            txtTelefono.BorderFocusColor = SystemColors.HotTrack;
            txtTelefono.BorderSize = 6;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(108, 230);
            txtTelefono.Margin = new Padding(2, 3, 2, 3);
            txtTelefono.Multiline = false;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(6, 5, 6, 5);
            txtTelefono.PasswordChar = false;
            txtTelefono.Size = new Size(347, 35);
            txtTelefono.TabIndex = 6;
            txtTelefono.Texts = "";
            txtTelefono.UnderlinedStyle = true;
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
            txtEmail.BackColor = Color.FromArgb(127, 127, 127);
            txtEmail.BorderColor = Color.FromArgb(255, 165, 11);
            txtEmail.BorderFocusColor = SystemColors.HotTrack;
            txtEmail.BorderSize = 6;
            txtEmail.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(111, 342);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
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
            txtDireccion.BackColor = Color.FromArgb(127, 127, 127);
            txtDireccion.BorderColor = Color.FromArgb(255, 165, 11);
            txtDireccion.BorderFocusColor = SystemColors.HotTrack;
            txtDireccion.BorderSize = 6;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDireccion.ForeColor = Color.Black;
            txtDireccion.Location = new Point(557, 120);
            txtDireccion.Margin = new Padding(2, 3, 2, 3);
            txtDireccion.Multiline = false;
            txtDireccion.Name = "txtDireccion";
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
            txtCedula.BackColor = Color.FromArgb(127, 127, 127);
            txtCedula.BorderColor = Color.FromArgb(255, 165, 11);
            txtCedula.BorderFocusColor = SystemColors.HotTrack;
            txtCedula.BorderSize = 6;
            txtCedula.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCedula.ForeColor = Color.Black;
            txtCedula.Location = new Point(557, 230);
            txtCedula.Margin = new Padding(2, 3, 2, 3);
            txtCedula.Multiline = false;
            txtCedula.Name = "txtCedula";
            txtCedula.Padding = new Padding(6, 5, 6, 5);
            txtCedula.PasswordChar = false;
            txtCedula.Size = new Size(347, 35);
            txtCedula.TabIndex = 12;
            txtCedula.Texts = "";
            txtCedula.UnderlinedStyle = true;
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
            label6.Size = new Size(119, 21);
            label6.TabIndex = 14;
            label6.Text = "Editar cliente";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.FromArgb(255, 165, 11);
            btnEditarCliente.BackgroundColor = Color.FromArgb(255, 165, 11);
            btnEditarCliente.BorderColor = Color.PaleVioletRed;
            btnEditarCliente.BorderRadius = 20;
            btnEditarCliente.BorderSize = 0;
            btnEditarCliente.Cursor = Cursors.Hand;
            btnEditarCliente.FlatAppearance.BorderSize = 0;
            btnEditarCliente.FlatStyle = FlatStyle.Flat;
            btnEditarCliente.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarCliente.ForeColor = Color.White;
            btnEditarCliente.Location = new Point(694, 337);
            btnEditarCliente.Margin = new Padding(3, 4, 3, 4);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(194, 53);
            btnEditarCliente.TabIndex = 15;
            btnEditarCliente.Text = "Guardar";
            btnEditarCliente.TextColor = Color.White;
            btnEditarCliente.UseVisualStyleBackColor = false;
            btnEditarCliente.Click += btnEditarCliente_Click;
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
            // FrmEditarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 127, 127);
            ClientSize = new Size(957, 498);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditarCliente);
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
            Name = "FrmEditarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAgregarClientes";
            Load += FrmAgregarClientes_Load;
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
        private RJControls.RJButton btnEditarCliente;
        private RJControls.RJButton btnCancelar;
    }
}