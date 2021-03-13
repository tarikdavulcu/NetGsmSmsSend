using System;
using System.IO;
using System.Net;

namespace sms
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            try
            {
				string html = string.Empty;
				string mes = "Mesajınız";
				string url = @"https://api.netgsm.com.tr/sms/send/get/?usercode=TelNonuzuYaziniz&password=ŞifreniziYaziniz&gsmno=GönderilecekTelNo&message="+@mes+"&msgheader=TD BILISIM&dil=TR";
                //dil="TR" Türkce karakterli mesaj göndermek için.

				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				request.AutomaticDecompression = DecompressionMethods.GZip;

				using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
				using (Stream stream = response.GetResponseStream())
				using (StreamReader reader = new StreamReader(stream))
				{
					html = reader.ReadToEnd();
				}

				Console.WriteLine(html);
			}
            catch (Exception ex)
            {
				Console.WriteLine(ex.Message);
            }

            #region Kalan_Paket_Bilgisi

            string htmll = string.Empty;
            string urll = @"https://api.netgsm.com.tr/balance/list/get/?usercode=TelNonuzuYaziniz&password=ŞifreniziYaziniz&tip=1";

            HttpWebRequest requestl = (HttpWebRequest)WebRequest.Create(urll);
            requestl.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse responsel = (HttpWebResponse)requestl.GetResponse())
            using (Stream streaml = responsel.GetResponseStream())
            using (StreamReader readerl = new StreamReader(streaml))
            {
                htmll = readerl.ReadToEnd();
            }

            Console.WriteLine(htmll);
            #endregion

        }
		

	}
}

