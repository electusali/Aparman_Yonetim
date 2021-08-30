namespace AnaSayfa
{
	partial class Sayfa2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sayfa2));
			this.btnEkleme = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAidat = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEkleme
			// 
			this.btnEkleme.Image = global::AnaSayfa.Properties.Resources.KullaniciEkle;
			this.btnEkleme.Location = new System.Drawing.Point(3, 0);
			this.btnEkleme.Name = "btnEkleme";
			this.btnEkleme.Size = new System.Drawing.Size(87, 83);
			this.btnEkleme.TabIndex = 1;
			this.btnEkleme.Text = "Kullanıcı Ekle";
			this.btnEkleme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEkleme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEkleme.UseVisualStyleBackColor = true;
			this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnAidat);
			this.panel1.Controls.Add(this.btnEkleme);
			this.panel1.Location = new System.Drawing.Point(-1, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(804, 85);
			this.panel1.TabIndex = 0;
			// 
			// btnAidat
			// 
			this.btnAidat.Image = ((System.Drawing.Image)(resources.GetObject("btnAidat.Image")));
			this.btnAidat.Location = new System.Drawing.Point(88, 0);
			this.btnAidat.Name = "btnAidat";
			this.btnAidat.Size = new System.Drawing.Size(80, 85);
			this.btnAidat.TabIndex = 1;
			this.btnAidat.Text = "Aidat";
			this.btnAidat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAidat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnAidat.UseVisualStyleBackColor = true;
			this.btnAidat.Click += new System.EventHandler(this.btnAidat_Click);
			// 
			// Sayfa2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "Sayfa2";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnEkleme;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAidat;
	}
}

