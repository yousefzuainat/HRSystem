using HR_System.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_System.Data
{
    public class AppDbContext : DbContext
    {
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Department> Departments { get; set; }
            public DbSet<Job> Jobs { get; set; }
            public DbSet<Attendance> Attendances { get; set; }
            public DbSet<LeaveRequest> LeaveRequests { get; set; }
            public DbSet<Payroll> Payrolls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config  = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }

}

