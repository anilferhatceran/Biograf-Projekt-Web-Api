using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class User
    {
        public int userID { get; set; }
        [Required]
        public string userEmail { get; set; }
        [Required]
        public string passwordHash { get; set; }
    }

}
