using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bio.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public SeatController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;
        }
        // GET: api/<SeatController>
        [HttpGet]
        public IEnumerable<Seat> GetSeats()
        {
            List<Seat> seatList = dataContext.Seats.ToList();
            return seatList;
        }

        // GET api/<SeatController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SeatController>
        [HttpPost]
        public async Task<ActionResult<Seat>> PostCompany(Seat seat)
        {
            dataContext.Seats.Add(seat);
            await dataContext.SaveChangesAsync();

            ////return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            //return CreatedAtAction(nameof(Get), new { movieID = movie.movieID }, movie);
            return seat;
        }

        // PUT api/<SeatController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SeatController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
