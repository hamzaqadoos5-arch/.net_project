using System.ComponentModel.DataAnnotations;

namespace ServiceContracts.CustomValidators
{
    public class DateOfBirthValidatorAttribute : ValidationAttribute
    {
        public int MinimumAge { get; set; } = 18;
        public int OldestYear { get; set; } = 1900;

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime dateOfBirth = (DateTime)value;


                if (dateOfBirth.Year < OldestYear)
                {
                    return new ValidationResult($"Year of birth cannot be older than {OldestYear}.");
                }


                DateTime minimumAllowedDate = DateTime.Today.AddYears(-MinimumAge);
                if (dateOfBirth > minimumAllowedDate)
                {
                    return new ValidationResult(ErrorMessage ?? $"You must be at least {MinimumAge} years old.");
                }
            }


            return ValidationResult.Success;
        }
    }
}