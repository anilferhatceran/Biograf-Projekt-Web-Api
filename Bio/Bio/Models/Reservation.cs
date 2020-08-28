using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class Reservation
    {
        public int reservationID { get; set; }
        public User user { get; set; }
        public SeatRow seatRow { get; set; }
        public MovieScreening movieScreening { get; set; }
        public TicketPrice price { get; set; }
        public Hall hall { get; set; }
    }
}
