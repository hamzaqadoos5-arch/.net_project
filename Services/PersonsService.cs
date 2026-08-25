using Entities;
using ServiceContracts;
using ServiceContracts.DTO;
using Services.Helper;
using System.ComponentModel.DataAnnotations;


namespace Services
{
    public class PersonsService : IPersonsService
    {
        private readonly List<Person> _persons;
        private readonly ICountriesService _countriesService;

        public PersonsService()
        {
            _persons=new List<Person>();
            _countriesService=new CountriesService();

        }

        private PersonResponse ConvertPersonToPersonResponse(Person person)
        {
            PersonResponse personResponse = person.ToPersonResponse();
            personResponse.Country = _countriesService.GetCountryByCountryID(person.CountryID)?.CountryName;
            return personResponse;
        }
        public PersonResponse AddPerson(PersonAddRequest? personAddRequest)
        {
            if (personAddRequest == null)
            {
                throw new ArgumentNullException(nameof(personAddRequest));
            }
            //Model Validation
            ValidaTionHelper.ModelValidation(personAddRequest);

             Person person = personAddRequest.ToPerson();

            person.personID=Guid.NewGuid();

            _persons.Add(person);
            //convert the Person object into PersonResponse type
            return ConvertPersonToPersonResponse(person);

        }

        public List<PersonResponse> GetAllPersons()
        {
            return _persons.Select(temp => temp.ToPersonResponse()).ToList();
        }

        public PersonResponse ?GetPersonByPersonID(Guid? personID)
        {
           if(personID==null)
            {
                return null;

            }
           Person person= _persons.FirstOrDefault(temp=> temp.personID==personID);
            if(personID==null)
                return null;
            return person.ToPersonResponse();

        }
    }
}
