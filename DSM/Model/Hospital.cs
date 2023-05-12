using DSM.Model;

namespace DSM.Models
{
    public class Hospital
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string Location { get; set; }
        public string TelephoneNo { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Disease> Diseases { get; set; }
        public bool IsDeleted { get; set; }


        public Hospital()
        {
            this.Doctors = new HashSet<Doctor>();
            this.Diseases = new HashSet<Disease>();
            this.IsDeleted = false;

        }
    }
}