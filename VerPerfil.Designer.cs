namespace BOOST
{
	partial class VerPerfil
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

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPerfil));
			this.txtDescripcion = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
			this.SuspendLayout();
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcion.Location = new System.Drawing.Point(43, 409);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(414, 129);
			this.txtDescripcion.TabIndex = 8;
			this.txtDescripcion.Text = "Psicóloga clínica especializada en ansiedad y terapia cognitiva.";
			this.txtDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(71)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(160, 558);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(186, 62);
			this.button1.TabIndex = 7;
			this.button1.Text = "Ver Perfil";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(71)))));
			this.lblNombre.Location = new System.Drawing.Point(112, 364);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(180, 28);
			this.lblNombre.TabIndex = 6;
			this.lblNombre.Text = "Dra. Laura Gómez";
			// 
			// pictureBoxFoto
			// 
			this.pictureBoxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.Image")));
			this.pictureBoxFoto.Location = new System.Drawing.Point(92, 39);
			this.pictureBoxFoto.Name = "pictureBoxFoto";
			this.pictureBoxFoto.Size = new System.Drawing.Size(309, 272);
			this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxFoto.TabIndex = 5;
			this.pictureBoxFoto.TabStop = false;
			// 
			// VerPerfil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.pictureBoxFoto);
			this.Name = "VerPerfil";
			this.Size = new System.Drawing.Size(503, 670);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label txtDescripcion;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.PictureBox pictureBoxFoto;
	}
}
