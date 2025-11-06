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
	public partial class user1fin : Form
	{
		public user1fin()
		{
			InitializeComponent();
			this.Paint += new PaintEventHandler(Form1_Paint);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Crear un objeto Graphics a partir del evento PaintEventArgs
            Graphics g = e.Graphics;
            // Definir los colores para el degradado
            Color colorInicio = Color.FromArgb(255, 0, 122, 204); // Azul
            Color colorFin = Color.FromArgb(255, 0, 204, 102);    // Verde
            // Crear un objeto LinearGradientBrush para el fondo degradado
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle, colorInicio, colorFin, System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                // Rellenar el fondo del formulario con el degradado
                g.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void user1fin_Load(object sender, EventArgs e)
        {

            // este evento es para poner la imagen circular
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, fin1.Width - 3, fin1.Height - 3);
            fin1.Region = new Region(gp);
        }
    }
}
