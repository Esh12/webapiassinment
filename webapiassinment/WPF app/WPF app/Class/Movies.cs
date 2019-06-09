using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPF_app.DBModel;

namespace WPF_app.Class
{
    class Movies
    {
        public List<ModelMovies> data { get; set; }
        public string PersonIndex { get; set; }

        public static async Task<ModelMovies> GetMovies()

        {
            string url = $"http://localhost:5000/api/UsersControler/";
            string json = new WebClient().DownloadString(url);
            dynamic obj = JsonConvert.DeserializeObject<List<dynamic>>(json);
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(new Uri(url)))
            {
                if (response.IsSuccessStatusCode)
                {
                    ModelMovies result = new ModelMovies();

                    List<string> Listy = new List<string>();

                    foreach (var item in obj)
                    {

                        string s = item.Title + " " + "\r\n";
                        Listy.Add(result.Title += s);

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
