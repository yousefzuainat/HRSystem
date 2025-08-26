using HR_System.Entites;
using HRSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRSystem.Data.Config
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(x => x.JobId);

            builder.Property(x => x.JobTitle)
                .HasColumnType("VARCHAR")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.MinSalary)
                .HasPrecision(15, 2);

            builder.Property(x => x.MaxSalary)
                .HasPrecision(15, 2);

            builder.ToTable("Jobs");
        }
    }
}
