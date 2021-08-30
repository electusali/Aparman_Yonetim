namespace KullaniciGiris
{
	partial class Form1
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
			this.lblYonetimKullanici = new System.Windows.Forms.Label();
			this.gbxYonetim = new System.Windows.Forms.GroupBox();
			this.lblYonetimSifre = new System.Windows.Forms.Label();
			this.btnGirisYonetim = new System.Windows.Forms.Button();
			this.tbxKullaniciYonetim = new System.Windows.Forms.TextBox();
			this.tbxSifreYonetim = new System.Windows.Forms.TextBox();
			this.gbxYonetim.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblYonetimKullanici
			// 
			this.lblYonetimKullanici.AutoSize = true;
			this.lblYonetimKullanici.Location = new System.Drawing.Point(6, 82);
			this.lblYonetimKullanici.Name = "lblYonetimKullanici";
			this.lblYonetimKullanici.Size = new System.Drawing.Size(64, 13);
			this.lblYonetimKullanici.TabIndex = 0;
			this.lblYonetimKullanici.Text = "Kullanici Adi";
			// 
			// gbxYonetim
			// 
			this.gbxYonetim.Controls.Add(this.lblYonetimSifre);
			this.gbxYonetim.Controls.Add(this.btnGirisYonetim);
			this.gbxYonetim.Controls.Add(this.tbxKullaniciYonetim);
			this.gbxYonetim.Controls.Add(this.lblYonetimKullanici);
			this.gbxYonetim.Controls.Add(this.tbxSifreYonetim);
			this.gbxYonetim.Location = new System.Drawing.Point(193, 67);
			this.gbxYonetim.Name = "gbxYonetim";
			this.gbxYonetim.Size = new System.Drawing.Size(284, 270);
			this.gbxYonetim.TabIndex = 1;
			this.gbxYonetim.TabStop = false;
			this.gbxYonetim.Text = "Yönetim Kullanici Giriş";
			// 
			// lblYonetimSifre
			// 
			this.lblYonetimSifre.AutoSize = true;
			this.lblYonetimSifre.Location = new System.Drawing.Point(25, 136);
			this.lblYonetimSifre.Name = "lblYonetimSifre";
			this.lblYonetimSifre.Size = new System.Drawing.Size(28, 13);
			this.lblYonetimSifre.TabIndex = 5;
			this.lblYonetimSifre.Text = "Sifre";
			// 
			// btnGirisYonetim
			// 
			this.btnGirisYonetim.Location = new System.Drawing.Point(116, 182);
			this.btnGirisYonetim.Name = "btnGirisYonetim";
			this.btnGirisYonetim.Size = new System.Drawing.Size(109, 33);
			this.btnGirisYonetim.TabIndex = 3;
			this.btnGirisYonetim.Text = "Giriş";
			this.btnGirisYonetim.UseVisualStyleBackColor = true;
			this.btnGirisYonetim.Click += new System.EventHandler(this.btnGirisYonetim_Click);
			// 
			// tbxKullaniciYonetim
			// 
			this.tbxKullaniciYonetim.Location = new System.Drawing.Point(102, 79);
			this.tbxKullaniciYonetim.Name = "tbxKullaniciYonetim";
			this.tbxKullaniciYonetim.Size = new System.Drawing.Size(147, 20);
			this.tbxKullaniciYonetim.TabIndex = 4;
			// 
			// tbxSifreYonetim
			// 
			this.tbxSifreYonetim.Location = new System.Drawing.Point(102, 129);
			this.tbxSifreYonetim.Name = "tbxSifreYonetim";
			this.tbxSifreYonetim.Size = new System.Drawing.Size(147, 20);
			this.tbxSifreYonetim.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gbxYonetim);
			this.Name = "Form1";
			this.Text = "Form1";
			this.gbxYonetim.ResumeLayout(false);
			this.gbxYonetim.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblYonetimKullanici;
		private System.Windows.Forms.GroupBox gbxYonetim;
		private System.Windows.Forms.Label lblYonetimSifre;
		private System.Windows.Forms.Button btnGirisYonetim;
		private System.Windows.Forms.TextBox tbxKullaniciYonetim;
		private System.Windows.Forms.TextBox tbxSifreYonetim;
	}
}

