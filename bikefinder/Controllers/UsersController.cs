using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace bikefinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static readonly List<User> Users = new List<User>();
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return Users;
        }

        // GET: api/User/5
        [HttpGet("{firebaseUserId}", Name = "Get")]
        public User Get(string firebaseUserId)
        {
            return Users.FirstOrDefault(user => user.FirebaseUserId == firebaseUserId);
        }

        // POST: api/User
        [HttpPost]
        public User Post([FromBody] User newUser)
        {
            Users.Add(newUser);
            return newUser;
        }

        // PUT: api/User/5
        //[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        // [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
