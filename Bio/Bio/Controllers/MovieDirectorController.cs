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
        public IEnumerable<MovieDirector> GetMovieDirectors()
        {
            List<MovieDirector> movieDirectorList = dataContext.MovieDirectors.ToList();
            List<Language> languageList = dataContext.Languages.ToList();
            List<Movie> movieList = dataContext.Movies.ToList();
            List<Director> directorList = dataContext.Directors.ToList();

            return movieDirectorList;
        }

        // GET api/<MovieDirectorController>/5
        [HttpGet("{id}")]
        public IEnumerable<MovieDirector> GetMovDirectorByID(long id)
        {
            List<MovieDirector> movDirectorList = dataContext.MovieDirectors.ToList();
            var movDirByID = movDirectorList.Where(movDirector => movDirector.movieDirectorID == id);

            return movDirByID;
        }
        [HttpGet("director")]
        public IEnumerable<MovieDirector> GetMovieByDirector(string directorName)
        {
            List<MovieDirector> movieDirectorList = dataContext.MovieDirectors.ToList();
            var movieByDirector = movieDirectorList.Where(movie => movie.director.directorName == directorName);
            return movieByDirector;
        }
        [HttpGet("movie")]
        public IEnumerable<MovieDirector> GetCompanyByMovieName(string movieName)
        {
            List<MovieDirector> movieDirectorList = dataContext.MovieDirectors.ToList();
            var directorByMovieName = movieDirectorList.Where(director => director.movie.movieTitle == movieName);
            return directorByMovieName;
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
