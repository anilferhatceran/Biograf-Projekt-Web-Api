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
    public class UserController : ControllerBase
    {
        private readonly DatabaseContext dataContext;

        public UserController(DatabaseContext dataContextObj)
        {
            dataContext = dataContextObj;//
        }
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<User> GetName()
        {
            List<User> userList = dataContext.Users.ToList();
            return userList;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IEnumerable<User> GetUsersByID(long id)
        {
            List<User> userList = dataContext.Users.ToList();
            var userByID = userList.Where(user => user.userID == id);
            return userByID;
        }
        [HttpGet("useremail")]
        public IEnumerable<User> GetUsersByEmail(string useremail)
        {
            List<User> userList = dataContext.Users.ToList();
            var userByEmail = userList.Where(user => user.userEmail == useremail);
            return userByEmail;
        }
       
        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
