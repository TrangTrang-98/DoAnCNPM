using ApplicationCore.Entities.PatientAggregate;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities.DoctorAggregate;
using ApplicationCore.Entities;

namespace Infrastructure.Persistence
{
    public class DataSeed
    {
        public static void Initialize(RegisterContext context)
        {
           
            context.Database.EnsureCreated();
            
           
            // DB has seeded
            if (context.Enrollments.Any()) return;

            var patients = new Patient[]
            {
                new Patient
                {
                   PatientId="A001", 
                   PatientName="Nguyen Ha",
                   Gender = true,
                   Birthday = System.DateTime.Parse("1989-12-6"),
                   Address = new Address("198","Đường số 12","Quận 1", "TPHCM","Việt Nam"),
                   Phone = "0337859647"
               
                   },
                new Patient
                {
                   PatientId = "B004", 
                   PatientName="Van Duc",
                   Gender = false,
                   Birthday = System.DateTime.Parse("1996-8-9"),
                   Address = new Address("19","Nguyễn Thượng Hiền","Quận 1", "TPHCM","Việt Nam"),
                   Phone = "09794567895"
                
                   },
                new Patient
                {
                   PatientId = "T008", 
                   PatientName="Văn Trung",
                   Gender = false,
                   Birthday = System.DateTime.Parse("1996-8-10"),
                   Address = new Address("19","Nguyễn Thượng Hiền","Quận 1", "TPHCM","Việt Nam"),
                   Phone = "09794567878"
               
                   },
                new Patient
                {
                   PatientId = "T745", 
                   PatientName="Nguyễn Thị Hoa",
                   Gender = true,
                   Birthday = System.DateTime.Parse("1996-10-9"),
                   Address = new Address("19","Nguyễn Thượng Hiền","Quận 1", "TPHCM","Việt Nam"),
                   Phone = "03694567895"
               
                   }
            };
            foreach (Patient p in patients)
            {
                context.Patients.Add(p); // cung ten voi DbSet<Patient> Patient trong RegisterContext
            }
            context.SaveChanges();

            var doctors = new Doctor[]
            {
                new Doctor("S001","Nguyen A", System.DateTime.Parse("1986-8-7"), "0334578965"),
                new Doctor("H008","Nguyen B", System.DateTime.Parse("1988-5-1"), "0975658745")
            };

            foreach (Doctor d in doctors)
            {
                context.Doctors.Add(d); // cung ten voi DbSet<Patient> Patient trong RegisterContext
            }
            context.SaveChanges();

           
            var enrollments = new Enrollments[]
            {
                // new Enrollment {

                //     StudentID = students.Single(s => s.LastName == "Alexander").ID,

                //     CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,

                //     Grade = Grade.A

                // },
                new Enrollments {
                   
                        PatientId = patients.Single(p => p.PatientName == "Nguyen Ha").PatientId,
                        DoctorId = doctors.Single(d => d.DoctorName == "Nguyen A").DoctorId,
                        enrollmentDate = new EnrollmentDate{
                            Date = System.DateTime.Parse("14"),
                            Month = System.DateTime.Parse("2"),
                            Year = System.DateTime.Parse("2020"),
                            Time = System.DateTime.Parse("14:00:00")
                        }
                },

                 new Enrollments {
                   
                        PatientId = patients.Single(p => p.PatientName == "Van Duc").PatientId,
                        DoctorId = doctors.Single(d => d.DoctorName == "Nguyen B").DoctorId,
                        enrollmentDate = new EnrollmentDate{
                            Date = System.DateTime.Parse("11"),
                            Month = System.DateTime.Parse("1"),
                            Year = System.DateTime.Parse("2020"),
                            Time = System.DateTime.Parse("11:30:00")
                        }
                }
                    
            };

            foreach (Enrollments e in enrollments)
            {
                var enrollmentInData = context.Enrollments.Where(
                    s =>
                            s.patient.PatientId == e.PatientId &&

                            s.doctor.DoctorId == e.DoctorId).SingleOrDefault();

                if (enrollmentInData == null)
                {
                    context.Enrollments.Add(e);
                }
                context.Enrollments.Add(e); // cung ten voi DbSet<Patient> Patient trong RegisterContext
            }
            context.SaveChanges();

            
        }
    }
}