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
        public string languageName { get; set; }
        public string languageCode { get; set; }
    }
}
