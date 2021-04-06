using GB_lessons.Infrastructure.Validations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace GB_lessons.ViewModels
{
    public class EmployeeViewModel
    {
        const int MinEmployeeAge = 18;
        const int MaxEmployeeAge = 60;

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Длина должна быть от 2 до 200 символов")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|[A-Z][a-z]+", ErrorMessage = "Неправильный формат - либо всё русскими, либо всё английскими буквами. Первая заглавная")]
        public string LastName { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Длина должна быть от 2 до 200 символов")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|[A-Z][a-z]+", ErrorMessage = "Неправильный формат - либо всё русскими, либо всё английскими буквами. Первая заглавная")]
        public string FirstName { get; set; }

        [ValidEmployeeBirthDate(MinAge = MinEmployeeAge, MaxAge = MaxEmployeeAge,
            ErrorMessage = "Нельзя указать дату из будущего.",
            MaxDateErrorMessage = "Неопытный - пусть подрастёт",
            MinDateErrorMessage = "Слишком старый - не будем брать")]
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Обязательное поле")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Оклад")]
        [Required(ErrorMessage = "Обязательное поле")]
        [Range(10000, 10000000, ErrorMessage = "Оклад должен быть в пределах от 10т.р. до 10млн.р.")]
        public int Salary { get; set; }

        [Display(Name = "Должность")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Длина должна быть от 5 до 200 символов")]
        public string Position { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    yield return ValidationResult.Success;
        //    yield return new ValidationResult("Ошибка валидации данных", new[] { nameof(LastName), nameof(FirstName)});
        //}
    }
}
