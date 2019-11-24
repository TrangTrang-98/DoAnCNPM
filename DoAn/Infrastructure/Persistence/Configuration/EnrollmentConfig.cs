using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Persistence.Configuration
{
    public class EnrollmentConfig : IEntityTypeConfiguration<Enrollments> {
    public void Configure(EntityTypeBuilder<Enrollments> builder) {
        builder.ToTable("Enrollment");

        builder.Property(i => i.PatientId);
           
         

        builder.Property(i => i.DoctorId);
            
           
        }
    }
}