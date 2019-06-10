using Movies.Class;
using Movies.MOdel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Movies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Checkall c = new Checkall();
           
                using (WebClient wc = new WebClient())
                {
               string url = "http://localhost:5000/api/UsersControler";
                    string json = wc.DownloadString(url);

                    List<Users_MOdel> Userinfo = JsonConvert.DeserializeObject<List<Users_MOdel>>(json);
                c.Checkallinput(username_input.Text, password_input.Text, Userinfo);
                         username_input.Text = c.inputname(username_input.Text);
                         password_input.Text = c.inputpassword(password_input.Text);
            
                   movies m = new movies();
                   m.Show();
                   this.Close();                             
                 }                      
        }

        private void Username_input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
