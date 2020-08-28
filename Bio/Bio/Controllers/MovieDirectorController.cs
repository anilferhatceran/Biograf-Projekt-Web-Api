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
    public class MovieDirectorController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public MovieDirectorController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;//
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<MovieDirector> GetName()
        {
            List<MovieDirector> movieDirectorList = dataContext.MovieDirectors.ToList();
            return movieDirectorList;
        }
        // GET: api/<MovieDirectorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MovieDirectorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MovieDirectorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovieDirectorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieDirectorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
