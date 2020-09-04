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
        [Required]
        public Movie movie { get; set; }
        [Required]
        public Genre genre { get; set; }
    }
}
