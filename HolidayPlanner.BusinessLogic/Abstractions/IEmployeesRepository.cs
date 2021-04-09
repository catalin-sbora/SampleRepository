using HolidayPlanner.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolidayPlanner.BusinessLogic.Abstractions
{
    public interface IEmployeesRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetEmployeeById(Guid id);
        IEnumerable<Employee> GetByName(string name);

        void Add(Employee employee);

    }
}
