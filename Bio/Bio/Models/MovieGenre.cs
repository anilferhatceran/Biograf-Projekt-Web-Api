using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class MovieGenre
    {
        public int movieGenreID { get; set; }
        public Movie movie { get; set; }
        public Genre genre { get; set; }
    }
}
