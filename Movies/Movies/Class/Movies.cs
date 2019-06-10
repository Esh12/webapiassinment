using Movies.MOdel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Class
{
    class GetMovies
    {
        public static async Task<Moviesmodel> GetMoviesmodel()
        {
            string url = "https://jsonplaceholder.typicode.com/users?_limit=5";

            string json = new WebClient().DownloadString(url);
            dynamic obj = JsonConvert.DeserializeObject<List<dynamic>>(json);
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(new Uri(url)))
            {
                if (response.IsSuccessStatusCode)
                {
                    Moviesmodel result = new Moviesmodel();
                    //List<PhoneBook> result = new List<PhoneBook>();
                    List<string> Listy = new List<string>();

                    foreach (var item in obj)
                    {
                        string s = item.Title + " " + "\r\n";
                        string t = item.Summary + " " + "\r\n";
                        string p = item.Genre + " " + "\r\n";
                        Listy.Add(result.Title += s);

                        Listy.Add(result.Summary += t);

                        Listy.Add(result.Genre += p);

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
