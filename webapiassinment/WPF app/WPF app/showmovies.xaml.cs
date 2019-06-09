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
using WPF_app.Class;

namespace WPF_app
{
    /// <summary>
    /// Interaction logic for showmovies.xaml
    /// </summary>
    public partial class showmovies : Window
    {
        public showmovies()
        {
            InitializeComponent();
        }

        private async void Showmovies1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var info = await Movies.GetMovies();
            showmovies1.Text = $"{info.Title}";

        }
    }
}
