using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class Director
    {
        public int directorID { get; set; }
        [Required]
        public string directorName { get; set; }
    }
}
