using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneGame.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SessionID { get; set; }
        public string IsAdmin { get; set; }
        public string Ready { get; set; }
        public int Score { get; set; }
        public User()
        {

        }
    }
}
