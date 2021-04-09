using System;
using System.Collections.Generic;
using System.Text;

namespace HolidayPlanner.DataModel
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public Employee DirectManger { get; set; }
        public ICollection<HolidayRequest> HolidayRequests { get; set; }
    }
}
