using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class SeatRow
    {
        public int seatRowID { get; set; }
        [Required]
        public Row row { get; set; }
        [Required]
        public Seat seat { get; set; }
        [Required]
        public MovieScreening movieScreening { get; set; }
    }
}
