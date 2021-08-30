using System;
using System.Windows.Forms;

namespace KullaniciAidat
{
	public class ExceptionAttribute : Attribute
	{
		public void Message(string msj)
		{
			msj = "Kullanıcı hatalıdır";
			MessageBox.Show(msj);
		}
	}
}