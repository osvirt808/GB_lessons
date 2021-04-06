using System;
using System.ComponentModel.DataAnnotations;

namespace GB_lessons.Infrastructure.Validations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ValidEmployeeBirthDateAttribute: ValidationAttribute
    {
        //private DateTime _minimumDate;
        private int _MaxAgeInt;
        private int _MinAgeInt;

        public ValidEmployeeBirthDateAttribute()
            : base("Invalid date value.")
        {
        }

        public int MaxAge
        {
            get { return this._MaxAgeInt; }
            set
            {
                this._MaxAgeInt = value;
            }
        }
        public int MinAge
        {
            get { return this._MinAgeInt; }
            set
            {
                this._MinAgeInt = value;
            }
        }

        public string MinDateErrorMessage { get; set; }

        public string MaxDateErrorMessage { get; set; }

        #region ValidationAttribute overrides

        public override string FormatErrorMessage(string name)
        {
            return string.Format(
                this.ErrorMessageString, name, this._MaxAgeInt);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime Today = DateTime.Now;
            TimeSpan Diff = (Today - (DateTime)value).Duration();
            int EmployeeAge = (zeroTime + Diff).Year - 1; 

            var enteredDate = (DateTime)value;

            if (_MaxAgeInt < EmployeeAge)
            {
                return new ValidationResult(
                    this.GetMinDateErrorMessage(validationContext.DisplayName));
            }

            if (_MinAgeInt > EmployeeAge)
            {
                return new ValidationResult(
                    this.GetMaxDateErrorMessage(validationContext.DisplayName));
            }

            if (enteredDate > DateTime.Now)
            {
                return new ValidationResult(
                    this.FormatErrorMessage(validationContext.DisplayName));
            }

            return ValidationResult.Success;
        }

        #endregion

        private string GetMinDateErrorMessage(string name)
        {
            return this.MinDateErrorMessage;
        }

        private string GetMaxDateErrorMessage(string name)
        {
            return this.MaxDateErrorMessage;
        }
    }
}
