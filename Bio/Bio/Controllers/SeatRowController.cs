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
    public class SeatRowController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public SeatRowController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;//
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<SeatRow> GetName()
        {
            List<Seat> seatList = dataContext.Seats.ToList();
            List<Row> rowList = dataContext.Rows.ToList();
            List<SeatRow> seatRowList = dataContext.SeatRows.ToList();
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            List<Movie> movieList = dataContext.Movies.ToList();
            List<Hall> hallList = dataContext.Halls.ToList();
            List<Language> languagesList = dataContext.Languages.ToList();
            return seatRowList;
        }

        // GET api/<SeatRowController>/5
        [HttpGet("{id}")]
        public IEnumerable<SeatRow> GetSeatRowByID(long id)
        {
            List<SeatRow> seatRowList = dataContext.SeatRows.ToList();
            var seatRowByID = seatRowList.Where(seatRow => seatRow.seatRowID == id);
            return seatRowByID;
        }

        // POST api/<SeatRowController>
        [HttpPost]
        public async Task<ActionResult<SeatRow>> PostSeatRow(SeatRow seatRow)
        {
            seatRow.row = dataContext.Rows.Where(row => row.rowID == seatRow.row.rowID).FirstOrDefault();
            seatRow.seat = dataContext.Seats.Where(seat => seat.seatID == seatRow.seat.seatID).FirstOrDefault();
            seatRow.movieScreening = dataContext.MovieScreenings.Where(movieScreening => movieScreening.movieScreeningID == seatRow.movieScreening.movieScreeningID).FirstOrDefault();
            dataContext.SeatRows.Add(seatRow);
            await dataContext.SaveChangesAsync();


            return seatRow;
        }

        // PUT api/<SeatRowController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SeatRowController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SeatRow>> DeleteSeatRowByID(int id)
        {
            List<SeatRow> seatRowList = dataContext.SeatRows.ToList();
            var test = seatRowList.FirstOrDefault(SeatRow => SeatRow.seatRowID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
