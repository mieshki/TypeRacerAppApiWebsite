using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TypeRacer
{
    class ApiRequest
    {
        public static string url = "http://localhost:55941/";

        public static string GET(string url, string username = "", string password = "")
        {
            try
            {
                WebClient client = new WebClient();
                if (username != "" && password != "")
                {
                //client.Credentials = new NetworkCredential(username, password);
                    client.QueryString.Add("Username", username);
                    client.QueryString.Add("Password", password);
                }

                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                Stream data = client.OpenRead(url);
                StreamReader reader = new StreamReader(data);
                string response = reader.ReadToEnd();
                data.Close();
                reader.Close();

                return response;
            }
            catch (Exception)
            {
                return "#ERR";
            }

        }

        public static string POST_WithResponse(string url, string parameters, string username = "", string password = "")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            if (username != "" || password != "")
                request.Credentials = new NetworkCredential(username, password);

            request.Method = "POST";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(parameters);


            request.ContentLength = byteArray.Length;
            request.ContentType = @"application/json";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        return reader.ReadToEnd();
                    }
                }
            }
            catch (WebException exc)
            {
                return "#ERR";
            }

            return "#ERR";
        }
    }
}
