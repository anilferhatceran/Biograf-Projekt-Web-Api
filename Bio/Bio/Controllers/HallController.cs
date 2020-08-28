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
    public class HallController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public HallController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;
        }
        // GET: api/<HallController>
        [HttpGet]
        public IEnumerable<Hall> GetHalls()
        {
            List<Hall> hallList = dataContext.Halls.ToList();
            return hallList;
        }

        // GET api/<HallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HallController>
        [HttpPost]
        public async Task<ActionResult<Hall>> PostCompany(Hall hall)
        {
            dataContext.Halls.Add(hall);
            await dataContext.SaveChangesAsync();

            ////return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            //return CreatedAtAction(nameof(Get), new { movieID = movie.movieID }, movie);
            return hall;
        }

        // PUT api/<HallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
