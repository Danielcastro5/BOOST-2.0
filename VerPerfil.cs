using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOST
{
	public partial class VerPerfil : UserControl
	{
		private string username;
			public VerPerfil(string usuario)
			{
				InitializeComponent();
				username = usuario;
				CargarPerfil();
			}

			private void CargarPerfil()
			{
				MySqlConnection con = new MySqlConnection("server=127.0.0.1;Database=logins;User Id=root;password=...");
				con.Open();
				string query = "SELECT user, descripcion, foto FROM users WHERE user = @username";
				MySqlCommand cmd = new MySqlCommand(query, con);
				cmd.Parameters.AddWithValue("@username", username);
				MySqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					lblNombre.Text = reader.GetString("user");
					txtDescripcion.Text = reader.IsDBNull(1) ? "Sin descripción" : reader.GetString("descripcion");
					if (!reader.IsDBNull(2))
					{
						byte[] fotoBytes = (byte[])reader["foto"];
						pictureBoxFoto.Image = ByteArrayToImage(fotoBytes);
					}
				}

				con.Close();
			}

			private Image ByteArrayToImage(byte[] bytes)
			{
				using (MemoryStream ms = new MemoryStream(bytes))
				{
					return Image.FromStream(ms);
				}
			}
		}
	}

