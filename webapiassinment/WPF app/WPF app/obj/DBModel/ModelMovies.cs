using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_app.DBModel
{
    class ModelMovies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Picture { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
    }
}
