using HR_System.Entites;
using HRSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRSystem.Data.Config
{
    public class PayrollConfiguration : IEntityTypeConfiguration<Payroll>
    {
        public void Configure(EntityTypeBuilder<Payroll> builder)
        {
            builder.HasKey(x => x.PayrollId);

            builder.Property(x => x.BaseSalary)
                .HasPrecision(15, 2);

            builder.Property(x => x.Bonus)
                .HasPrecision(15, 2);

            builder.Property(x => x.Deductions)
                .HasPrecision(15, 2);

            builder.Property(x => x.NetSalary)
                .HasPrecision(15, 2);

            builder.HasOne(x => x.Employee)
                .WithMany(e => e.Payrolls)
                .HasForeignKey(x => x.EmployeeId);

            builder.ToTable("Payrolls");
        }
    }
}
