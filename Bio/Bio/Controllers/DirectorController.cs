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
    public class DirectorController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public DirectorController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;
        }
        // GET: api/<DirectorController>
        [HttpGet]
        public IEnumerable<Director> GetDirectors()
        {
            List<Director> directorList = dataContext.Directors.ToList();
            return directorList;
        }

        // GET api/<DirectorController>/5
        [HttpGet("{id}")]
        public IEnumerable<Director> GetDirectorByID(long id)
        {
            List<Director> directorList = dataContext.Directors.ToList();

            var directorsByID = directorList.Where(director => director.directorID == id);

            return directorsByID;
        }
        [HttpGet("directorname")]
        public IEnumerable<Director> GetDirectorByName(string directorName)
        {
            List<Director> directorList = dataContext.Directors.ToList();

            var directorsByName = directorList.Where(director => director.directorName == directorName);

            return directorsByName;
        }
        // POST api/<DirectorController>
        [HttpPost]
        public async Task<ActionResult<Director>> PostCompany(Director director)
        {
            dataContext.Directors.Add(director);
            await dataContext.SaveChangesAsync();

            ////return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            //return CreatedAtAction(nameof(Get), new { movieID = movie.movieID }, movie);
            return director;
        }

        // PUT api/<DirectorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DirectorController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Director>> DeleteDirectorByID(int id)
        {
            List<Director> directorList = dataContext.Directors.ToList();
            var test = directorList.FirstOrDefault(Director => Director.directorID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
