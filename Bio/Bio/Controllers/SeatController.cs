﻿using System;
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
        public IEnumerable<Seat> GetSeatByID(long id)
        {
            List<Seat> seatList = dataContext.Seats.ToList();
            var seatByID = seatList.Where(seat => seat.seatID == id);
            return seatByID;
        }
        [HttpGet("seattaken")]
        public IEnumerable<Seat> GetSeatByTaken(string seattaken)
        {
            List<Seat> seatList = dataContext.Seats.ToList();
            var seatByTaken = seatList.Where(seat => seat.seatTaken == Convert.ToBoolean(seattaken));
            return seatByTaken;
        }
        [HttpGet("seatnumber")]
        public IEnumerable<Seat> GetSeatBySeatNumber(int seatnumber)
        {
            List<Seat> seatList = dataContext.Seats.ToList();
            var seatBySeatNumber = seatList.Where(seat => seat.seatNumber == seatnumber);
            return seatBySeatNumber;
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
        //[HttpPut("{id}")]
        //public async Task<ActionResult<Genre>> Put(int id, bool isTaken)
        //{
        //    List<Genre> genreList = dataContext.Genres.ToList();
        //    var test = genreList.FirstOrDefault(Genre => Genre.genreID == id);

        //    test.genreName = genreName;

        //    dataContext.Update(test);
        //    await dataContext.SaveChangesAsync();

        //    return test;
        //}
        // DELETE api/<SeatController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Seat>> DeleteSeatByID(int id)
        {
            List<Seat> seatList = dataContext.Seats.ToList();
            var test = seatList.FirstOrDefault(Seat => Seat.seatID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
