namespace HR_System.Entites
{
    public class Payroll
    {
        public int PayrollId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }
        public decimal Deductions { get; set; }
        public decimal NetSalary { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

    }
}
