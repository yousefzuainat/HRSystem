using HR_System.Entites;
using HRSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRSystem.Data.Config
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.HasKey(x => x.AttendanceId);

            builder.Property(x => x.Date)
                .HasColumnType("DATE")
                .IsRequired();

            builder.HasOne(x => x.Employee)
                .WithMany(e => e.Attendances)
                .HasForeignKey(x => x.EmployeeId);

            builder.ToTable("Attendances");
        }
    }
}
