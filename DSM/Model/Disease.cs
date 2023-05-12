namespace DSM.Models
{
    public class Disease
    {
        public int DiseaseId { get; set; }
        public string DiseaseName { get; set; }
        public string DiseaseDescription { get; set; }
        public int? HospitalID { get; set; }
        public Hospital hospital;
        public int? DoctorID { get; set; }
        public Doctor doctor;
        public bool IsDeleted { get; set; }
        public Disease()
        {
            this.IsDeleted = false;
        }
    }
}

