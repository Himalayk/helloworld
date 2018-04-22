using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Models
{
    public class MessageContext:DbContext
    {
        public MessageContext(DbContextOptions<MessageContext>options) : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }
        
        public DbSet<LongMessage> LongMessages { get; set; }

        public DbSet<ShortMessage> ShortMessages { get; set; }

    }
}
