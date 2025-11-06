using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BOOST
{
	public partial class user3psic : Form
	{
		public user3psic()
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
        private void user3psic_Load(object sender, EventArgs e)
        {

            // este evento es para poner la imagen circular
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptb3.Width - 3, ptb3.Height - 3);
            ptb3.Region = new Region(gp);

        }
    }
}
