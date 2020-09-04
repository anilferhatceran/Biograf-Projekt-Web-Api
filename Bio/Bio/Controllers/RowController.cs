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
        public IEnumerable<Row> GetRowByID(long id)
        {
            List<Row> rowList = dataContext.Rows.ToList();
            var rowByID = rowList.Where(row => row.rowID == id);

            return rowByID;
        }
        [HttpGet("{id}")]
        public IEnumerable<Row> GetRowByRowNum(int rowNumber)
        {
            List<Row> rowList = dataContext.Rows.ToList();
            var rowByRowNum = rowList.Where(row => row.rowNumber == rowNumber);

            return rowByRowNum;
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
