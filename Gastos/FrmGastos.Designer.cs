namespace BRAHO_Project
{
    partial class FrmGastos
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGastos));
            dgvBuscar = new DataGridView();
            BotonCerr = new BRAHO_Project.RJControls.RJButton();
            BotonAgregarGastos = new BRAHO_Project.RJControls.RJButton();
            txtBuscar = new BRAHO_Project.RJControls.RJtextbox();
            btnLupa = new PictureBox();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            mover = new System.Windows.Forms.Timer(components);
            txtOculto = new BRAHO_Project.RJControls.RJtextbox();
            label1 = new Label();
            btnFiltrar = new BRAHO_Project.RJControls.RJButton();
            lblTotalMontos = new Label();
            dtpFechaInicio = new BRAHO_Project.RJControls.RJDatePick();
            dtpFechaFinal = new BRAHO_Project.RJControls.RJDatePick();
            label2 = new Label();
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
            dgvBuscar.Location = new Point(28, 106);
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
            // BotonAgregarGastos
            // 
            BotonAgregarGastos.BackColor = Color.FromArgb(255, 165, 11);
            BotonAgregarGastos.BackgroundColor = Color.FromArgb(255, 165, 11);
            BotonAgregarGastos.BorderColor = Color.PaleVioletRed;
            BotonAgregarGastos.BorderRadius = 20;
            BotonAgregarGastos.BorderSize = 0;
            BotonAgregarGastos.Cursor = Cursors.Hand;
            BotonAgregarGastos.FlatAppearance.BorderSize = 0;
            BotonAgregarGastos.FlatStyle = FlatStyle.Flat;
            BotonAgregarGastos.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonAgregarGastos.ForeColor = Color.White;
            BotonAgregarGastos.Location = new Point(1055, 443);
            BotonAgregarGastos.Margin = new Padding(3, 4, 3, 4);
            BotonAgregarGastos.Name = "BotonAgregarGastos";
            BotonAgregarGastos.Size = new Size(151, 53);
            BotonAgregarGastos.TabIndex = 14;
            BotonAgregarGastos.Text = "Agregar";
            BotonAgregarGastos.TextColor = Color.White;
            BotonAgregarGastos.UseVisualStyleBackColor = false;
            BotonAgregarGastos.Click += BotonAgregarGastos_Click;
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
            txtBuscar.Location = new Point(654, 49);
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
            btnLupa.Location = new Point(606, 43);
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
            label6.Size = new Size(155, 21);
            label6.TabIndex = 18;
            label6.Text = "Gestionar Gastos";
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
            txtOculto.Location = new Point(1023, 9);
            txtOculto.Margin = new Padding(2, 3, 2, 3);
            txtOculto.MaxLength = 32767;
            txtOculto.Multiline = false;
            txtOculto.Name = "txtOculto";
            txtOculto.OnlyNumbers = false;
            txtOculto.Padding = new Padding(6, 5, 6, 5);
            txtOculto.PasswordChar = false;
            txtOculto.Size = new Size(0, 35);
            txtOculto.TabIndex = 19;
            txtOculto.Texts = "";
            txtOculto.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1023, 106);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 55;
            label1.Text = "Desde";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(255, 165, 11);
            btnFiltrar.BackgroundColor = Color.FromArgb(255, 165, 11);
            btnFiltrar.BorderColor = Color.PaleVioletRed;
            btnFiltrar.BorderRadius = 10;
            btnFiltrar.BorderSize = 0;
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(1055, 308);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(134, 40);
            btnFiltrar.TabIndex = 57;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextColor = Color.White;
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // lblTotalMontos
            // 
            lblTotalMontos.AutoSize = true;
            lblTotalMontos.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalMontos.ForeColor = Color.White;
            lblTotalMontos.Location = new Point(1024, 381);
            lblTotalMontos.Name = "lblTotalMontos";
            lblTotalMontos.Size = new Size(0, 21);
            lblTotalMontos.TabIndex = 58;
            lblTotalMontos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.BorderColor = Color.FromArgb(255, 165, 11);
            dtpFechaInicio.BorderSize = 2;
            dtpFechaInicio.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold);
            dtpFechaInicio.Location = new Point(1023, 147);
            dtpFechaInicio.MinimumSize = new Size(4, 35);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 35);
            dtpFechaInicio.SkinColor = Color.FromArgb(64, 64, 64);
            dtpFechaInicio.TabIndex = 59;
            dtpFechaInicio.TextColor = Color.White;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.BorderColor = Color.FromArgb(255, 165, 11);
            dtpFechaFinal.BorderSize = 2;
            dtpFechaFinal.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold);
            dtpFechaFinal.Location = new Point(1023, 237);
            dtpFechaFinal.MinimumSize = new Size(4, 35);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(200, 35);
            dtpFechaFinal.SkinColor = Color.FromArgb(64, 64, 64);
            dtpFechaFinal.TabIndex = 60;
            dtpFechaFinal.TextColor = Color.White;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1024, 201);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 56;
            label2.Text = "Hasta";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmGastos
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1271, 617);
            Controls.Add(dtpFechaFinal);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblTotalMontos);
            Controls.Add(btnFiltrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOculto);
            Controls.Add(label6);
            Controls.Add(btnLupa);
            Controls.Add(txtBuscar);
            Controls.Add(BotonCerr);
            Controls.Add(BotonAgregarGastos);
            Controls.Add(dgvBuscar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGastos";
            Text = "FrmGastos";
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLupa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBuscar;
        private RJControls.RJButton BotonCerr;
        private RJControls.RJButton BotonAgregarGastos;
        private RJControls.RJtextbox txtBuscar;
        private PictureBox btnLupa;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer mover;
        private RJControls.RJtextbox txtOculto;
        private Label label1;
        private RJControls.RJButton btnFiltrar;
        private Label lblTotalMontos;
        private RJControls.RJDatePick dtpFechaInicio;
        private RJControls.RJDatePick dtpFechaFinal;
        private Label label2;
    }
}