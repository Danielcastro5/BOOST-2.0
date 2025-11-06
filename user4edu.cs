using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOST
{
	public partial class user4edu : Form
	{
		public user4edu()
		{
			InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // este evento es para poner el borde degradado
            System.Drawing.Drawing2D.LinearGradientBrush lgb = new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle, Color.FromArgb(0, 122, 204), Color.FromArgb(0, 153, 255), 90F);
            Pen pen = new Pen(lgb, 10);
            e.Graphics.DrawRectangle(pen, this.DisplayRectangle);
        }
        private void user4edu_Load(object sender, EventArgs e)
        {
            // este evento es para poner la imagen circular
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, edu4.Width - 3, edu4.Height - 3);
            edu4.Region = new Region(gp);
        }
    }
}
