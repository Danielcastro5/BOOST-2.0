namespace BOOST
{
    partial class user2psic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user2psic));
            this.ptbandres = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbandres)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbandres
            // 
            this.ptbandres.Image = ((System.Drawing.Image)(resources.GetObject("ptbandres.Image")));
            this.ptbandres.Location = new System.Drawing.Point(240, 11);
            this.ptbandres.Margin = new System.Windows.Forms.Padding(2);
            this.ptbandres.Name = "ptbandres";
            this.ptbandres.Size = new System.Drawing.Size(194, 177);
            this.ptbandres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbandres.TabIndex = 5;
            this.ptbandres.TabStop = false;
            this.ptbandres.Click += new System.EventHandler(this.ptbandres_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 175);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(71)))));
            this.label2.Location = new System.Drawing.Point(257, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lic. Andres Ruiz";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "    Terapeuta Familiar y de pareja con enfoque sistemático\r\n_____________________" +
    "_____________________________________________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // user2psic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbandres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user2psic";
            this.Text = "user2psic";
            this.Load += new System.EventHandler(this.user2psic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbandres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbandres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}