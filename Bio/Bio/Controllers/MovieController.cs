using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Bio.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Web;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly DatabaseContext dataContext;
        
        public MovieController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            List<Movie> movieList = dataContext.Movies.ToList();

            List<Language> languageList = dataContext.Languages.ToList();

            

            return movieList;
        }
        //public ActionResult GetMovie()
        //{
        //    List<Movie> movieList = dataContext.Movies.ToList();

        //    List<Language> languageList = dataContext.Languages.ToList();



        //    var movieLangList =
        //        from m in movieList
        //        let langID = from l in languageList
        //                     select l.languageID
        //        where langID.Contains(m.language.languageID) == true
        //        select new { movie = m.movieID, languageID = m.language.languageID };

        //    //foreach (var item in movieLangList)
        //    //{
        //    //    Console.WriteLine($"{item.movie - 10}, {item.languageID}");
        //    //}


        //    return Ok(movieLangList);


        //    //var id = 1;
        //    //var query =
        //    //   from movie in dataContext.Movies
        //    //   join lang in dataContext.Languages on movie.movieID equals lang.languageID
        //    //   where movie.movieID == id
        //    //   select new { Movie = movie, Language = lang };
        //}
        //[HttpGet("{id}")]
        //public IEnumerable<Movie> GetTest(int id)
        //{

        //    List<Movie> movieList = dataContext.Movies.ToList();
        //    var test = movieList.Where(movie => movie.language.languageID == id);
        //    return test;
        //}

        //GET api/<MovieController>/5
        [HttpGet("{id}")] 
        public IEnumerable<Movie> GetMovieByID(long id)
        {
            List<Movie> movieList = dataContext.Movies.ToList();
            var test = movieList.Where(movie => movie.movieID == id);
            return test;
        }
        [HttpGet("title")]

        public IEnumerable<Movie> GetMovieByTitle(string title)
        {
            List<Movie> movieList = dataContext.Movies.ToList();

            var test = movieList.Where(movie => movie.movieTitle == title);
            return test;
        }
        [HttpGet("releaseDate")]

        public IEnumerable<Movie> GetMovieByReleaseDate(string releaseDate)
        {
            List<Movie> movieList = dataContext.Movies.ToList();

            var test = movieList.Where(movie => movie.releaseDate == releaseDate);
            return test;
        }
        [HttpGet("movies")]

        public IEnumerable<Movie> GetMovieByLanguageName(string languagename)
        {
            List<Movie> movieList = dataContext.Movies.ToList();
            List<Language> languageList = dataContext.Languages.ToList();

            
            //var test = dataContext.Movies.Include(movie => movie.language.languageName);

            //string language = Request.Query["lang"];
            var moviesByLanguageName = movieList.Where(movie => movie.language.languageName == languagename);

            return moviesByLanguageName;
        }

        // POST api/<MovieController>
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {
            movie.language = dataContext.Languages.Where(language => language.languageID == movie.language.languageID).FirstOrDefault();
            dataContext.Movies.Add(movie);
            await dataContext.SaveChangesAsync();

            
            return movie;
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> DeleteMovieByID(int id)
        {
            List<Movie> movieList = dataContext.Movies.ToList();
            var test = movieList.FirstOrDefault(Movie => Movie.movieID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
