namespace HR_System.Entites
{
    public class Attendance
        {
            public int AttendanceId { get; set; }
            public DateTime Date { get; set; }
            public DateTime? CheckInTime { get; set; }
            public DateTime? CheckOutTime { get; set; }

            public int EmployeeId { get; set; }
            public Employee? Employee { get; set; }
        
    }

}

