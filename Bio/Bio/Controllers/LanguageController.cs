using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Bio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public LanguageController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;//
        }
        // GET: api/<LanguageController>
        [HttpGet]
        public IEnumerable<Language> GetName()
        {
            List<Language> languageList = dataContext.Languages.ToList();
            return languageList;
        }

        // GET api/<LanguageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LanguageController>
        [HttpPost]
        public async Task<ActionResult<Language>> PostLanguage(Language language)
        {
            dataContext.Languages.Add(language);
            await dataContext.SaveChangesAsync();

            ////return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            //return CreatedAtAction(nameof(Get), new { movieID = movie.movieID }, movie);
            return language;
        }

        // PUT api/<LanguageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LanguageController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Language>> DeleteLanguageByID(int id)
        {
            List<Language> languageList = dataContext.Languages.ToList();
            var test = languageList.FirstOrDefault(Language => Language.languageID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }

        [HttpDelete("langaugeName")]
        public async Task<ActionResult<Language>> DeleteLangaugeByLanguageName(string langaugeName)
        {
            List<Language> languageList = dataContext.Languages.ToList();
            var test = languageList.FirstOrDefault(Langauge => Langauge.languageName == langaugeName);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
