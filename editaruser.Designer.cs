namespace BOOST
{
	partial class editaruser
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editaruser));
			this.txtepass = new System.Windows.Forms.TextBox();
			this.txtapass = new System.Windows.Forms.TextBox();
			this.txteuser = new System.Windows.Forms.TextBox();
			this.txtecorreo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnguardar = new FontAwesome.Sharp.IconButton();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtepass
			// 
			this.txtepass.BackColor = System.Drawing.Color.White;
			this.txtepass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtepass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtepass.ForeColor = System.Drawing.Color.Black;
			this.txtepass.Location = new System.Drawing.Point(238, 668);
			this.txtepass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtepass.Name = "txtepass";
			this.txtepass.Size = new System.Drawing.Size(526, 32);
			this.txtepass.TabIndex = 56;
			this.txtepass.Text = "NUEVA CONTRASEÑA";
			this.txtepass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtepass.Enter += new System.EventHandler(this.txtepass_Enter);
			this.txtepass.Leave += new System.EventHandler(this.txtepass_Leave);
			// 
			// txtapass
			// 
			this.txtapass.BackColor = System.Drawing.Color.White;
			this.txtapass.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtapass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtapass.ForeColor = System.Drawing.Color.Black;
			this.txtapass.Location = new System.Drawing.Point(238, 562);
			this.txtapass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtapass.Name = "txtapass";
			this.txtapass.Size = new System.Drawing.Size(526, 32);
			this.txtapass.TabIndex = 52;
			this.txtapass.Text = "CONTRASEÑA ACTUAL";
			this.txtapass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtapass.Enter += new System.EventHandler(this.txtapass_Enter);
			this.txtapass.Leave += new System.EventHandler(this.txtapass_Leave);
			// 
			// txteuser
			// 
			this.txteuser.BackColor = System.Drawing.Color.White;
			this.txteuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txteuser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txteuser.ForeColor = System.Drawing.Color.Black;
			this.txteuser.Location = new System.Drawing.Point(238, 332);
			this.txteuser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txteuser.Name = "txteuser";
			this.txteuser.Size = new System.Drawing.Size(526, 32);
			this.txteuser.TabIndex = 51;
			this.txteuser.Text = "USUARIO";
			this.txteuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txteuser.Enter += new System.EventHandler(this.txteuser_Enter);
			this.txteuser.Leave += new System.EventHandler(this.txteuser_Leave);
			// 
			// txtecorreo
			// 
			this.txtecorreo.BackColor = System.Drawing.Color.White;
			this.txtecorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtecorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtecorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtecorreo.ForeColor = System.Drawing.Color.Black;
			this.txtecorreo.Location = new System.Drawing.Point(237, 451);
			this.txtecorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtecorreo.Name = "txtecorreo";
			this.txtecorreo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtecorreo.Size = new System.Drawing.Size(526, 32);
			this.txtecorreo.TabIndex = 50;
			this.txtecorreo.Text = "CORREO";
			this.txtecorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtecorreo.Enter += new System.EventHandler(this.txtecorreo_Enter);
			this.txtecorreo.Leave += new System.EventHandler(this.txtecorreo_Leave);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(232, 694);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(531, 20);
			this.label6.TabIndex = 57;
			this.label6.Text = "__________________________________________________________";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(232, 588);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(531, 20);
			this.label5.TabIndex = 55;
			this.label5.Text = "__________________________________________________________";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(232, 366);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(531, 20);
			this.label4.TabIndex = 54;
			this.label4.Text = "__________________________________________________________";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(231, 483);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(531, 20);
			this.label3.TabIndex = 53;
			this.label3.Text = "__________________________________________________________";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(356, 131);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 48);
			this.label2.TabIndex = 58;
			this.label2.Text = "Editar Perfil";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(300, 131);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 49);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 59;
			this.pictureBox1.TabStop = false;
			// 
			// btnguardar
			// 
			this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(71)))));
			this.btnguardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnguardar.ForeColor = System.Drawing.Color.White;
			this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
			this.btnguardar.IconColor = System.Drawing.Color.White;
			this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnguardar.IconSize = 45;
			this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnguardar.Location = new System.Drawing.Point(268, 852);
			this.btnguardar.Name = "btnguardar";
			this.btnguardar.Size = new System.Drawing.Size(482, 109);
			this.btnguardar.TabIndex = 60;
			this.btnguardar.Text = "Guardar Cambios";
			this.btnguardar.UseVisualStyleBackColor = false;
			this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnguardar);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtepass);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtapass);
			this.panel1.Controls.Add(this.txtecorreo);
			this.panel1.Controls.Add(this.txteuser);
			this.panel1.Location = new System.Drawing.Point(772, 95);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(974, 1105);
			this.panel1.TabIndex = 61;
			// 
			// editaruser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.ClientSize = new System.Drawing.Size(1946, 1106);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "editaruser";
			this.Text = "editaruser";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtepass;
		private System.Windows.Forms.TextBox txtapass;
		private System.Windows.Forms.TextBox txteuser;
		private System.Windows.Forms.TextBox txtecorreo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private FontAwesome.Sharp.IconButton btnguardar;
		private System.Windows.Forms.Panel panel1;
	}
}