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
        public IEnumerable<MovieScreening> GetMovScreeningByID(long id)
        {
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            var movieScreeningByID = movieScreeningList.Where(movScreening => movScreening.movieScreeningID == id);
            return movieScreeningByID;
        }
        [HttpGet("starttime")]
        public IEnumerable<MovieScreening> GetMovieScreeningByStartTime(string starttime)
        {
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            var movieScreeningByStartTime = movieScreeningList.Where(movScreening => movScreening.screeningStartTime == starttime);
            return movieScreeningByStartTime;
        }
        [HttpGet("endtime")]
        public IEnumerable<MovieScreening> GetMovieScreeningByEndTime(string endtime)
        {
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            var movieScreeningByEndTime = movieScreeningList.Where(movScreening => movScreening.screeningEndTime == endtime);
            return movieScreeningByEndTime;
        }
        [HttpGet("date")]
        public IEnumerable<MovieScreening> GetMovieScreeningByDate(string date)
        {
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            var movieScreeningByDate = movieScreeningList.Where(movScreening => movScreening.screeningDate == Convert.ToDateTime(date));
            return movieScreeningByDate;
        }
        [HttpGet("hall")]
        public IEnumerable<MovieScreening> GetMovieByCompany(long hall)
        {
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            var movieByScreeningID = movieScreeningList.Where(movie => movie.hall.hallID == hall);
            return movieByScreeningID;
        }
        [HttpGet("movie")]
        public IEnumerable<MovieScreening> GetScreeningByMovieName(string movieName)
        {
            List<MovieScreening> movieScreeningList = dataContext.MovieScreenings.ToList();
            var screeningByMovieName = movieScreeningList.Where(screening => screening.movie.movieTitle == movieName);
            return screeningByMovieName;
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
        public void Delete(int id)
        {
        }
    }
}
