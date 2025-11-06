using MySql.Data.MySqlClient;
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
				txtecorreo.RightToLeft = RightToLeft.No;
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
				txtapass.UseSystemPasswordChar = true;
			}
		}

		private void txtapass_Leave(object sender, EventArgs e)
		{
			if (txtapass.Text == "")
			{
				txtapass.Text = "CONTRASEÑA ACTUAL";
				txtapass.ForeColor = Color.Black;
				txtapass.UseSystemPasswordChar = false;
			}
		}

		private void txtepass_Enter(object sender, EventArgs e)
		{
			if (txtepass.Text == "NUEVA CONTRASEÑA")
			{
				txtepass.Text = "";
				txtepass.ForeColor = Color.Black;
				txtepass.UseSystemPasswordChar = true;
			}
		}

		private void txtepass_Leave(object sender, EventArgs e)
		{
			if (txtepass.Text == "")
			{
				txtepass.Text = "NUEVA CONTRASEÑA";
				txtepass.ForeColor = Color.Black;
				txtepass.UseSystemPasswordChar = false;
			}
		}

		private void btnguardar_Click(object sender, EventArgs e)
		{
			string username = txteuser.Text.Trim();
			string correo = txtecorreo.Text.Trim();
			string currentPassword = txtapass.Text;
			string newPassword = txtepass.Text;

			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(correo) ||
				string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword))
			{
				MessageBox.Show("Por favor, complete todos los campos.");
				return;
			}

			if (!IsValidEmail(correo))
			{
				MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
				return;
			}

			MySqlConnection con = new MySqlConnection("server=127.0.0.1;Database=logins;User Id=root;password=tarrao");
			try
			{
				con.Open();

				string checkQuery = "SELECT pass FROM users WHERE user = @username";
				MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
				checkCmd.Parameters.AddWithValue("@username", username);

				object result = checkCmd.ExecuteScalar();
				if (result == null)
				{
					MessageBox.Show("El usuario no existe.");
					return;
				}

				string storedPassword = result.ToString();
				if (storedPassword != currentPassword)
				{
					MessageBox.Show("La contraseña actual es incorrecta.");
					return;
				}

				string updateQuery = "UPDATE users SET correo = @correo, pass = @newpass WHERE user = @username";
				MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
				updateCmd.Parameters.AddWithValue("@correo", correo);
				updateCmd.Parameters.AddWithValue("@newpass", newPassword);
				updateCmd.Parameters.AddWithValue("@username", username);

				int rowsAffected = updateCmd.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					MessageBox.Show("Datos actualizados correctamente.");
				}
				else
				{
					MessageBox.Show("No se pudo actualizar la información.");
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error de base de datos: " + ex.Message);
			}
			finally
			{
				con.Close();
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

        private void txteuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
