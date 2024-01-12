using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Model
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Person
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public Gender Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RegistrationNumber RegistrationNumber { get; set; }

        public Person(int id, Guid guid, Gender gender, string firstName, string lastName, RegistrationNumber registrationNumber)
        {
            Id = id;
            Guid = guid;
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            RegistrationNumber = registrationNumber;
        }

        public Person()
        {
        }
    }
}
