﻿using System;
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
        public IEnumerable<Genre> GetGenreByID(long id)
        {
            List<Genre> genreList = dataContext.Genres.ToList();

            var genreByID = genreList.Where(genre => genre.genreID == id);

            return genreByID;
        }

        [HttpGet("genrename")]
        public IEnumerable<Genre> GetGenreByName(string genrename)
        {
            List<Genre> genreList = dataContext.Genres.ToList();

            var genreByName = genreList.Where(genre => genre.genreName == genrename);

            return genreByName;
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
        public async Task<ActionResult<Language>> DeleteGenreByID(int id)
        {
            List<Genre> genreList = dataContext.Genres.ToList();
            var test = genreList.FirstOrDefault(Genre => Genre.genreID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
