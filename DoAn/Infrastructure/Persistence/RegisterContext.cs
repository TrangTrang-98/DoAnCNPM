using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities.DoctorAggregate;
using ApplicationCore.Entities.PatientAggregate;
namespace Infrastructure.Persistence
{
    public class RegisterContext : DbContext
    {
        public RegisterContext(DbContextOptions<DbContext> options) : base(options)
        {
            
        }

        public DbSet<Doctor> Doctors{get; set;}
        public DbSet<Patient> Patients{get; set;}
    }
}