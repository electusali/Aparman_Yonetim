namespace KullaniciEkle
{
	partial class KayitListeleme
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
			this.gbxAdd = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tbxSifreAdd = new System.Windows.Forms.TextBox();
			this.tbxKullaniciAdd = new System.Windows.Forms.TextBox();
			this.lblSifreAdd = new System.Windows.Forms.Label();
			this.lblKullaniciAdd = new System.Windows.Forms.Label();
			this.listKayit = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gbxKullaniciListe = new System.Windows.Forms.GroupBox();
			this.rdbYonetim = new System.Windows.Forms.RadioButton();
			this.btnListele = new System.Windows.Forms.Button();
			this.gbxDelete = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.gbxUpdate = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tbxSifreUpdate = new System.Windows.Forms.TextBox();
			this.tbxUpdate = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgwYonetim = new System.Windows.Forms.DataGridView();
			this.gbxAdd.SuspendLayout();
			this.gbxKullaniciListe.SuspendLayout();
			this.gbxDelete.SuspendLayout();
			this.gbxUpdate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwYonetim)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxAdd
			// 
			this.gbxAdd.Controls.Add(this.btnAdd);
			this.gbxAdd.Controls.Add(this.tbxSifreAdd);
			this.gbxAdd.Controls.Add(this.tbxKullaniciAdd);
			this.gbxAdd.Controls.Add(this.lblSifreAdd);
			this.gbxAdd.Controls.Add(this.lblKullaniciAdd);
			this.gbxAdd.Location = new System.Drawing.Point(61, 47);
			this.gbxAdd.Name = "gbxAdd";
			this.gbxAdd.Size = new System.Drawing.Size(229, 223);
			this.gbxAdd.TabIndex = 0;
			this.gbxAdd.TabStop = false;
			this.gbxAdd.Text = "Kullanıcı Ekle";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(93, 154);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(92, 30);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "EKLE";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// tbxSifreAdd
			// 
			this.tbxSifreAdd.Location = new System.Drawing.Point(93, 110);
			this.tbxSifreAdd.Name = "tbxSifreAdd";
			this.tbxSifreAdd.Size = new System.Drawing.Size(100, 20);
			this.tbxSifreAdd.TabIndex = 4;
			// 
			// tbxKullaniciAdd
			// 
			this.tbxKullaniciAdd.Location = new System.Drawing.Point(93, 55);
			this.tbxKullaniciAdd.Name = "tbxKullaniciAdd";
			this.tbxKullaniciAdd.Size = new System.Drawing.Size(100, 20);
			this.tbxKullaniciAdd.TabIndex = 2;
			// 
			// lblSifreAdd
			// 
			this.lblSifreAdd.AutoSize = true;
			this.lblSifreAdd.Location = new System.Drawing.Point(17, 110);
			this.lblSifreAdd.Name = "lblSifreAdd";
			this.lblSifreAdd.Size = new System.Drawing.Size(70, 13);
			this.lblSifreAdd.TabIndex = 4;
			this.lblSifreAdd.Text = "Kullanici Sifre";
			// 
			// lblKullaniciAdd
			// 
			this.lblKullaniciAdd.AutoSize = true;
			this.lblKullaniciAdd.Location = new System.Drawing.Point(17, 58);
			this.lblKullaniciAdd.Name = "lblKullaniciAdd";
			this.lblKullaniciAdd.Size = new System.Drawing.Size(64, 13);
			this.lblKullaniciAdd.TabIndex = 1;
			this.lblKullaniciAdd.Text = "Kullanici Adi";
			// 
			// listKayit
			// 
			this.listKayit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listKayit.FullRowSelect = true;
			this.listKayit.GridLines = true;
			this.listKayit.HideSelection = false;
			this.listKayit.Location = new System.Drawing.Point(217, 32);
			this.listKayit.Name = "listKayit";
			this.listKayit.Size = new System.Drawing.Size(261, 170);
			this.listKayit.TabIndex = 1;
			this.listKayit.UseCompatibleStateImageBehavior = false;
			this.listKayit.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Id";
			this.columnHeader4.Width = 77;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Kullanici Adi";
			this.columnHeader5.Width = 86;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "KUllanici Sifre";
			this.columnHeader6.Width = 105;
			// 
			// gbxKullaniciListe
			// 
			this.gbxKullaniciListe.Controls.Add(this.rdbYonetim);
			this.gbxKullaniciListe.Controls.Add(this.btnListele);
			this.gbxKullaniciListe.Controls.Add(this.listKayit);
			this.gbxKullaniciListe.Location = new System.Drawing.Point(344, 47);
			this.gbxKullaniciListe.Name = "gbxKullaniciListe";
			this.gbxKullaniciListe.Size = new System.Drawing.Size(484, 223);
			this.gbxKullaniciListe.TabIndex = 2;
			this.gbxKullaniciListe.TabStop = false;
			this.gbxKullaniciListe.Text = "Kullanıcı Listesi";
			// 
			// rdbYonetim
			// 
			this.rdbYonetim.AutoSize = true;
			this.rdbYonetim.Location = new System.Drawing.Point(65, 74);
			this.rdbYonetim.Name = "rdbYonetim";
			this.rdbYonetim.Size = new System.Drawing.Size(63, 17);
			this.rdbYonetim.TabIndex = 3;
			this.rdbYonetim.TabStop = true;
			this.rdbYonetim.Text = "Yönetim";
			this.rdbYonetim.UseVisualStyleBackColor = true;
			this.rdbYonetim.CheckedChanged += new System.EventHandler(this.rdbYonetim_CheckedChanged);
			// 
			// btnListele
			// 
			this.btnListele.Location = new System.Drawing.Point(48, 126);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(89, 33);
			this.btnListele.TabIndex = 2;
			this.btnListele.Text = "Kayıt Listele";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// gbxDelete
			// 
			this.gbxDelete.Controls.Add(this.btnDelete);
			this.gbxDelete.Location = new System.Drawing.Point(758, 298);
			this.gbxDelete.Name = "gbxDelete";
			this.gbxDelete.Size = new System.Drawing.Size(154, 168);
			this.gbxDelete.TabIndex = 5;
			this.gbxDelete.TabStop = false;
			this.gbxDelete.Text = "Kullanıcı Silme";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(30, 74);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(92, 30);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "SİLME";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// gbxUpdate
			// 
			this.gbxUpdate.Controls.Add(this.btnUpdate);
			this.gbxUpdate.Controls.Add(this.tbxSifreUpdate);
			this.gbxUpdate.Controls.Add(this.tbxUpdate);
			this.gbxUpdate.Controls.Add(this.label1);
			this.gbxUpdate.Controls.Add(this.label2);
			this.gbxUpdate.Location = new System.Drawing.Point(61, 282);
			this.gbxUpdate.Name = "gbxUpdate";
			this.gbxUpdate.Size = new System.Drawing.Size(229, 223);
			this.gbxUpdate.TabIndex = 5;
			this.gbxUpdate.TabStop = false;
			this.gbxUpdate.Text = "Kullanıcı Güncelleme";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(93, 154);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(92, 30);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "GÜNCELLEME";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbxSifreUpdate
			// 
			this.tbxSifreUpdate.Location = new System.Drawing.Point(93, 110);
			this.tbxSifreUpdate.Name = "tbxSifreUpdate";
			this.tbxSifreUpdate.Size = new System.Drawing.Size(100, 20);
			this.tbxSifreUpdate.TabIndex = 4;
			// 
			// tbxUpdate
			// 
			this.tbxUpdate.Location = new System.Drawing.Point(93, 55);
			this.tbxUpdate.Name = "tbxUpdate";
			this.tbxUpdate.Size = new System.Drawing.Size(100, 20);
			this.tbxUpdate.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Kullanici Sifre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kullanici Adi";
			// 
			// dgwYonetim
			// 
			this.dgwYonetim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwYonetim.Location = new System.Drawing.Point(361, 322);
			this.dgwYonetim.Name = "dgwYonetim";
			this.dgwYonetim.Size = new System.Drawing.Size(337, 127);
			this.dgwYonetim.TabIndex = 6;
			this.dgwYonetim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwYonetim_CellClick);
			// 
			// KayitListeleme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 517);
			this.Controls.Add(this.dgwYonetim);
			this.Controls.Add(this.gbxUpdate);
			this.Controls.Add(this.gbxDelete);
			this.Controls.Add(this.gbxKullaniciListe);
			this.Controls.Add(this.gbxAdd);
			this.Name = "KayitListeleme";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbxAdd.ResumeLayout(false);
			this.gbxAdd.PerformLayout();
			this.gbxKullaniciListe.ResumeLayout(false);
			this.gbxKullaniciListe.PerformLayout();
			this.gbxDelete.ResumeLayout(false);
			this.gbxUpdate.ResumeLayout(false);
			this.gbxUpdate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwYonetim)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxAdd;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox tbxSifreAdd;
		private System.Windows.Forms.TextBox tbxKullaniciAdd;
		private System.Windows.Forms.Label lblSifreAdd;
		private System.Windows.Forms.Label lblKullaniciAdd;
		private System.Windows.Forms.ListView listKayit;
		private System.Windows.Forms.GroupBox gbxKullaniciListe;
		private System.Windows.Forms.RadioButton rdbYonetim;
		private System.Windows.Forms.Button btnListele;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.GroupBox gbxDelete;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.GroupBox gbxUpdate;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox tbxSifreUpdate;
		private System.Windows.Forms.TextBox tbxUpdate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgwYonetim;
	}
}

