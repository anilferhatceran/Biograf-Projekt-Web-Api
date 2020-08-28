using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class MovieDirector
    {
        public int movieDirectorID { get; set; }
        public Movie movie { get; set; }
        public Director director { get; set; }

    }
}
