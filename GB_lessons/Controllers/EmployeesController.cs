using Microsoft.AspNetCore.Mvc;
using GB_lessons.Infrastructure.Services.Interfaces;
using GB_lessons.ViewModels;
using GB_lessons.Models;

namespace GB_lessons.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _EmployeesData;

        public EmployeesController(IEmployeesData EmployeesData)
        {
            _EmployeesData = EmployeesData;
        }

        public IActionResult Index() => View(_EmployeesData.Get());

        public IActionResult DetailCard(int id)
        {

            var employee = _EmployeesData.Get(id);
            if (employee is null)
                return NotFound();

            return View(employee);
        }

        public IActionResult Edit(int Id) 
        {
            var employee = _EmployeesData.Get(Id);

            if (employee is null)
                return NotFound();

            return View(new EmployeeViewModel
            {
                Id = employee.Id,
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                DateOfBirth = employee.DateOfBirth,
                Position = employee.Position,
                Salary = employee.Salary
            });
            
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model) 
        {
            var employee = new Employee
            {
                Id = model.Id,
                LastName = model.LastName,
                FirstName = model.FirstName,
                DateOfBirth = model.DateOfBirth,
                Position = model.Position,
                Salary = model.Salary
            };

            _EmployeesData.Update(employee);

            return RedirectToAction("Index");
        }

    }
}
