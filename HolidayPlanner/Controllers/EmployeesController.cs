using HolidayPlanner.BusinessLogic.Abstractions;
using HolidayPlanner.DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayPlanner.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesRepository employeesRepository;
        // GET: EmployeesController

        public EmployeesController(IEmployeesRepository employeesRepository)
        {
            this.employeesRepository = employeesRepository;
        }
        public ActionResult Index()
        {
            var employees = employeesRepository.GetAll();
            return View(employees);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(Guid id)
        {
            var employee = employeesRepository.GetEmployeeById(id);
            return View(employee);
        }

        // GET: EmployeesController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    employeesRepository.Add(employee);
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
