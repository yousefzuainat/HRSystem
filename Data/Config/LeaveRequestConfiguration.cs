using HR_System.Entites;
using HRSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRSystem.Data.Config
{
    public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.HasKey(x => x.LeaveRequestId);

            builder.Property(x => x.Status)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(x => x.Employee)
                .WithMany(e => e.LeaveRequests)
                .HasForeignKey(x => x.EmployeeId);

            builder.ToTable("LeaveRequests");
        }
    }
}
