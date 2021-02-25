using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JanChaMVC.Models
{
    public partial class User
    {
        
        public int UId { get; set; }
        public string UserName { get; set; }
        public bool UserSex { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Number { get; set; }
        public string Password { get; set; }
    }

}
