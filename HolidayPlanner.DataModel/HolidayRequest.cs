using System;
using System.Collections.Generic;
using System.Text;

namespace HolidayPlanner.DataModel
{
    public class HolidayRequest
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfDays { get; set; }
        public HolidayType HolidayType { get; set; }

    }
}
