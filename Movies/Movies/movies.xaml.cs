using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Movies.Class;
namespace Movies
{
    /// <summary>
    /// Interaction logic for movies.xaml
    /// </summary>
    public partial class movies : Window
    {
        public movies()
        {
            InitializeComponent();
           

        }

       

     

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var info = await GetMovies.GetMoviesmodel();
            MovieName.Text = $"{info.Title}";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
