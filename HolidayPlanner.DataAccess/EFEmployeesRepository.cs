using HolidayPlanner.BusinessLogic.Abstractions;
using HolidayPlanner.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolidayPlanner.DataAccess
{
    public class EFEmployeesRepository : IEmployeesRepository
    {
        private readonly HolidayPlannerDbContext dataContext;
        public EFEmployeesRepository(HolidayPlannerDbContext context)
        {
            dataContext = context;
        }

        public void Add(Employee employee)
        {
            dataContext.Employees.Add(employee);
            dataContext.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return dataContext
                   .Employees
                   .ToList();
        }

        public IEnumerable<Employee> GetByName(string name)
        {
            return dataContext.Employees
                              .Where(empl => 
                                     empl.Name.Contains(name))
                              .ToList();
        }

        public Employee GetEmployeeById(Guid id)
        {
            return dataContext.Employees
                              .Single(empl => empl.Id.Equals(id));
        }
    }
}
