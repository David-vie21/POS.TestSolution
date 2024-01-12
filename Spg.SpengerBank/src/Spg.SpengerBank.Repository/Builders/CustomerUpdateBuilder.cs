using Spg.SpengerBank.DomainModel.Interfaces;
using Spg.SpengerBank.DomainModel.Model;
using Spg.SpengerBank.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.Repository.Builders
{
    public class CustomerUpdateBuilder : ICustomerUpdateBuilder
    {
        private readonly BankContext _context;
        private readonly Customer customer;

        public CustomerUpdateBuilder(BankContext context, Customer customer)
        {
            _context = context;
            customer = customer;
        }

        public int Save()
        {
            _context.Customers.Update(customer);
            return _context.SaveChanges();
        }

        public ICustomerUpdateBuilder WithAddress(Address address)
        {   
            customer.Address = address;
            return this;
        }

        public ICustomerUpdateBuilder WithUsername(string username)
        {
            customer.Username = username;
            return this;
        }

        public ICustomerUpdateBuilder WithRegistrationDateTime(DateTime registrationDateTime)
        {
            customer.RegistrationDateTime = registrationDateTime;
            return this;
        }

        public ICustomerUpdateBuilder WithGuid(Guid guid)
        {
            customer.Guid = guid;
            return this;
        }

        public ICustomerUpdateBuilder WithGender(Gender gender)
        {
            customer.Gender = gender;
            return this;
        }

        public ICustomerUpdateBuilder WithFirstName(string firstName)
        {
            customer.FirstName = firstName;
            return this;
        }

        public ICustomerUpdateBuilder WithLastName(string lastName)
        {
            customer.LastName = lastName;
            return this;
        }

        public ICustomerUpdateBuilder WithRegistrationNumber(RegistrationNumber registrationNumber)
        {
            customer.RegistrationNumber = registrationNumber;
            return this;
        }

    }
}
