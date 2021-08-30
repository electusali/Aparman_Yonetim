using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace KullaniciEkle
{

	public class Ekleme
	{
		SqlConnection baglantigiris = new SqlConnection(@"Data Source=LAPTOP-U2RCCIRO;Initial Catalog=ApartmanYonetici;Integrated Security=True");
		public List<Yonetim> GetAll()
		{
			KontrolNoktasi();
			SqlCommand komutlar = new SqlCommand("Select *From Yonetim",baglantigiris);
			SqlDataReader sqlDataReader = komutlar.ExecuteReader();

			List<Yonetim> yonetims = new List<Yonetim>();

			while (sqlDataReader.Read())
			{
				Yonetim yonetim = new Yonetim
				{
					Id = Convert.ToInt32(sqlDataReader["Id"]),
					KullaniciAdi = sqlDataReader["KullaniciAdi"].ToString(),
					KullaniciSifre = sqlDataReader["KullaniciSifre"].ToString()
				};

				yonetims.Add(yonetim);
			}
			sqlDataReader.Close();
			baglantigiris.Close();
			return yonetims;
		}
		public void KontrolNoktasi()
		{
			if (baglantigiris.State==ConnectionState.Closed)
			{
				baglantigiris.Open();
			}
		}
		public void Add(Yonetim yonetim)
		{
			KontrolNoktasi();
			SqlCommand command5 = new SqlCommand("Insert into Yonetim values(@KullaniciAdi , @KullaniciSifre)", baglantigiris);
			command5.Parameters.AddWithValue("@KullaniciAdi", yonetim.KullaniciAdi);
			command5.Parameters.AddWithValue("@KullaniciSifre", yonetim.KullaniciSifre);
			command5.ExecuteNonQuery();
			baglantigiris.Close();
		}
		public void Update(Yonetim yonetim)
		{
			KontrolNoktasi();
			SqlCommand command5 = new SqlCommand("Update Yonetim set KullaniciAdi=@KullaniciAdi , KullaniciSifre=@KullaniciSifre where Id=@id", baglantigiris);
			command5.Parameters.AddWithValue("@KullaniciAdi", yonetim.KullaniciAdi);
			command5.Parameters.AddWithValue("@KullaniciSifre", yonetim.KullaniciSifre);
			command5.Parameters.AddWithValue("@id", yonetim.Id);
			command5.ExecuteNonQuery();
			baglantigiris.Close();
		}

		public void Delete(int id)
		{
			KontrolNoktasi();
			SqlCommand command5 = new SqlCommand("Delete From Yonetim where Id=@id ", baglantigiris);
			command5.Parameters.AddWithValue("@id", id);
			command5.ExecuteNonQuery();
			baglantigiris.Close();
		}
	}
}
