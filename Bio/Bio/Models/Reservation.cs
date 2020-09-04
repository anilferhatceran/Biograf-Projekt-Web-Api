using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class Reservation
    {
        public int reservationID { get; set; }
        [Required]
        public User user { get; set; }
        [Required]
        public SeatRow seatRow { get; set; }
        [Required]
        public MovieScreening movieScreening { get; set; }
        [Required]
        public TicketPrice price { get; set; }
        [Required]
        public Hall hall { get; set; }
    }
}
