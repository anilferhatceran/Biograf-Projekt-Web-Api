using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bio.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieGenreController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public MovieGenreController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;//
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<MovieGenre> GetName()
        {
            List<MovieGenre> movieGenreList = dataContext.MovieGenres.ToList();
            List<Movie> movieList = dataContext.Movies.ToList();
            List<Genre> genreList = dataContext.Genres.ToList();
            return movieGenreList;
        }

        // GET api/<MovieGenreController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MovieGenreController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovieGenreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieGenreController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MovieGenre>> DeleteMovieGenreByID(int id)
        {
            List<MovieGenre> movieGenreList = dataContext.MovieGenres.ToList();
            var test = movieGenreList.FirstOrDefault(MovieGenre => MovieGenre.movieGenreID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
