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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReservationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
