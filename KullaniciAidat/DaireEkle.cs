using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace KullaniciAidat
{
	public class DaireEkle
	{
		SqlConnection _bag = new SqlConnection(@"Data Source=LAPTOP-U2RCCIRO;Initial Catalog=ApartmanYonetici;Integrated Security=True");
		private object mbox;

		public List<DaireAidat> GetAll2()
		{
			Kontrol();
			SqlCommand sql = new SqlCommand("Select * From DaireAidat  ", _bag);
			SqlDataReader sqlData = sql.ExecuteReader();

			List<DaireAidat> daires = new List<DaireAidat>();

			while (sqlData.Read())
			{
				DaireAidat daire = new DaireAidat
				{
					Id = Convert.ToInt32(sqlData["Id"]),
					DaireAd = sqlData["DaireAd"].ToString(),
					DaireSoyad = sqlData["DaireSoyad"].ToString(),
					DaireKira = Convert.ToDecimal(sqlData["DaireKira"])
				};
				daires.Add(daire);
			}
			sqlData.Close();
			_bag.Close();
			return daires;
		}
		public void Kontrol()
		{
			if (_bag.State == ConnectionState.Closed)
			{
				_bag.Open();
			}
		}
		public void DaireKiraAdd(DaireAidat daireAidat)
		{
			Kontrol();
			SqlCommand sqlCommand = new SqlCommand("Insert into DaireAidat values(@DaireAd, @DaireSoyad,@DaireKira)", _bag);
			sqlCommand.Parameters.AddWithValue("@DaireAd", daireAidat.DaireAd);
			sqlCommand.Parameters.AddWithValue("@DaireSoyad", daireAidat.DaireSoyad);
			sqlCommand.Parameters.AddWithValue("@DaireKira", daireAidat.DaireKira);
			sqlCommand.ExecuteNonQuery();
			_bag.Close();
		}
		[Exception]
		public void DaireKiraDelete(int id)
		{
			Kontrol();
			SqlCommand command = new SqlCommand("Delete From DaireAidat where Id=@id");
			command.Parameters.AddWithValue("@id", id);
			command.ExecuteNonQuery();
			_bag.Close();

		}
	}
	
}
