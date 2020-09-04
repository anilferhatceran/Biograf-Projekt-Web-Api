using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class Language
    {
        public int languageID { get; set; }
        [Required]
        public string languageName { get; set; }
        [Required]
        public string languageCode { get; set; }
    }
}
