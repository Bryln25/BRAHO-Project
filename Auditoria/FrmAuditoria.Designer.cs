namespace BRAHO_Project
{
    partial class FrmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuditoria));
            dgvBuscar = new DataGridView();
            BotonCerr = new BRAHO_Project.RJControls.RJButton();
            txtBuscar = new BRAHO_Project.RJControls.RJtextbox();
            btnLupa = new PictureBox();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            mover = new System.Windows.Forms.Timer(components);
            txtOculto = new BRAHO_Project.RJControls.RJtextbox();
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
            dgvBuscar.Location = new Point(10, 106);
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
            dgvBuscar.Size = new Size(1018, 481);
            dgvBuscar.TabIndex = 11;
            dgvBuscar.TabStop = false;
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
            BotonCerr.Location = new Point(1088, 552);
            BotonCerr.Margin = new Padding(3, 4, 3, 4);
            BotonCerr.Name = "BotonCerr";
            BotonCerr.Size = new Size(103, 35);
            BotonCerr.TabIndex = 15;
            BotonCerr.Text = "Cerrar";
            BotonCerr.TextColor = Color.White;
            BotonCerr.UseVisualStyleBackColor = false;
            BotonCerr.Click += BotonCerr_Click;
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
            label6.Size = new Size(86, 21);
            label6.TabIndex = 18;
            label6.Text = "Auditoria";
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
            // FrmAuditoria
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1041, 617);
            Controls.Add(BotonCerr);
            Controls.Add(txtOculto);
            Controls.Add(label6);
            Controls.Add(btnLupa);
            Controls.Add(txtBuscar);
            Controls.Add(dgvBuscar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAuditoria";
            Text = "FrmGastos";
            Load += FrmAuditoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLupa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBuscar;
        private RJControls.RJButton BotonCerr;
        private RJControls.RJtextbox txtBuscar;
        private PictureBox btnLupa;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer mover;
        private RJControls.RJtextbox txtOculto;
    }
}