using ApplicationCore.Entities.PatientAggregate;
using ApplicationCore.Entities.DoctorAggregate;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class Enrollments : IAggregateRoot
    {
        public string PatientId{get; set;}
        public string DoctorId{get; set;}
        public Patient patient{get; set;}
        public Doctor doctor{get; set;}
        public EnrollmentDate enrollmentDate{get; set;}
       
    }
}