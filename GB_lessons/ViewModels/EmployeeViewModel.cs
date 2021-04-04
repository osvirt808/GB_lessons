using System;

namespace GB_lessons.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }

    }
}
