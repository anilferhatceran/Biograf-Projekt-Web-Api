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
    public class CompanyController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public CompanyController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;
        }
        // GET: api/<CompanyController>
        [HttpGet]
        public IEnumerable<Company> GetCompanies()
        {
            List<Company> companyList = dataContext.Companies.ToList();
            return companyList;
        }
        [HttpGet("companyName")]

        public IEnumerable<Company> GetCompanyByName(string companyName)
        {
            List<Company> companyList = dataContext.Companies.ToList();

            var companiesByName = companyList.Where(company => company.companyName == companyName);
            return companiesByName;
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public IEnumerable<Company> GetCompanyByID(long id)
        {
            List<Company> companyList = dataContext.Companies.ToList();

            var companiesByID = companyList.Where(company => company.companyID == id);
            return companiesByID;
        }

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            dataContext.Companies.Add(company);
            await dataContext.SaveChangesAsync();

            ////return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            //return CreatedAtAction(nameof(Get), new { movieID = movie.movieID }, movie);
            return company;
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Company>> DeleteCompanyByID(int id)
        {
            List<Company> companyList = dataContext.Companies.ToList();
            var test = companyList.FirstOrDefault(Company => Company.companyID == id);

            dataContext.Remove(test);
            await dataContext.SaveChangesAsync();

            return test;
        }
    }
}
