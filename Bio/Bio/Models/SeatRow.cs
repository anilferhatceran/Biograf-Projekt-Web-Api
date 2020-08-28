using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class SeatRow
    {
        public int seatRowID { get; set; }
        public Row row { get; }
        public Seat seat { get; }
        public MovieScreening movieScreening { get; set; }
    }
}
