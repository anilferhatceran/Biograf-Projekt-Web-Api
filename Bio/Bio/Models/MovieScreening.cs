using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class MovieScreening
    {
        public int movieScreeningID { get; set; }
        public Movie movie { get; }
        public Hall hall { get; }
        public DateTime screeningDate { get; set; }
        public string screeningStartTime { get; set; }
        public string screeningEndTime { get; set; }
    }
}
