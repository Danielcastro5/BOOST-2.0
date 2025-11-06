using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BOOST
{
	public partial class user1lab : Form
	{
		public user1lab()
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

        private void user1lab_Load(object sender, EventArgs e)
        {
            // este evento es para poner la imagen circular
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, lab1.Width - 3, lab1.Height - 3);
            lab1.Region = new Region(gp);
        }
    }
    }

