using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class ShortMessage : Message
    {
        
     public string AdditionalContent { get; set; }

     public override string ToString ()
        {
            return base.Content + "!  My name is " + base.Sender + ".  " + AdditionalContent;  
        }

    }
}
