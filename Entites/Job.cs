namespace HR_System.Entites
{
    public class Job
     {
            public int JobId { get; set; }
            public string JobTitle { get; set; } = string.Empty;
            public decimal MinSalary { get; set; }
            public decimal MaxSalary { get; set; }

            public ICollection<Employee>? Employees { get; set; }
        
    }
}
