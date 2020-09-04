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
        [Required]
        public Movie movie { get; set; }
        [Required]
        public Hall hall { get; set; }
        [Required]
        public DateTime screeningDate { get; set; }
        [Required]
        public string screeningStartTime { get; set; }
        [Required]
        public string screeningEndTime { get; set; }
    }
}
