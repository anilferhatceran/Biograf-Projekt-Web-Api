using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class MovieCompany
    {
        public int movieCompanyID { get; set; }
        
        public Movie movie { get; set; }
        
        public Company company { get; set; }
    }
}
