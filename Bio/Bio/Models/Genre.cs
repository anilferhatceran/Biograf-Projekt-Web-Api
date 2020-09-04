using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class Genre
    {
        public int genreID { get; set; }
        [Required]
        public string genreName { get; set; }
    }
}
