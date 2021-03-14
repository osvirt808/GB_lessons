﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GB_lessons.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Position { get; set; }

        public int Salary { get; set; }

    }
}
