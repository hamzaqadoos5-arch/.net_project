using Entities;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{
    public class CountriesService : ICountriesService
    {
        private readonly List<Country> _countries;
        public CountriesService(bool initialize = true)
        {
            _countries = new List<Country>();
            if (initialize)
            {


                _countries.AddRange(new List<Country>
                {
                new Country()
                {
                    CountryId = Guid.Parse("3B9F3AD9-ED66-4563-9F2D-1CFCB0258F20"),
                    CountryName = "USA"
                },

                new Country()
                {
                    CountryId = Guid.Parse("5772B367-07FC-4601-9435-F7E7DC8DD0D5"),
                    CountryName = "Canada"
                },

                new Country()
                {
                    CountryId = Guid.Parse("AED05F5D-B8B5-4786-A426-D5A3E93BCDBF"),
                    CountryName = "UK"
                },

                new Country()
                {
                    CountryId = Guid.Parse("A1BD2E01-D27A-42C8-972A-0AD86E80E158"),
                    CountryName = "India"
                },


                new Country()
                {
                    CountryId = Guid.Parse("75ECE568-A860-4687-81DC-F789CD61D9B8"),
                    CountryName = "Australia"
                }
            }
                );


            }






        }

        public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
        {
            if (countryAddRequest == null)
            {
                throw new ArgumentNullException(nameof(countryAddRequest));
            }

            if (countryAddRequest.CountryName == null)
            {
                throw new ArgumentException(nameof(countryAddRequest.CountryName));
            }

            if (_countries.Where(temp => temp.CountryName == countryAddRequest.CountryName).Count() > 0)
            {
                throw new ArgumentException("Country name already exists");
            }

            Country country = countryAddRequest.TOCountry();
            country.CountryId = Guid.NewGuid();
            _countries.Add(country);
            return country.ToCountryResponse();

        }

        public List<CountryResponse> GetAllCountries()
        {
            return _countries.Select(country => country.ToCountryResponse()).ToList();
        }

        public CountryResponse? GetCountryByCountryID(Guid? countryID)
        {
            if (countryID == null)
            {
                return null;
            }

            Country? country_response_from_list = _countries.FirstOrDefault(temp => temp.CountryId == countryID);

            if (country_response_from_list == null)
            { return null; }

            return country_response_from_list.ToCountryResponse();


        }
    }
}
