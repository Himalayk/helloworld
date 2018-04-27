using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;
using System.Net.Http;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        // GET: api/<controller>
        private IMessage repository;

        public MessageController(IMessage repo) {
            repository = repo;
        }

        [HttpGet]
        public IActionResult GetMessage ()
        {
            Message m = repository.Messages.First();
            if (m == null)
            {
                return NotFound();
            }

            var result = m.Content + ". From " + m.Sender;

            Console.WriteLine(result);
            return Ok(result);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult GetById(long? id)
        {
            Message m = repository.Messages.FirstOrDefault(t => t.MessageId == id);
            string fullContent = m.Content + ". From " + m.Sender;
            if (m == null)
            {
                return NotFound();
            }

            Console.WriteLine(fullContent);
            return Ok(fullContent);
        }
        
    }
}
