using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DSM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocAvailableTimeController : ControllerBase
    {
        // GET: api/<DocAvailableTimeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DocAvailableTimeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DocAvailableTimeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DocAvailableTimeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DocAvailableTimeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
