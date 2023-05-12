using DSM.Model;
using DSM.Models;
using Microsoft.EntityFrameworkCore;

namespace DSM.DataAccessLayer
{
    public class DSMDBContext:DbContext
    {
        public DbSet<Hospital> Hospitals  { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<AdminCredential> AdminCredentials { get; set; }
        public DbSet<DocAvailableTime> docAvailableTimes { get; set; }


        public DSMDBContext(DbContextOptions<DSMDBContext> options) : base(options) { }
        public DSMDBContext()
        {

        }

    }
   
}
