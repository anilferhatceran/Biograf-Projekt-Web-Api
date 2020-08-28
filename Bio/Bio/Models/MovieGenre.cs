using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class MovieGenre
    {
        public int movieGenreID { get; set; }
        public Movie movie { get; }
        public Genre genre { get; }
    }
}
