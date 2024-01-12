using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Model
{
    public class Customer : Person
    {
     


        public string Username { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public Address Address { get; set; }
        private List<Savings> _savings { get; set; } = new();
        public IReadOnlyList<Savings> Savings => _savings;
        public Bank? BankNav { get; set; }

        public Customer(int id, Guid guid, Gender gender, string firstName, string lastName, RegistrationNumber registrationNumber, string username, DateTime registrationDateTime, Address address, Bank bankNav) : base(id, guid, gender, firstName, lastName, registrationNumber)
        {
            Username = username;
            RegistrationDateTime = registrationDateTime;
            Address = address;
            BankNav = bankNav;
        }

        public Customer()
        {
        }

        public void AddSavings(Savings savings)
        {
            if (savings is not null)
            {
                _savings.Add(savings);
                if (savings.CustomerNav != this)
                    savings.CustomerNav = this;
            }
        }
    }
}

