using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class MovieDirector
    {
        public int movieDirectorID { get; set; }
        public Movie movie { get; set; }
        [Required]
        public Director director { get; set; }

    }
}
