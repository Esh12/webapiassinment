using GUI.DBModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;

namespace GUI.Classes
{
    class Useraccount
    {
        public List<Model_User> data { get; set; }
        public string PersonIndex { get; set; }

        public static async Task<Model_User> GetuserInfo()

        {
            string url = $"http://localhost:5000/api/UsersControler/";
            string json = new WebClient().DownloadString(url);
            dynamic obj = JsonConvert.DeserializeObject<List<dynamic>>(json);
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(new Uri(url)))
            {
                if (response.IsSuccessStatusCode)
                {
                    Model_User result = new Model_User();

                    List<string> Listy = new List<string>();

                    foreach (var item in obj)
                    {

                        string s = item.Fname + " " + "\r\n";
                        Listy.Add(result.Fname += s);

                    }
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }



    }
}
