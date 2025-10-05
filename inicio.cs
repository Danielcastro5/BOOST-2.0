using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOST
{
	public partial class inicio : Form
	{
		public inicio()
		{
			InitializeComponent();
			customizeDesing();
		}
		private void customizeDesing()
		{
			panelsubmenu.Visible = false;
			panelusersubmenu.Visible = false;
		}
		private void hideSubMenu()
		{
			if (panelsubmenu.Visible == true)
				panelsubmenu.Visible = false;
			if (panelusersubmenu.Visible == true)
				panelusersubmenu.Visible = false;
		}
		private void showSubMenu(Panel subMenu) 
		{
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;
	    }

		private void btnservicios_Click(object sender, EventArgs e)
		{
			showSubMenu(panelsubmenu);
		}

		private void btnpsicologia_Click(object sender, EventArgs e)
		{
			openChildForm(new psicologia());
			hideSubMenu();
		}

		private void btnfinanzas_Click(object sender, EventArgs e)
		{
			openChildForm(new finanzas());
			hideSubMenu();
		}

		private void btneducativo_Click(object sender, EventArgs e)
		{
			openChildForm(new educativo());
			hideSubMenu();
		}

		private void btnlaboral_Click(object sender, EventArgs e)
		{
			openChildForm(new laboral());
			hideSubMenu();
		}

		private void btnuser_Click(object sender, EventArgs e)
		{
			showSubMenu(panelusersubmenu);
		}

		private void btneditar_Click(object sender, EventArgs e)
		{
			openChildForm(new editaruser());
			hideSubMenu();
		}

		private void btncerrar_Click(object sender, EventArgs e)
		{
			Form Form1 = new Form1();
			Form1.Show();

			this.Hide();
		}
		private Form activeForm = null;
		private void openChildForm(Form childForm)
		{
			if(activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			openChildForm(new imginicio());
		}
	}
}
