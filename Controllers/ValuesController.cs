using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace heroku_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private MyContext db = null;
        public ValuesController(MyContext _db)
        {
            this.db = _db;
        }

        // GET api/values
        [HttpGet]
        public object Get()
        {
            return Environment.GetEnvironmentVariables();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            return this.db.Items.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
