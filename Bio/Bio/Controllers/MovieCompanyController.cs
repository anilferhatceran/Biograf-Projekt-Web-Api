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
        public IEnumerable<MovieCompany> GetMovieCompanies()
        {
            List<MovieCompany> movieCompanyList = dataContext.MovieCompanies.ToList();
            List <Movie> movieList = dataContext.Movies.ToList();
            List<Company> companyList = dataContext.Companies.ToList();
            return movieCompanyList;
        }

        // GET api/<MovieCompanyController>/5
        [HttpGet("{id}")]
        public IEnumerable<MovieCompany> GetCompanyByID(long id)
        {
            List<MovieCompany> movieCompanyList = dataContext.MovieCompanies.ToList();
            var movieComByID = movieCompanyList.Where(movieCom => movieCom.movieCompanyID == id);
            return movieComByID;
        }
        [HttpGet("company")]
        public IEnumerable<MovieCompany> GetMovieByCompany(string companyName)
        {
            List<MovieCompany> movieCompanyList = dataContext.MovieCompanies.ToList();
            var movieByCompany = movieCompanyList.Where(movie => movie.company.companyName == companyName);
            return movieByCompany;
        }
        [HttpGet("movie")]
        public IEnumerable<MovieCompany> GetCompanyByMovieName(string movieName)
        {
            List<MovieCompany> movieCompanyList = dataContext.MovieCompanies.ToList();
            var companyByMovieName = movieCompanyList.Where(company => company.movie.movieTitle == movieName);
            return companyByMovieName;
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
