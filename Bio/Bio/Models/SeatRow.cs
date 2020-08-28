using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class SeatRow
    {
        public int seatRowID { get; set; }
        public Row row { get; set; }
        public Seat seat { get; set; }
        public MovieScreening movieScreening { get; set; }
    }
}
