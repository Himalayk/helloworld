using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        // GET: api/<controller>
        private readonly MessageContext mc;

        public MessageController(MessageContext context) {
            mc = context;
            if (mc.Messages.Count() == 0)
            {
                context.LongMessages.Add(new LongMessage { Id = 1, Content = "Hello World", Sender = "Fnu Masnaga(naga)", City = "Chicago", Occupation = "ASP.NET Developer" });
                context.ShortMessages.Add(new ShortMessage { Id = 2, Content = "Hello World", Sender = "Fnu Masnaga(naga)", AdditionalContent = "Have a good day!" });
                mc.SaveChanges();
            }
        }



        [HttpGet("Long")]
        public string GetLongMessage ()
        {
            Console.WriteLine(mc.LongMessages.First().ToString());
            return mc.LongMessages.First().ToString();

        }

        [HttpGet()]
        public string GetShortMessage()
        {
            Console.WriteLine(mc.ShortMessages.First().ToString());
            return mc.ShortMessages.First().ToString();

        }

        // GET api/<controller>/5
        [HttpGet("{id:int}")]
        public string GetById(int id)
        {
            Message m = mc.Messages.FirstOrDefault(t => t.Id == id);
            if (m == null)
            {
                return "Not Found";
            }

            return m.ToString();
        }
        
    }
}
