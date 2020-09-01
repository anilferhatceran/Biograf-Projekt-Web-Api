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
        public IEnumerable<MovieScreening> GetMovies()
        {
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            List<Movie> movieList = dataContext.Movies.ToList();
            List<Hall> hallList = dataContext.Halls.ToList();

            List<Language> languageList = dataContext.Languages.ToList();



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
        public async Task<ActionResult<MovieScreening>> PostMovie(MovieScreening movieScreening)
        {
            dataContext.MovieScreenings.Add(movieScreening);
            await dataContext.SaveChangesAsync();

            ////return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            //return CreatedAtAction(nameof(Get), new { movieID = movie.movieID }, movie);
            return movieScreening;
        }

        // PUT api/<MovieScreeningController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieScreeningController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MovieScreening>> DeleteMovieScreeningByID(int id)
        {
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            var test = movieScreeningList.FirstOrDefault(MovieScreening => MovieScreening.movieScreeningID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
