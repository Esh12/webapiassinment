using Movies.MOdel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Class
{
    class Checkall
    {
        public bool usernamechecck { get; set; }
        public bool seeiffilledin { get; set; }
        public bool ispasswordfilled { get; set; }
        public void Checkallinput (string username, string password, List<Users_MOdel> Userinfo) { 
            
            foreach(Users_MOdel sucks in Userinfo)
            {
                if (username == sucks.Fname)
                {
                    seeiffilledin = true;
                   // ispasswordfilled = true;
                    break;

                }

                else
                {
                    seeiffilledin = false;
                    //usernamechecck = "-1";
                    ispasswordfilled = false;
                }
            }


        }

        public string inputname(string username)
        {
            if (username == "")
            {
                return "ENTER USERNAME";
            }
            else if (usernamechecck == false)
            {
                return "USER ENTER CORRECT PASSWORD OR USERNAME";
            }
            else{
                return "";
            }
        }
        public string inputpassword(string password)
        {
            if (password == "")
            {
                return "ENTER PASSWORD";
            }
            else if (ispasswordfilled == false)
            {
                return "USER ENTER CORRECT PASSWORD OR USERNAME";
            }
            else
            {
                return "";
            }
        }
    }
}
