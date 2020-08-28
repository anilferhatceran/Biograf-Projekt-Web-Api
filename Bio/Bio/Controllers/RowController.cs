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
    public class RowController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public RowController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;
        }
        // GET: api/<RowController>
        [HttpGet]
        public IEnumerable<Row> GetRows()
        {
            List<Row> rowList = dataContext.Rows.ToList();
            return rowList;
        }

        // GET api/<RowController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RowController>
        [HttpPost]
        public async Task<ActionResult<Row>> PostCompany(Row row)
        {
            dataContext.Rows.Add(row);
            await dataContext.SaveChangesAsync();

            ////return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            //return CreatedAtAction(nameof(Get), new { movieID = movie.movieID }, movie);
            return row;
        }

        // PUT api/<RowController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RowController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
