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
        public IEnumerable<Hall> GetHallByID(long id)
        {
            List<Hall> hallList = dataContext.Halls.ToList();

            var hallsByID = hallList.Where(hall => hall.hallID == id);

            return hallsByID;
        }
        [HttpGet("numberofseats")]
        public IEnumerable<Hall> GetHallByNumOfSeats(int numberOfSeats)
        {
            List<Hall> hallList = dataContext.Halls.ToList();

            var hallByNumOfSeat = hallList.Where(hallSeats => hallSeats.hallNumOfSeats >= numberOfSeats);

            return hallByNumOfSeat;
        }
        [HttpGet("numberofrows")]
        public IEnumerable<Hall> GetHallByNumOfRows(int numberOfRows)
        {
            List<Hall> hallList = dataContext.Halls.ToList();

            var hallByNumOfRows = hallList.Where(hallRows => hallRows.numOfRows >= numberOfRows);

            return hallByNumOfRows;
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
