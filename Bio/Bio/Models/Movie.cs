﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class Movie
    {
        public int movieID { get; set; }
        [Required]
        public string movieTitle { get; set; }
        [Required]
        public string releaseDate { get; set; }
        [Required]
        public string  movieDesc { get; set; }
        [Required]
        public string movieRunTime { get; set; }
        public Language language { get; set; }
    }
}
