using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BOOST
{
	public partial class register : Form
	{
		public register()
		{
			InitializeComponent();
		}

		private void txtcorreo_Enter(object sender, EventArgs e)
		{
			if (txtcorreo.Text == "CORREO")
			{
				txtcorreo.Text = "";
				txtcorreo.ForeColor = Color.Black;
				txtcorreo.RightToLeft = RightToLeft.No;
			}
		}

		private void txtcorreo_Leave(object sender, EventArgs e)
		{
			if (txtcorreo.Text == "")
			{
				txtcorreo.Text = "CORREO";
				txtcorreo.ForeColor = Color.Black;
				txtcorreo.RightToLeft = RightToLeft.No;
			}
		}

		private void txtruser_Enter(object sender, EventArgs e)
		{
			if (txtruser.Text == "USUARIO")
			{
				txtruser.Text = "";
				txtruser.ForeColor = Color.Black;
			}
		}

		private void txtruser_Leave(object sender, EventArgs e)
		{
			if (txtruser.Text == "")
			{
				txtruser.Text = "USUARIO";
				txtruser.ForeColor = Color.Black;
			}
		}

		private void txtrpass_Enter(object sender, EventArgs e)
		{
			if (txtrpass.Text == "CONTRASEÑA")
			{
				txtrpass.Text = "";
				txtrpass.ForeColor = Color.Black;
				txtrpass.UseSystemPasswordChar = true;
			}
		}

		private void txtrpass_Leave(object sender, EventArgs e)
		{
			if (txtrpass.Text == "")
			{
				txtrpass.Text = "CONTRASEÑA";
				txtrpass.ForeColor = Color.Black;
				txtrpass.UseSystemPasswordChar = false;
			}
		}

		private void txtrpass2_Enter(object sender, EventArgs e)
		{
			if (txtrpass2.Text == "CONFIRMAR CONTRASEÑA")
			{
				txtrpass2.Text = "";
				txtrpass2.ForeColor = Color.Black;
				txtrpass2.UseSystemPasswordChar = true;

			}
		}

		private void txtrpass2_Leave(object sender, EventArgs e)
		{
			if (txtrpass2.Text == "")
			{
				txtrpass2.Text = "CONFIRMAR CONTRASEÑA";
				txtrpass2.ForeColor = Color.Black;
				txtrpass2.UseSystemPasswordChar = false;
			}
		}

		private void btnregistrar_Click(object sender, EventArgs e)
		{
			string correo = txtcorreo.Text;
			string username = txtruser.Text;
			string password = txtrpass.Text;
			string confirmPassword = txtrpass2.Text;

			if (password != confirmPassword)
			{
				MessageBox.Show("Las contraseñas no coinciden.");
				return;
			}

			if (!IsValidEmail(correo))
			{
				MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
				return;
			}

			MySqlConnection con = new MySqlConnection("server = 127.0.0.1; Database=logins; User Id = root; password=tarrao");
			try
			{
				con.Open();
				string checkUserQuery = "SELECT COUNT(*) FROM users WHERE user=@username";
				MySqlCommand checkUserCommand = new MySqlCommand(checkUserQuery, con);
				checkUserCommand.Parameters.AddWithValue("@username", username);

				int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());
				if (userCount > 0)
				{
					MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro nombre de usuario.");
				}
				else
				{
					string insertQuery = "INSERT INTO users (user, pass, correo) VALUES (@username, @password, @correo)";
					MySqlCommand insertCommand = new MySqlCommand(insertQuery, con);
					insertCommand.Parameters.AddWithValue("@username", username);
					insertCommand.Parameters.AddWithValue("@password", password);
					insertCommand.Parameters.AddWithValue("@correo", correo);
					insertCommand.ExecuteNonQuery();
					MessageBox.Show("Usuario registrado con éxito.");
					Form Form1 = new Form1();
					Form1.Show();
					this.Hide();
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
		private bool IsValidEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form MsgBox = new MsgBox();
			MsgBox.Show();
		}

		private void btnregresar_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form Form1 = new Form1();
			Form1.Show();
		}

		private void profesionalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form Form1 = new Form1();
			Form1.Show();
		}

        private void txtruser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
