using GB_lessons.Models;
using System.Collections.Generic;

namespace GB_lessons.Infrastructure.Services.Interfaces
{
    public interface IEmployeesData
    {
        IEnumerable<Employee> Get();

        Employee Get(int id);

        int Add(Employee employee);

        void Update(Employee employee);

        bool Delete(int id);
    }
}
