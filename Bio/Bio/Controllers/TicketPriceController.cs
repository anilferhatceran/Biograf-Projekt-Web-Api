using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bio.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketPriceController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public TicketPriceController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;//
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<TicketPrice> GetName()
        {
            List<TicketPrice> ticketPriceList = dataContext.TicketPrices.ToList();
            return ticketPriceList;
        }

        // GET api/<TicketPriceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TicketPriceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TicketPriceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TicketPriceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
