namespace BRAHO_Project
{
    partial class FrmClientes
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            dgvBuscar = new DataGridView();
            BotonCerr = new BRAHO_Project.RJControls.RJButton();
            BotonAgregarCliente = new BRAHO_Project.RJControls.RJButton();
            txtBuscar = new BRAHO_Project.RJControls.RJtextbox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvBuscar
            // 
            dgvBuscar.AllowUserToAddRows = false;
            dgvBuscar.AllowUserToDeleteRows = false;
            dgvBuscar.AllowUserToResizeColumns = false;
            dgvBuscar.AllowUserToResizeRows = false;
            dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBuscar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBuscar.BackgroundColor = Color.FromArgb(102, 102, 102);
            dgvBuscar.BorderStyle = BorderStyle.None;
            dgvBuscar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBuscar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvBuscar.ColumnHeadersHeight = 35;
            dgvBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvBuscar.DefaultCellStyle = dataGridViewCellStyle6;
            dgvBuscar.EnableHeadersVisualStyles = false;
            dgvBuscar.Location = new Point(34, 100);
            dgvBuscar.Margin = new Padding(4);
            dgvBuscar.Name = "dgvBuscar";
            dgvBuscar.ReadOnly = true;
            dgvBuscar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Transparent;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvBuscar.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvBuscar.RowHeadersVisible = false;
            dgvBuscar.RowHeadersWidth = 51;
            dgvBuscar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 165, 11);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dgvBuscar.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvBuscar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscar.Size = new Size(972, 481);
            dgvBuscar.TabIndex = 11;
            dgvBuscar.TabStop = false;
            dgvBuscar.CellClick += dgvBuscar_CellClick;
            dgvBuscar.CellMouseEnter += dgvBuscar_CellMouseEnter;
            dgvBuscar.CellMouseLeave += dgvBuscar_CellMouseLeave;
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
            BotonCerr.Location = new Point(1055, 357);
            BotonCerr.Margin = new Padding(3, 4, 3, 4);
            BotonCerr.Name = "BotonCerr";
            BotonCerr.Size = new Size(151, 53);
            BotonCerr.TabIndex = 15;
            BotonCerr.Text = "Cerrar";
            BotonCerr.TextColor = Color.White;
            BotonCerr.UseVisualStyleBackColor = false;
            BotonCerr.Click += BotonCerr_Click;
            // 
            // BotonAgregarCliente
            // 
            BotonAgregarCliente.BackColor = Color.FromArgb(255, 165, 11);
            BotonAgregarCliente.BackgroundColor = Color.FromArgb(255, 165, 11);
            BotonAgregarCliente.BorderColor = Color.PaleVioletRed;
            BotonAgregarCliente.BorderRadius = 20;
            BotonAgregarCliente.BorderSize = 0;
            BotonAgregarCliente.Cursor = Cursors.Hand;
            BotonAgregarCliente.FlatAppearance.BorderSize = 0;
            BotonAgregarCliente.FlatStyle = FlatStyle.Flat;
            BotonAgregarCliente.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonAgregarCliente.ForeColor = Color.White;
            BotonAgregarCliente.Location = new Point(1055, 204);
            BotonAgregarCliente.Margin = new Padding(3, 4, 3, 4);
            BotonAgregarCliente.Name = "BotonAgregarCliente";
            BotonAgregarCliente.Size = new Size(151, 53);
            BotonAgregarCliente.TabIndex = 14;
            BotonAgregarCliente.Text = "Agregar";
            BotonAgregarCliente.TextColor = Color.White;
            BotonAgregarCliente.UseVisualStyleBackColor = false;
            BotonAgregarCliente.Click += BotonAgregarCliente_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(64, 64, 64);
            txtBuscar.BorderColor = Color.FromArgb(255, 165, 11);
            txtBuscar.BorderFocusColor = SystemColors.HotTrack;
            txtBuscar.BorderSize = 6;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Black;
            txtBuscar.Location = new Point(659, 58);
            txtBuscar.Margin = new Padding(2, 3, 2, 3);
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(6, 5, 6, 5);
            txtBuscar.PasswordChar = false;
            txtBuscar.Size = new Size(347, 35);
            txtBuscar.TabIndex = 16;
            txtBuscar.Texts = "";
            txtBuscar.UnderlinedStyle = true;
            txtBuscar._TextChanged += txtBuscar__TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(611, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(159, 21);
            label6.TabIndex = 18;
            label6.Text = "Gestionar clientes";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1041, 617);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(txtBuscar);
            Controls.Add(BotonCerr);
            Controls.Add(BotonAgregarCliente);
            Controls.Add(dgvBuscar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClientes";
            Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBuscar;
        private RJControls.RJButton BotonCerr;
        private RJControls.RJButton BotonAgregarCliente;
        private RJControls.RJtextbox txtBuscar;
        private PictureBox pictureBox1;
        private Label label6;
    }
}