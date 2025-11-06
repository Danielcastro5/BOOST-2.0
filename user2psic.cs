using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BOOST
{
    public partial class user2psic : Form
    {
        public user2psic()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(user2psic_Paint);
        }

        private void user2psic_Load(object sender, EventArgs e)
        {
            // este evento es para poner la imagen circular

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ptbandres.Width - 3, ptbandres.Height - 3);
            ptbandres.Region = new Region(gp);

        }
        private void user2psic_Paint(object sender, PaintEventArgs e)
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
        private void user2psic_Load_1(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ptbandres_Click(object sender, EventArgs e)
        {

        }
    }
}
