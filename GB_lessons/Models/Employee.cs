using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace GB_lessons.Models
{
    public class Employee
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [MinLength(2)]
        [Required(ErrorMessage = "Фамилия является обязательной")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Длина должна быть от 2 до 200 символов")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|[A-Z][a-z]+", ErrorMessage = "Неправильный формат - либо всё русскими, либо всё английскими буквами. Первая заглавная")] 
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MinLength(5)]
        public string Position { get; set; }

        [Range(10000, 1000000)]
        [Required]
        public int Salary { get; set; }

    }
}
