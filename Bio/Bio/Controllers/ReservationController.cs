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
    public class ReservationController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public ReservationController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;//
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Reservation> GetReservations()
        {
            List<Reservation> reservationList = dataContext.Reservations.ToList();
            List<User> userList = dataContext.Users.ToList();
            List<SeatRow> seatRowList = dataContext.SeatRows.ToList();
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            List<TicketPrice> ticketPriceList = dataContext.TicketPrices.ToList();
            List<Hall> hallList = dataContext.Halls.ToList();
            List<Movie> movieList = dataContext.Movies.ToList();
            List<Row> rowList = dataContext.Rows.ToList();
            List<Seat> seatList = dataContext.Seats.ToList();
            List<Language> languageList = dataContext.Languages.ToList();
            return reservationList;
        }

        // GET api/<ReservationController>/5
        [HttpGet("{id}")]
        public IEnumerable<Reservation> GetReservByID(long id)
        {
            List<Reservation> reservList = dataContext.Reservations.ToList();
            var reservsByID = reservList.Where(reservations => reservations.reservationID == id);
            return reservsByID;
        }

        // POST api/<ReservationController>
        [HttpPost]
        public async Task<ActionResult<Reservation>> PostReservation(Reservation reservation)
        {
            reservation.user = dataContext.Users.Where(user => user.userID == reservation.user.userID).FirstOrDefault();
            reservation.seatRow = dataContext.SeatRows.Where(seatRow => seatRow.seatRowID == reservation.seatRow.seatRowID).FirstOrDefault();
            reservation.movieScreening = dataContext.MovieScreenings.Where(MovieScreening => MovieScreening.movieScreeningID == reservation.movieScreening.movieScreeningID).FirstOrDefault();
            reservation.ticketPrice = dataContext.TicketPrices.Where(ticketPrice => ticketPrice.ticketPriceID == reservation.ticketPrice.ticketPriceID).FirstOrDefault();
            reservation.hall = dataContext.Halls.Where(hall => hall.hallID == reservation.hall.hallID).FirstOrDefault();
            dataContext.Reservations.Add(reservation);
            await dataContext.SaveChangesAsync();


            return reservation;
        }

        // PUT api/<ReservationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservationController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Reservation>> DeleteReservationByID(int id)
        {
            List<Reservation> reservationList = dataContext.Reservations.ToList();
            var test = reservationList.FirstOrDefault(Reservation => Reservation.reservationID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
