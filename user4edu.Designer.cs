namespace BOOST
{
	partial class user4edu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user4edu));
            this.label9 = new System.Windows.Forms.Label();
            this.edu4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edu4)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(71)))));
            this.label9.Location = new System.Drawing.Point(176, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Prof. Carlos Méndez";
            // 
            // edu4
            // 
            this.edu4.Image = ((System.Drawing.Image)(resources.GetObject("edu4.Image")));
            this.edu4.Location = new System.Drawing.Point(162, 23);
            this.edu4.Margin = new System.Windows.Forms.Padding(2);
            this.edu4.Name = "edu4";
            this.edu4.Size = new System.Drawing.Size(194, 177);
            this.edu4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.edu4.TabIndex = 2;
            this.edu4.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 66);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tutor en lengua y literatura con experiencia en preparación para pruebas Saber.\r\n" +
    "________________________________________________________________________________" +
    "____";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 211);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user4edu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.edu4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "user4edu";
            this.Text = "user4edu";
            this.Load += new System.EventHandler(this.user4edu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edu4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox edu4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}