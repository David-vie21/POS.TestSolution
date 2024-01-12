using Spg.SpengerBank.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Interfaces
{
    public interface IEmployeeUpdateBuilder
    {
        IEmployeeUpdateBuilder WithBank(Bank bank);
        IEmployeeUpdateBuilder WithGuid(Guid guid);
        IEmployeeUpdateBuilder WithGender(Gender gender);
        IEmployeeUpdateBuilder WithFirstName(string firstName);
        IEmployeeUpdateBuilder WithLastName(string lastName);
        IEmployeeUpdateBuilder WithRegistrationNumber(RegistrationNumber registrationNumber);
        int Save();
    }
}
