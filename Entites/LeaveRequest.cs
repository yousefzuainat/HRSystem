namespace HR_System.Entites
{
    public class LeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } = "Pending";

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

    }

}