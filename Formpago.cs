using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace BOOST
{
	public partial class Formpago : Form
	{
		private DateTime fechaCita;

		public Formpago(DateTime fecha)
		{
			InitializeComponent();
			fechaCita = fecha;
		}



		private void txtntarjeta_Enter(object sender, EventArgs e)
		{
			if (txtntarjeta.Text == "Numero de Tarjeta")
			{
				txtntarjeta.Text = "";
				txtntarjeta.ForeColor = Color.Black;
			}
		}

		private void txtntarjeta_Leave(object sender, EventArgs e)
		{
			if (txtntarjeta.Text == "")
			{
				txtntarjeta.Text = "Numero de Tarjeta";
				txtntarjeta.ForeColor = Color.Black;
			}
		}

		private void txtnombre_Enter(object sender, EventArgs e)
		{
			if (txtnombre.Text == "Nombre del Titular")
			{
				txtnombre.Text = "";
				txtnombre.ForeColor = Color.Black;
			}
		}

		private void txtnombre_Leave(object sender, EventArgs e)
		{
			if (txtnombre.Text == "")
			{
				txtnombre.Text = "Nombre del Titular";
				txtnombre.ForeColor = Color.Black;
			}
		}

		private void txtfecha_Enter(object sender, EventArgs e)
		{
			if (txtfecha.Text == "Fecha Expedicion")
			{
				txtfecha.Text = "";
				txtfecha.ForeColor = Color.Black;
			}
		}

		private void txtfecha_Leave(object sender, EventArgs e)
		{
			if (txtfecha.Text == "")
			{
				txtfecha.Text = "Fecha Expedicion";
				txtfecha.ForeColor = Color.Black;	
			}
		}

		private void txtcodigo_Enter(object sender, EventArgs e)
		{
			if (txtcodigo.Text == "Codigo Postal")
			{
				txtcodigo.Text = "";
				txtcodigo.ForeColor = Color.Black;
			}
		}

		private void txtcodigo_Leave(object sender, EventArgs e)
		{
			if (txtcodigo.Text == "")
			{
				txtcodigo.Text = "Codigo Postal";
				txtcodigo.ForeColor = Color.Black;
			}
		}

		private void txtcvc_Enter(object sender, EventArgs e)
		{
			if (txtcvc.Text == "Pin")
			{
				txtcvc.Text = "";
				txtcvc.ForeColor = Color.Black;
			}
		}

		private void txtcvc_Leave(object sender, EventArgs e)
		{
			if (txtcvc.Text == "")
			{
				txtcvc.Text = "Pin";
				txtcvc.ForeColor = Color.Black;
			}
		}

		private void txtdireccion_Enter(object sender, EventArgs e)
		{
			if (txtdireccion.Text == "Direccion(obligatorio)")
			{
				txtdireccion.Text = "";
				txtdireccion.ForeColor = Color.Black;
			}
		}

		private void txtdireccion_Leave(object sender, EventArgs e)
		{
			if (txtdireccion.Text == "")
			{
				txtdireccion.Text = "Direccion(obligatorio)";
				txtdireccion.ForeColor = Color.Black;
			}
		}

		private void btncancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnpagar_Click(object sender, EventArgs e)
		{
			string usuario = "user1psic";

			MySqlConnection con = new MySqlConnection("server=127.0.0.1;Database=logins;User Id=root;password=basquet123");
			con.Open();
			string query = "INSERT INTO citas (usuario, fecha, estado) VALUES (@usuario, @fecha, 'ocupada')";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@usuario", usuario);
			cmd.Parameters.AddWithValue("@fecha", fechaCita);
			cmd.ExecuteNonQuery();
			con.Close();

			System.Windows.MessageBox.Show("Cita agendada exitosamente.");
			this.Close();


		}

	}
}