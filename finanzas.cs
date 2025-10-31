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
	public partial class finanzas : Form
	{
		public finanzas()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			inicio formInicio = Application.OpenForms["inicio"] as inicio;

			if (formInicio != null)
			{
				formInicio.openChildForm(new user1fin());
			}
			else
			{
				MessageBox.Show("No se encontró el formulario principal.");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			inicio formInicio = Application.OpenForms["inicio"] as inicio;

			if (formInicio != null)
			{
				formInicio.openChildForm(new user2fin());
			}
			else
			{
				MessageBox.Show("No se encontró el formulario principal.");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			inicio formInicio = Application.OpenForms["inicio"] as inicio;

			if (formInicio != null)
			{
				formInicio.openChildForm(new user3fin());
			}
			else
			{
				MessageBox.Show("No se encontró el formulario principal.");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			inicio formInicio = Application.OpenForms["inicio"] as inicio;

			if (formInicio != null)
			{
				formInicio.openChildForm(new user4fin());
			}
			else
			{
				MessageBox.Show("No se encontró el formulario principal.");
			}
		}
	}
}
