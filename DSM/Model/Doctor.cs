using DSM.Model;
using System.Collections.Immutable;

namespace DSM.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DoctorAddress { get; set; }
        public string Specialization { get; set; }
        public string Contact_no { get; set; }
        public int? HospitalId { get; set; }
        public Hospital hospital;
        public ICollection<Disease> Diseases { get; set; }
        public ICollection<DocAvailableTime> Days { get; set; }
        public bool IsDeleted { get; set; }
        public Doctor()
        {
            this.Diseases = new HashSet<Disease>();
            this.Days = new HashSet<DocAvailableTime>();
            this.IsDeleted = false;
        }
    }
}
