using Spg.SpengerBank.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Interfaces
{
    public interface ICustomerUpdateBuilder
    {
        ICustomerUpdateBuilder WithAddress(Address address);
        ICustomerUpdateBuilder WithUsername(string username);
        ICustomerUpdateBuilder WithRegistrationDateTime(DateTime registrationDateTime);
        ICustomerUpdateBuilder WithGuid(Guid guid);
        ICustomerUpdateBuilder WithGender(Gender gender);
        ICustomerUpdateBuilder WithFirstName(string firstName);
        ICustomerUpdateBuilder WithLastName(string lastName);
        ICustomerUpdateBuilder WithRegistrationNumber(RegistrationNumber registrationNumber);
        int Save();
    }
}
