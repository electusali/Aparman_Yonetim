
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciEkle
{
	public partial class KayitListeleme : Form
	{
		Ekleme _ekleme = new Ekleme();
		public KayitListeleme()
		{
			InitializeComponent();
			listKayit.View = View.Details;
			listKayit.FullRowSelect = true;
		}

		

		SqlConnection baglanti2 = new SqlConnection("Data Source=LAPTOP-U2RCCIRO;Initial Catalog=ApartmanYonetici;Integrated Security=True");

		private void VerileriGoster()
		{
		
			listKayit.Items.Clear();
			if (baglanti2.State == ConnectionState.Closed)
			{
				baglanti2.Open();
			}
			SqlCommand command = new SqlCommand("Select * From Yonetim", baglanti2);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				ListViewItem ekle = new ListViewItem();
				ekle.Text = reader["Id"].ToString();
				ekle.SubItems.Add(reader["KullaniciAdi"].ToString());
				ekle.SubItems.Add(reader["KullaniciSifre"].ToString());
				listKayit.Items.Add(ekle);
			}
			baglanti2.Close();
		}

		private void btnListele_Click(object sender, EventArgs e)
		{
			VerileriGoster();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Yukle();
		}

		private void rdbYonetim_CheckedChanged(object sender, EventArgs e)
		{
			if (!rdbYonetim.Checked)
			{
				listKayit.Items.Clear();
				VerileriGoster();
			}
		}
	
		private void btnAdd_Click(object sender, EventArgs e)
		{
			_ekleme.Add(new Yonetim
			{
				KullaniciAdi = tbxKullaniciAdd.Text,
				KullaniciSifre = tbxSifreAdd.Text
			});
			Yukle();
			MessageBox.Show("Eklendi");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(dgwYonetim.CurrentRow.Cells[0].Value);
			_ekleme.Delete(id);
			Yukle();
			MessageBox.Show("Ürün Silinmiştir");
		}
		
		public void Yukle()
		{
			dgwYonetim.DataSource = _ekleme.GetAll();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			_ekleme.Update(new Yonetim
			{
				Id = Convert.ToInt32(dgwYonetim.CurrentRow.Cells[0].Value),
				KullaniciAdi = tbxUpdate.Text,
				KullaniciSifre = tbxSifreUpdate.Text

			});	
			MessageBox.Show("Ürün Güncellenmiştir");
			Yukle();

		}

		private void dgwYonetim_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var yon = dgwYonetim.CurrentRow;
			tbxUpdate.Text = yon.Cells[1].Value.ToString();
			tbxSifreUpdate.Text = yon.Cells[2].Value.ToString();

		}
	}
}
