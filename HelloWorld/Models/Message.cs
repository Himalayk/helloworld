using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public abstract class Message
    {

        public long Id { get; set; }

        public string Sender { get; set; }

        public string Content { get; set;  }
        
    }
}
