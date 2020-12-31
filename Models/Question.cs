using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneGame.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Q { get; set; }
        public string CAns { get; set; }
        public string Ans1 { get; set; }
        public string Ans2 { get; set; }
        public string Ans3 { get; set; }
        public Question()
        {

        }
    }
}
