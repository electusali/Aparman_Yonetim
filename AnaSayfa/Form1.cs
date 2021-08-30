using KullaniciAidat;
using KullaniciEkle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaSayfa
{
	public partial class Sayfa2 : Form
	{
		public Sayfa2()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void btnEkleme_Click(object sender, EventArgs e)
		{
			KayitListeleme listeleme = new KayitListeleme();
			listeleme.Show();
			this.Hide();
		}

		private void btnAidat_Click(object sender, EventArgs e)
		{
			DaireKisiEkle ekle = new DaireKisiEkle();
			ekle.Show();
			this.Hide();
		}
	}
}
