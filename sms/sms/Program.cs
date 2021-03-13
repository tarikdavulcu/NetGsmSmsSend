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
				string mes = "deneme deneme için 2";
				string url = @"https://api.netgsm.com.tr/sms/send/get/?usercode=8503076794&password=20342034Td&gsmno=5378970797&message="+@mes+"&msgheader=TD BILISIM&dil=TR";


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
            string urll = @"https://api.netgsm.com.tr/balance/list/get/?usercode=8503076794&password=20342034Td&tip=1";

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

