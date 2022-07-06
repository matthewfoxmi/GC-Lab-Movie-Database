using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab_Movie_Database
{
    internal class Movie
    {
        //properties

        public string Title { get; set; }
        public string Category { get; set; }

        //constructor
        public Movie(string _title, string _category)
        {
            _title = Title;
            _category = Category;
        }           
    }
}
