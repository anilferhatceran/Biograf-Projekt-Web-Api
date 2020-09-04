using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class Seat
    {
        public int seatID { get; set; }
        [Required]
        public bool seatTaken { get; set; }
        [Required]
        public int seatNumber { get; set; }
    }
}
