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
	public partial class editaruser : Form
	{
		public editaruser()
		{
			InitializeComponent();
		}

		private void txteuser_Enter(object sender, EventArgs e)
		{
			if (txteuser.Text == "USUARIO")
			{
				txteuser.Text = "";
				txteuser.ForeColor = Color.Black;
			}
		}

		private void txteuser_Leave(object sender, EventArgs e)
		{
			if (txteuser.Text == "")
			{
				txteuser.Text = "USUARIO";
				txteuser.ForeColor = Color.Black;
			}
		}

		private void txtecorreo_Enter(object sender, EventArgs e)
		{
			if (txtecorreo.Text == "CORREO")
			{
				txtecorreo.Text = "";
				txtecorreo.ForeColor = Color.Black;
			}
		}

		private void txtecorreo_Leave(object sender, EventArgs e)
		{
			if (txtecorreo.Text == "")
			{
				txtecorreo.Text = "CORREO";
				txtecorreo.ForeColor = Color.Black;
			}
		}

		private void txtapass_Enter(object sender, EventArgs e)
		{
			if (txtapass.Text == "CONTRASEÑA ACTUAL")
			{
				txtapass.Text = "";
				txtapass.ForeColor = Color.Black;
			}
		}

		private void txtapass_Leave(object sender, EventArgs e)
		{
			if (txtapass.Text == "")
			{
				txtapass.Text = "CONTRASEÑA ACTUAL";
				txtapass.ForeColor = Color.Black;
			}
		}

		private void txtepass_Enter(object sender, EventArgs e)
		{
			if (txtepass.Text == "NUEVA CONTRASEÑA")
			{
				txtepass.Text = "";
				txtepass.ForeColor = Color.Black;
			}
		}

		private void txtepass_Leave(object sender, EventArgs e)
		{
			if (txtepass.Text == "")
			{
				txtepass.Text = "NUEVA CONTRASEÑA";
				txtepass.ForeColor = Color.Black;
			}
		}
	}
}
