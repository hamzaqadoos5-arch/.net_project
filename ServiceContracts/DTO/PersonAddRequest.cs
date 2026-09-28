using System;
using System.ComponentModel.DataAnnotations;
using Entities;
using ServiceContracts.CustomValidators;
using ServiceContracts.Enums;

namespace ServiceContracts.DTO
{
    public class PersonAddRequest
    {
        [Required(ErrorMessage = "Person name can't be blank")]
        public string? PersonName { get; set; }
        [Required(ErrorMessage = "Email  can't be blank")]
        [EmailAddress(ErrorMessage = "Email value shuld be a valid email")]
        public string? Email { get; set; }

        [DateOfBirthValidator(MinimumAge = 18, OldestYear = 1900, ErrorMessage = "You must be at least 18 years old to register.")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public GenderOptions? Gender { get; set; }

        [Required(ErrorMessage = "Please select a country")]
        public Guid? CountryID { get; set; }

        public string? Address { get; set; }
        public bool ReceiveNewsLetters { get; set; }


        public Person ToPerson()
        {
            return new Person
            {
                PersonName = PersonName,
                Email = Email,
                DateOfBirth = DateOfBirth,
                Gender = Gender.ToString(),
                Address = Address,
                CountryID = CountryID,
                ReceiveNewsLetters = ReceiveNewsLetters


            };


        }
    }
}

