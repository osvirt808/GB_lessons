using GB_lessons.Data;
using GB_lessons.Infrastructure.Services.Interfaces;
using GB_lessons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GB_lessons.Infrastructure.Services
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<Employee> _Employees;
        private int _CurrentMaxId;


        public InMemoryEmployeesData()
        {
            _Employees = TestData.Employees;
            _CurrentMaxId = _Employees.DefaultIfEmpty().Max(e => e?.Id ?? 1);
        }

        public int Add(Employee employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));

            if (_Employees.Contains(employee)) return employee.Id; // До работы с БД

            employee.Id = ++_CurrentMaxId;
            _Employees.Add(employee);

            return employee.Id;
        }

        public IEnumerable<Employee> Get() => _Employees;

        public Employee Get(int id) => _Employees.FirstOrDefault(e => e.Id == id);

        public bool Delete(int id)
        {
            var db_item = Get(id);

            if (db_item is null) return false;

            return _Employees.Remove(db_item);
        }

        public void Update(Employee employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));
 
            if (_Employees.Contains(employee)) return; //До перехода на БД

            var db_item = Get(employee.Id);
            if (db_item is null) return;

            db_item.LastName = employee.LastName;
            db_item.FirstName = employee.FirstName;
            db_item.Position = employee.Position;
            db_item.DateOfBirth = employee.DateOfBirth;
            db_item.Salary = employee.Salary;
            //db.SaveChanges(); //После перехода на БД
        }
    }
}
