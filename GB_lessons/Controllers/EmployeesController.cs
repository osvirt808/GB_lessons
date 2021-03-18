using GB_lessons.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GB_lessons.Controllers
{
    public class EmployeesController : Controller
    {
        private static readonly List<Employee> __Employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Василий", LastName = "Иванов", DateOfBirth = new DateTime(1980, 1, 1), Position = "Младший программист", Salary = 10000 },
                new Employee { Id = 2, FirstName = "Пётр", LastName = "Васильев", DateOfBirth = new DateTime(1985, 2, 2), Position = "Помощник младшего программиста", Salary = 7000 },
                new Employee { Id = 3, FirstName = "Иван", LastName = "Петров", DateOfBirth = new DateTime(1999, 3, 3), Position = "Интерн", Salary = 5000 }
            };

        public IActionResult Index() => View(__Employees);

        public IActionResult DetailCard(int id)
        {

            Employee employee = __Employees.Where(x => x.Id == id).FirstOrDefault();
            return View(model: employee);
        }

    }
}
