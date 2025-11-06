namespace BOOST
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.muestra = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnregistrarse = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(533, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 26);
            this.button1.TabIndex = 47;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // muestra
            // 
            this.muestra.AutoSize = true;
            this.muestra.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestra.ForeColor = System.Drawing.Color.Black;
            this.muestra.Location = new System.Drawing.Point(391, 233);
            this.muestra.Name = "muestra";
            this.muestra.Size = new System.Drawing.Size(75, 21);
            this.muestra.TabIndex = 46;
            this.muestra.Text = "Mostrar";
            this.muestra.UseVisualStyleBackColor = true;
            this.muestra.CheckedChanged += new System.EventHandler(this.muestra_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(224, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "¿No tienes una cuenta?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(104, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "___________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(104, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "___________________________________________________________";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.Location = new System.Drawing.Point(108, 186);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(356, 19);
            this.txtpass.TabIndex = 42;
            this.txtpass.Text = "CONTRASEÑA";
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Location = new System.Drawing.Point(107, 130);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(356, 19);
            this.txtuser.TabIndex = 41;
            this.txtuser.Text = "USUARIO";
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(180, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 40);
            this.label2.TabIndex = 39;
            this.label2.Text = "Iniciar Sesiòn";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.White;
            this.lblErrorMessage.Location = new System.Drawing.Point(105, 239);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(10, 13);
            this.lblErrorMessage.TabIndex = 40;
            this.lblErrorMessage.Text = ".";
            // 
            // btnregistrarse
            // 
            this.btnregistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(71)))));
            this.btnregistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrarse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarse.ForeColor = System.Drawing.Color.White;
            this.btnregistrarse.Location = new System.Drawing.Point(107, 360);
            this.btnregistrarse.Name = "btnregistrarse";
            this.btnregistrarse.Size = new System.Drawing.Size(356, 48);
            this.btnregistrarse.TabIndex = 38;
            this.btnregistrarse.Text = "REGISTRARSE";
            this.btnregistrarse.UseVisualStyleBackColor = false;
            this.btnregistrarse.Click += new System.EventHandler(this.btnregistrarse_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(71)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(107, 275);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(356, 48);
            this.btnlogin.TabIndex = 37;
            this.btnlogin.Text = "ACCEDER";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 26);
            this.panel1.TabIndex = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(563, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.muestra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnregistrarse);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox muestra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblErrorMessage;
		private System.Windows.Forms.Button btnregistrarse;
		private System.Windows.Forms.Button btnlogin;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}

