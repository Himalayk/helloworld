using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class LongMessage: Message
    {
        
        public string City { get; set; }

        public string Occupation { get; set; }
        
        
        public override string ToString()
        {
            return base.Content + "!  My name is " + base.Sender + ". I live in " + City + ". I am your " + Occupation; 
        }
    }
}
