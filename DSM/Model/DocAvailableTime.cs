using DSM.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.VisualBasic;

namespace DSM.Model
{
    public class DocAvailableTime
    {
        public int Id { get; set; }
        public string DayName { get; set; }
        public string Time { get; set; }
        public int? DoctorID { get; set; }
        public Doctor doctor;
        public bool IsDeleted { get; set; }
        public DocAvailableTime()
        {
            this.IsDeleted = false;
        }

    }
}
