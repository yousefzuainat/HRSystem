using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_System.Entites
{
    public class Employee
    {
       
            public int EmployeeId { get; set; }
            public string FullName { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public DateTime HireDate { get; set; }
            public decimal Salary { get; set; }

            // Relations
            public int DepartmentId { get; set; }
            public Department? Department { get; set; }

            public int JobId { get; set; }
            public Job? Job { get; set; }

            public ICollection<Attendance>? Attendances { get; set; }
            public ICollection<LeaveRequest>? LeaveRequests { get; set; }
            public ICollection<Payroll>? Payrolls { get; set; }
        }
    }

