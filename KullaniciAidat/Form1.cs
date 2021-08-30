using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciAidat
{
	public partial class DaireKisiEkle : Form
	{
		public DaireKisiEkle()
		{
			InitializeComponent();
		}
		DaireEkle _daireEkle = new DaireEkle();
		private void btnAddDaire_Click(object sender, EventArgs e)
		{
			_daireEkle.DaireKiraAdd(new DaireAidat
			{
				DaireAd=tbxKadiDaire.Text,
				DaireSoyad=tbxDaireSifre.Text,
				DaireKira=Convert.ToDecimal(tbxDaireKira.Text)
			});
			Yukle();
			MessageBox.Show("Daire Aidat Eklenmiştir");
		}
		public void Yukle()
		{
			dgwDaireAidat.DataSource = _daireEkle.GetAll2();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			Yukle();
		}

		private void btnOdeme_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(dgwDaireAidat.CurrentRow.Cells[0].Value);
			_daireEkle.DaireKiraDelete(id);
			Yukle();
			MessageBox.Show("Kira Ödenmiştir");

		}
	}
}
