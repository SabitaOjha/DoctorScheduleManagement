using DSM.DataAccessLayer;
using DSM.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DSM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        public DSMDBContext db;
        public DoctorController(DSMDBContext _db)
        {
            this.db = _db;
        }
        // GET: api/<DoctorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DoctorController>
        [HttpPost]
        public OkResult Post([FromBody] Doctor doc)
        {
            Doctor doctor = new Doctor();
            doctor.FirstName = doc.FirstName;
            doctor.LastName = doc.LastName;
            doctor.DoctorAddress = doc.DoctorAddress;
            doctor.Specialization = doc.Specialization;
            doctor.Contact_no = doc.Contact_no;
            db.Add(doctor);
            db.SaveChanges();
            return Ok();
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
