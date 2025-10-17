using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRAHO_Project
{
    internal class Funciones
    {
        public Funciones() { }

        // Método para redondear las esquinas de un formulario
        public static void RedondearForm(Form form)
        {
            int radio = 30; // Ajusta el nivel de redondeado
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();

                // Esquinas redondeadas
                path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
                path.AddArc(new Rectangle(form.Width - radio, 0, radio, radio), 270, 90);
                path.AddArc(new Rectangle(form.Width - radio, form.Height - radio, radio, radio), 0, 90);
                path.AddArc(new Rectangle(0, form.Height - radio, radio, radio), 90, 90);

                path.CloseFigure();
                form.Region = new Region(path);
            }
        }

        // Método para permitir mover el formulario arrastrando cualquier parte de él
        public static void MoverForm(Form form)
        {
            //Codigo para mover el formulario
            [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            extern static void ReleaseCapture();
            [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
            extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
            ReleaseCapture();
            SendMessage(form.Handle, 0x112, 0xf012, 0);
        }

        // Métodos para redondear una imagen en un PictureBox
        public static void RedondearImagen(PictureBox pictureBox)
        {
            if (pictureBox.Image == null) return;

            // Asegurar que el PictureBox sea cuadrado
            int size = Math.Min(pictureBox.Width, pictureBox.Height);
            pictureBox.Size = new Size(size, size);

            // Crear una nueva imagen redonda recortada del centro
            Image roundedImage = RecortarYRedondearImagen(pictureBox.Image, size);

            // Asignar la imagen redonda al PictureBox
            pictureBox.Image = roundedImage;

            // Aplicar región circular (opcional, ya que la imagen ya es redonda)
            var gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, size, size);
            pictureBox.Region = new Region(gp);
        }

        private static Image RecortarYRedondearImagen(Image originalImage, int size)
        {
            int width = originalImage.Width;
            int height = originalImage.Height;

            // Calcular el tamaño del recuadro central (mínimo entre ancho y alto)
            int cropSize = Math.Min(width, height);
            int x = (width - cropSize) / 2;
            int y = (height - cropSize) / 2;

            // Recortar la imagen al centro
            Bitmap cropped = new Bitmap(cropSize, cropSize);
            using (Graphics g = Graphics.FromImage(cropped))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawImage(originalImage, new Rectangle(0, 0, cropSize, cropSize),
                            new Rectangle(x, y, cropSize, cropSize), GraphicsUnit.Pixel);
            }

            // Escalar a tamaño final (cuadrado)
            Bitmap scaled = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(scaled))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawImage(cropped, 0, 0, size, size);
            }

            // Aplicar máscara circular
            Bitmap circular = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(circular))
            {
                g.Clear(Color.Transparent); // Fondo transparente
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddEllipse(0, 0, size, size);
                    g.SetClip(path);
                    g.DrawImage(scaled, 0, 0);
                }
            }

            return circular;
        }

        // Método para obtener un rectángulo redondeado
        public static GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Método para hashear una contraseña
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
