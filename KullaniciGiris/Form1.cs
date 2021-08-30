using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using AnaSayfa;

namespace KullaniciGiris
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-U2RCCIRO;Initial Catalog=ApartmanYonetici;Integrated Security=True");
		private void btnGirisYonetim_Click(object sender, EventArgs e)
		{
			try
			{

				if (baglan.State == ConnectionState.Closed)
				{
					baglan.Open();
				}
				string sql = "Select * From Yonetim where KullaniciAdi=@kadi AND KullaniciSifre=@Sifre ";
				SqlParameter parameter1 = new SqlParameter("kadi", tbxKullaniciYonetim.Text);
				SqlParameter parameter2 = new SqlParameter("Sifre", tbxSifreYonetim.Text);
				SqlCommand komut = new SqlCommand(sql, baglan);
				komut.Parameters.Add(parameter1);
				komut.Parameters.Add(parameter2);

				DataTable data = new DataTable();
				SqlDataAdapter sqlData = new SqlDataAdapter(komut);
				sqlData.Fill(data);

				if (data.Rows.Count > 0)
				{
					Sayfa2 yeni = new Sayfa2();
					yeni.Show();
					this.Hide();

				}
				else
				{
					MessageBox.Show("Kullanıci Hata");
				}
			}
			catch (Exception exception)
			{

				MessageBox.Show(exception.Message);
			}
			
		}

		}	
	}
