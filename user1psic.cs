using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BOOST
{
	public partial class user1psic : Form
	{
		public user1psic()
		{
			InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        // 🔹 1️⃣ Evento que pinta el fondo con degradado azul y plata
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush =
                new LinearGradientBrush(
                    this.ClientRectangle,
                    Color.FromArgb(0, 70, 160),  // Azul elegante
                    Color.Silver,                // Plateado brillante
                    90F))                        // Vertical (90 grados)
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void ptblaura_Click(object sender, EventArgs e)
        {
     
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void user1psic_Load(object sender, EventArgs e)
        {
            // este evento es para poner la imagen circular
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptblaura.Width - 3, ptblaura.Height - 3);
            ptblaura.Region = new Region(gp);
        }

        private void ptblaura_Paint(object sender, PaintEventArgs e)
        {
            // Borde plateado
            System.Drawing.Pen pen = new System.Drawing.Pen(Color.Silver, 4);

            // Suaviza los bordes
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibuja el borde circular
            e.Graphics.DrawEllipse(pen, 2, 2, ptblaura.Width - 6, ptblaura.Height - 6);

            pen.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
