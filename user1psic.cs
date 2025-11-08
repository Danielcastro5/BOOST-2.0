using AxWMPLib;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace BOOST
{
	public partial class user1psic : Form
	{
		public user1psic()
		{
			InitializeComponent();

        }

		private void user1psic_Load(object sender, EventArgs e)
		{
		
		}

		private void ValidarDisponibilidad()
		{
			DateTime fecha = calendarCitas.SelectionStart.Date;
			DateTime hora = dateTimeHora.Value;
			DateTime fechaCompleta = new DateTime(
				fecha.Year, fecha.Month, fecha.Day,
				hora.Hour, hora.Minute, 0
			);

			using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;Database=logins;User Id=root;password=basquet123"))
			{
				con.Open();
				string query = "SELECT COUNT(*) FROM citas WHERE fecha = @fecha";
				MySqlCommand cmd = new MySqlCommand(query, con);
				cmd.Parameters.AddWithValue("@fecha", fechaCompleta);
				int count = Convert.ToInt32(cmd.ExecuteScalar());

				if (count > 0)
				{
					lblEstadoFecha.Text = "No disponible";
					btnContinuar.Enabled = false;
				}
				else
				{
					lblEstadoFecha.Text = "Disponible";
					btnContinuar.Enabled = true;
				}
			}
		}

		private void calendarCitas_DateChanged(object sender, DateRangeEventArgs e)
		{
			dateTimeHora.Format = DateTimePickerFormat.Time;
			dateTimeHora.ShowUpDown = true;
			ValidarDisponibilidad();
		}

		private void btnContinuar_Click(object sender, EventArgs e)
		{
			DateTime fecha = calendarCitas.SelectionStart.Date;
			DateTime hora = dateTimeHora.Value;
			DateTime fechaCompleta = new DateTime(
				fecha.Year, fecha.Month, fecha.Day,
				hora.Hour, hora.Minute, 0
			);

			MySqlConnection con = new MySqlConnection("server=127.0.0.1;Database=logins;User Id=root;password=basquet123");
			con.Open();
			string query = "SELECT COUNT(*) FROM citas WHERE fecha = @fecha";
			MySqlCommand cmd = new MySqlCommand(query, con);
			cmd.Parameters.AddWithValue("@fecha", fechaCompleta);
			int count = Convert.ToInt32(cmd.ExecuteScalar());
			con.Close();

			if (count > 0)
			{
				MessageBox.Show("Esa fecha y hora ya están ocupadas.");
			}
			else
			{
				Formpago pago = new Formpago(fechaCompleta);
				pago.ShowDialog();
			}
		}



		private void lblEstadoFecha_Click(object sender, EventArgs e)
		{

		}

		private void dateTimeHora_ValueChanged(object sender, EventArgs e)
		{
			dateTimeHora.Format = DateTimePickerFormat.Time;
			dateTimeHora.ShowUpDown = true;
			ValidarDisponibilidad();

		}

	
	}
}
