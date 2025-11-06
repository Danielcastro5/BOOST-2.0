using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BOOST
{
	public partial class user4psic : Form
	{
		public user4psic()
		{
			InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void user4psic_Load(object sender, EventArgs e)
        {
            // este evento es para poner la imagen circular
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptb4.Width - 3, ptb4.Height - 3);
            ptb4.Region = new Region(gp);

        }
    }
}
