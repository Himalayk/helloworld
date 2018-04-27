using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public interface IMessage
    {
        IQueryable<Message> Messages { get; }

    }
}
