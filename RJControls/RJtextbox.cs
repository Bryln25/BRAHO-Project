using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRAHO_Project.RJControls
{
    public partial class RJtextbox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        public RJtextbox()
        {
            InitializeComponent();
            textBox1.KeyUp += (s, ev) => textBox1.Invalidate();
            textBox1.MouseUp += (s, ev) => textBox1.Invalidate();

            textBox1.TextChanged += (s, ev) => textBox1.Invalidate();
        }


        //Properties
        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("RJ Code Advance")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("RJ Code Advance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("RJ Code Advance")]
        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Category("RJ Code Advance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [Category("RJ Code Advance")]
        public int MaxLength
        {
            get { return textBox1.MaxLength; }
            set { textBox1.MaxLength = value; }
        }

        [Category("RJ Code Advance")]
        public bool OnlyNumbers { get; set; } = false;

        [Category("RJ Code Advance")]
        public bool CaretCustom { get; set; } = false;

        [Category("RJ Code Advance")]
        public Color CaretColor { get; set; } = Color.Black;


        //Private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        //Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if(!isFocused)
                {
                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;

                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }                
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        [DllImport("user32.dll")]
        private static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport("user32.dll")]
        private static extern bool ShowCaret(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool DestroyCaret();

        public event EventHandler _Enter;
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (_Enter != null)
                _Enter.Invoke(sender, e);

            isFocused = true;
            this.Invalidate();

            if (CaretCustom)
            {
                // Crear caret con ancho fijo (2px) y alto de la fuente
                CreateCaret(textBox1.Handle, IntPtr.Zero, 2, textBox1.Font.Height);
                ShowCaret(textBox1.Handle);

                // Usar un timer para repintar el caret con el color deseado
                System.Windows.Forms.Timer caretTimer = new System.Windows.Forms.Timer();
                caretTimer.Interval = 50;
                caretTimer.Tick += (s, ev) =>
                {
                    using (Graphics g = textBox1.CreateGraphics())
                    {
                        // Obtener la posición actual del caret (donde está SelectionStart)
                        int x = textBox1.GetPositionFromCharIndex(textBox1.SelectionStart).X;
                        int y = textBox1.GetPositionFromCharIndex(textBox1.SelectionStart).Y;

                        // Dibujar el caret en esa posición
                        using (Brush b = new SolidBrush(CaretColor))
                        {
                            g.FillRectangle(b, new Rectangle(x, y, 2, textBox1.Font.Height));
                        }
                    }
                };
                caretTimer.Start();

                // Guardamos el timer en Tag para poder detenerlo luego
                textBox1.Tag = caretTimer;
            }            
        }

        public event EventHandler _Leave;
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (_Leave != null)
                _Leave.Invoke(sender, e);

            isFocused = false;
            this.Invalidate();

            if (CaretCustom)
            {
                // Detener el caret personalizado
                if (textBox1.Tag is System.Windows.Forms.Timer caretTimer)
                {
                    caretTimer.Stop();
                    caretTimer.Dispose();
                }

                DestroyCaret();
            }
            
        }


        //Default Event
        public event EventHandler _TextChanged;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }


        //TextBox events
        /// <summary>
        /// textbox events attached to user control events
        /// </summary>
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        public event KeyPressEventHandler _KeyPress;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (OnlyNumbers)
            {
                // Solo permitir dígitos y teclas de control (ej: backspace)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if (_KeyPress != null)
                _KeyPress.Invoke(sender, e);
        }


    }
}
