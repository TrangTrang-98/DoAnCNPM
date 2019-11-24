using ApplicationCore.Entities.PatientAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Persistence.Configuration
{
     public class PatientConfig : IEntityTypeConfiguration<Patient> {
    public void Configure(EntityTypeBuilder<Patient> builder) {
        builder.ToTable("Patient");

        builder.HasKey(i => i.PatientId);

        builder.Property(i => i.PatientName)
            .HasMaxLength(40)
            .IsRequired(true);

        builder.Property(i => i.Gender)
            .HasMaxLength(84)
            .IsRequired(true);

        builder.Property(i => i.Birthday)
            .IsRequired(true);

        builder.Property(i => i.Phone)
            .HasMaxLength(10)
            .IsRequired(true);
    }
}
}