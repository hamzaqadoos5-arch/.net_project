using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    public class PersonResponse
    {
        public Guid PersonID { get; set; }
        public string? PersonName { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public Guid? CountryID { get; set; }
        public string? Country { get; set; }
        public double?age { get; set; }
        public string? Address { get; set; }
        public bool ReceiveNewsLatters { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj==null)
                return false;
            if (obj.GetType()!=typeof(PersonResponse))
                return true;
            PersonResponse person= (PersonResponse)obj;
            return PersonID == person.PersonID &&
                   PersonName==person.PersonName &&
                   Email == person.Email &&
                   DateOfBirth==person.DateOfBirth &&
                   Gender==person.Gender &&
                   CountryID==person.CountryID &&
                   Address==person.Address &&
                   ReceiveNewsLatters==person.ReceiveNewsLatters;
                   

        
        
        
        }

        public override int GetHashCode()
        {
            return base.GetHashCode()   ;
        }
    }
    public static class PersonExtension
    {


        public static PersonResponse TOPersonResponse(this Person person)
        {

            return new PersonResponse()
            {
                PersonID = person.personID ,
                   PersonName=person.PersonName,
                   Email = person.Email ,
                DateOfBirth = person.DateOfBirth ,
                   Gender = person.Gender ,
                CountryID = person.CountryID,
                   Address = person.Address ,
                   ReceiveNewsLatters = person.ReceiveNewsLatters,
                   age=(person.DateOfBirth!=null)?
                   Math.Round((DateTime.Now-person.DateOfBirth.Value).TotalDays/365.25):null
                    


            };
        
        }


    }


}
