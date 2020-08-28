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
    public class GenreController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public GenreController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;
        }
        // GET: api/<GenreController>
        [HttpGet]
        public IEnumerable<Genre> GetGenres()
        {
            List<Genre> genreList = dataContext.Genres.ToList();
            return genreList;
        }

        // GET api/<GenreController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GenreController>
        [HttpPost]
        public async Task<ActionResult<Genre>> PostCompany(Genre genre)
        {
            dataContext.Genres.Add(genre);
            await dataContext.SaveChangesAsync();

            ////return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            //return CreatedAtAction(nameof(Get), new { movieID = movie.movieID }, movie);
            return genre;
        }

        // PUT api/<GenreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GenreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
