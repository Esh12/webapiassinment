using Movies.MOdel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Movies.Class
{
   public class Users

    {
      // public List<Users_MOdel> Userinfo { get; set; }

        private static string Apiroot = "http://localhost:5000/api/UsersControler";
        public void GetUser() 
        {
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString($"{Apiroot}");

                 //Userinfo = JsonConvert.DeserializeObject<List<Users_MOdel>>(json);

               
            }
        }
    }
}
