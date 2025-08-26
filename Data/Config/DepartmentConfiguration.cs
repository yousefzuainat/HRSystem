using HR_System.Entites;
using HRSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRSystem.Data.Config
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.DepartmentId);

            builder.Property(x => x.DepartmentName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(150)
                .IsRequired();

            builder.ToTable("Departments");
        }
    }
}
