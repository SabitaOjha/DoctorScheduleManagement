using DSM.DataAccessLayer;
using DSM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DSM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        public DSMDBContext db;
        public HospitalController(DSMDBContext _db)
        {
            this.db = _db;
        }
        // GET: api/<HospitalController>
        [HttpGet]
        public IEnumerable<Hospital> Get()
        {
            var result = db.Hospitals.Where(a => a.IsDeleted == false)
                .Include(a => a.Doctors).ToList();
            return (IEnumerable<Hospital>)result;


        }

        // GET api/<HospitalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HospitalController>
        [HttpPost]
        public OkResult Post([FromBody] Hospital hos)
        {
            Hospital hospital = new Hospital();
            hospital.HospitalName = hos.HospitalName;
            hospital.Location = hos.Location;
            hospital.TelephoneNo = hos.TelephoneNo;
            db.Add(hospital);
            db.SaveChanges();
            return Ok();

        }

        // PUT api/<HospitalController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateHospital(int id, [FromBody] Hospital hospital)
        {
            var result = db.Hospitals.Where(a => a.HospitalId == id).FirstOrDefault();
            if(result != null)
            {
                result.HospitalName = hospital.HospitalName;
                result.Location = hospital.Location;
                result.TelephoneNo = hospital.TelephoneNo;
                db.SaveChanges();
                return Ok(hospital);
            }
            return null;
        }

        


        // DELETE api/<HospitalController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHosRecord(int id)
        {
            var result = db.Hospitals.Where(a => a.HospitalId == id).FirstOrDefault();
            result.IsDeleted = true;
            db.SaveChanges();
            return Ok(result);

        }
    }
}
