using HolidayPlanner.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolidayPlanner.DataAccess
{
    public class HolidayPlannerDbContext : DbContext
    {
        public HolidayPlannerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<HolidayRequest> HolidayRequests {get; set;}
        public DbSet<HolidayType> HolidayTypes { get; set; } 

    }
}
