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
    public class LanguageController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public LanguageController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;//
        }
        // GET: api/<LanguageController>
        [HttpGet]
        public IEnumerable<Language> GetLanguage()
        {
            List<Language> languageList = dataContext.Languages.ToList();
            return languageList;
        }

        // GET api/<LanguageController>/5
        [HttpGet("{id}")]
        public IEnumerable<Language> GetLanguageByID(long id)
        {
            List<Language> languageList = dataContext.Languages.ToList();
            var languageByID = languageList.Where(language => language.languageID == id);

            return languageByID;
        }

        [HttpGet("languagename")]
        public IEnumerable<Language> GetLanguageByName(string languagename)
        {
            List<Language> langaugeList = dataContext.Languages.ToList();
            var languageByName = langaugeList.Where(language => language.languageName == languagename);

            return languageByName;
        }
        [HttpGet("languagecode")]
        public IEnumerable<Language> GetLanguageByCode(string languagecode)
        {
            List<Language> languageList = dataContext.Languages.ToList();
            var languageByCode = languageList.Where(language => language.languageCode == languagecode);

            return languageByCode;
        }
        // POST api/<LanguageController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LanguageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LanguageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
