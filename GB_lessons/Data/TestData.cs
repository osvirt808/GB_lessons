using GB_lessons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GB_lessons.Data
{
    internal static class TestData
    {
        public static List<Employee> Employees { get; } = new()
        {
            new Employee { Id = 1, FirstName = "Василий", LastName = "Иванов", DateOfBirth = new DateTime(1980, 1, 1), Position = "Младший программист", Salary = 10000 },
            new Employee { Id = 2, FirstName = "Пётр", LastName = "Васильев", DateOfBirth = new DateTime(1985, 2, 2), Position = "Помощник младшего программиста", Salary = 7000 },
            new Employee { Id = 3, FirstName = "Иван", LastName = "Петров", DateOfBirth = new DateTime(1999, 3, 3), Position = "Интерн", Salary = 5000 }
        };
    }
}
