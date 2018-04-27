using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class DbInitializer
    {
        public static void Initialize (MessageContext context)
        {
            context.Database.EnsureCreated();

            if (context.Messages.Any())
            {
                return;
            }

            var messages = new Message [] 
            {
                new Message {Sender ="Fnu Masnaga", Content="Hello World"},
            };

            foreach (Message m in messages){
                context.Messages.Add(m);

            }
            context.SaveChanges();




        }

    }
}
