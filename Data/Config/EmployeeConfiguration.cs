using HR_System.Entites;
using HRSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRSystem.Data.Config
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.EmployeeId);

            builder.Property(x => x.FullName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Phone)
                .HasMaxLength(20);

            builder.Property(x => x.Salary)
                .HasPrecision(15, 2);

            builder.HasOne(x => x.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(x => x.DepartmentId);

            builder.HasOne(x => x.Job)
                .WithMany(j => j.Employees)
                .HasForeignKey(x => x.JobId);

            builder.ToTable("Employees");
        }
    }
}
