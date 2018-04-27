using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class EFMessageRepo : IMessage
    {
        private MessageContext context;

        public EFMessageRepo(MessageContext context) {
            this.context = context;
        }

        public IQueryable<Message> Messages => context.Messages;

       
    }
}
