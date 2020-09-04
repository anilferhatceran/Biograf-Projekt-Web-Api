using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class TicketPrice
    {
        public int ticketPriceID { get; set; }
        [Required]
        public string ticketName { get; set; }
        [Required]
        public float ticketPrice { get; set; }
    }
}
