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

    public class EmployeeUpdateBuilder : IEmployeeUpdateBuilder
    {
        private readonly BankContext _context;
        private readonly Employee _employee;

        public EmployeeUpdateBuilder(BankContext context, Employee employee)
        {
            _context = context;
            _employee = employee;
        }

        public int Save()
        {
            _context.Employees.Update(_employee);
            return _context.SaveChanges();
        }

        public IEmployeeUpdateBuilder WithBank(Bank bank)
        {
            _employee.BankNav = bank;
            return this;
        }

        public IEmployeeUpdateBuilder WithGuid(Guid guid)
        {
            _employee.Guid = guid;
            return this;
        }

        public IEmployeeUpdateBuilder WithGender(Gender gender)
        {
            _employee.Gender = gender;
            return this;
        }

        public IEmployeeUpdateBuilder WithFirstName(string firstName)
        {
            _employee.FirstName = firstName;
            return this;
        }

        public IEmployeeUpdateBuilder WithLastName(string lastName)
        {
            _employee.LastName = lastName;
            return this;
        }

        public IEmployeeUpdateBuilder WithRegistrationNumber(RegistrationNumber registrationNumber)
        {
            _employee.RegistrationNumber = registrationNumber;
            return this;
        }
    }
}
