using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class User
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string Password { get; set; }
        public Department? Department { get; set; }
        public string? Position { get; set; }
        public DateOnly? HireDate { get; set; }
        public decimal? Salary { get; set; }
        public ContactInfo? ContactInfo { get; set; }
        public WorkStatus WorkStatus { get; set; }
    }
}
