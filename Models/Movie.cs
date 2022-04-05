using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Movie
    {
        public string title { get; set; }
        public DateTime date { get; set; }
        public string desc { get; set; }

        public Movie()
        {

        }

        public Movie(string title, DateTime date, string desc)
        {
            this.title = title;
            this.date = date;
            this.desc = desc;
        }

        public string PreviewInformation()
        {
            return title + "\n" + date.ToString() + "\n" + desc;
        }

        public override string ToString()
        {
            return title;
        }

    }
}
