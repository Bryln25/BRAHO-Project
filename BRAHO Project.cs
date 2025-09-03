using System.Runtime.InteropServices;

namespace BRAHO_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Desactivar la escala automática
            this.AutoScaleMode = AutoScaleMode.None;

            // Establecer un tamaño fijo
            this.ClientSize = new Size(1312, 750);
        }


        //Codigo para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        bool menuExpandido = true;

        private void BotonSlide_Click(object sender, EventArgs e)
        {
            timer1.Start();

            pictureBox1.Visible = !pictureBox1.Visible;
        }



        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonMininizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                // Reducir el ancho hasta llegar a 70
                MenuVertical.Width -= 10;
                if (MenuVertical.Width <= 60)
                {
                    menuExpandido = false;
                    timer1.Stop();
                }
            }
            else
            {
                // Aumentar el ancho hasta llegar a 250
                MenuVertical.Width += 10;
                if (MenuVertical.Width >= 250)
                {
                    menuExpandido = true;
                    timer1.Stop();
                }
            }
        }
    }
}
