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
    public class MovieScreeningController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public MovieScreeningController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;//
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<MovieScreening> GetName()
        {
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            return movieScreeningList;
        }

        // GET api/<MovieScreeningController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MovieScreeningController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovieScreeningController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieScreeningController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
