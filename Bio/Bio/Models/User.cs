using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Models
{
    public class User
    {
        public int userID { get; set; }
        public string userEmail { get; set; }
        public byte[] passwordHash { get; set; }
    }

}
