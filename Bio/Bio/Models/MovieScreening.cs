using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class MovieScreening
    {
        public int movieScreeningID { get; set; }
        public Movie movie { get; set; }
        public Hall hall { get; set; }
        [Required]
        public string screeningDate { get; set; }
        [Required]
        public string screeningStartTime { get; set; }
        [Required]
        public string screeningEndTime { get; set; }
    }
}
