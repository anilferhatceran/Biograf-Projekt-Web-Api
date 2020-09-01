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
    public class MovieCompanyController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public MovieCompanyController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;//
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<MovieCompany> GetName()
        {
            List<MovieCompany> movieCompanyList = dataContext.MovieCompanies.ToList();
            return movieCompanyList;
        }

        // GET api/<MovieCompanyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MovieCompanyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovieCompanyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieCompanyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MovieCompany>> DeleteMovieCompanyByID(int id)
        {
            List<MovieCompany> movieCompanyList = dataContext.MovieCompanies.ToList();
            var test = movieCompanyList.FirstOrDefault(MovieCompany => MovieCompany.movieCompanyID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
