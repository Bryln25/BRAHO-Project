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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            dgvBuscar = new DataGridView();
            BotonCerr = new BRAHO_Project.RJControls.RJButton();
            BotonAgregarCliente = new BRAHO_Project.RJControls.RJButton();
            txtBuscar = new BRAHO_Project.RJControls.RJtextbox();
            btnLupa = new PictureBox();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            mover = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLupa).BeginInit();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBuscar.ColumnHeadersHeight = 35;
            dgvBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBuscar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBuscar.EnableHeadersVisualStyles = false;
            dgvBuscar.Location = new Point(34, 100);
            dgvBuscar.Margin = new Padding(4);
            dgvBuscar.Name = "dgvBuscar";
            dgvBuscar.ReadOnly = true;
            dgvBuscar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBuscar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBuscar.RowHeadersVisible = false;
            dgvBuscar.RowHeadersWidth = 51;
            dgvBuscar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(102, 102, 102);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 165, 11);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvBuscar.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            BotonCerr.Location = new Point(1055, 528);
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
            BotonAgregarCliente.Location = new Point(1055, 443);
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
            txtBuscar.CaretColor = Color.Black;
            txtBuscar.CaretCustom = false;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.Gainsboro;
            txtBuscar.Location = new Point(659, 55);
            txtBuscar.Margin = new Padding(2, 3, 2, 3);
            txtBuscar.MaxLength = 32767;
            txtBuscar.Multiline = false;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.OnlyNumbers = false;
            txtBuscar.Padding = new Padding(6, 5, 6, 5);
            txtBuscar.PasswordChar = false;
            txtBuscar.Size = new Size(0, 35);
            txtBuscar.TabIndex = 16;
            txtBuscar.Texts = "";
            txtBuscar.UnderlinedStyle = true;
            txtBuscar._TextChanged += txtBuscar__TextChanged;
            // 
            // btnLupa
            // 
            btnLupa.Cursor = Cursors.Hand;
            btnLupa.Image = (Image)resources.GetObject("btnLupa.Image");
            btnLupa.Location = new Point(611, 49);
            btnLupa.Name = "btnLupa";
            btnLupa.Size = new Size(43, 47);
            btnLupa.SizeMode = PictureBoxSizeMode.Zoom;
            btnLupa.TabIndex = 17;
            btnLupa.TabStop = false;
            btnLupa.Click += btnLupa_Click;
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
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1041, 617);
            Controls.Add(label6);
            Controls.Add(btnLupa);
            Controls.Add(txtBuscar);
            Controls.Add(BotonCerr);
            Controls.Add(BotonAgregarCliente);
            Controls.Add(dgvBuscar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLupa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBuscar;
        private RJControls.RJButton BotonCerr;
        private RJControls.RJButton BotonAgregarCliente;
        private RJControls.RJtextbox txtBuscar;
        private PictureBox btnLupa;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer mover;
    }
}