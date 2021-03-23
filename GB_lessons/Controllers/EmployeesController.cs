using GB_lessons.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using GB_lessons.Data;

namespace GB_lessons.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly List<Employee> _Employees;

        public EmployeesController()
        {
            _Employees = TestData.Employees;
        }

        public IActionResult Index() => View(_Employees);

        public IActionResult DetailCard(int id)
        {

            var employee = _Employees.FirstOrDefault(x => x.Id == id);
            if (employee is null)
                return NotFound();

            return View(employee);
        }

    }
}
