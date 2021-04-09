using System;
using System.Collections.Generic;
using System.Text;

namespace HolidayPlanner.DataModel
{
    public class HolidayType
    {
        public Guid Id { get; set; }
        public string Acronym { get; set; }
        public string Description { get; set; }
    }
}
