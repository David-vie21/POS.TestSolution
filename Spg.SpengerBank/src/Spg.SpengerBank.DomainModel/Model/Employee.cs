using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Model
{
    public class Employee : Person
    {
        public Employee(int id, Guid guid, Gender gender, string firstName, string lastName, RegistrationNumber registrationNumber, int employeeId, Bank bankNav) : base(id, guid, gender, firstName, lastName, registrationNumber)
        {
            EmployeeId = employeeId;
            BankNav = bankNav;
        }

        public Employee()
        {
        }

        public int EmployeeId { get; set; }
        public Bank? BankNav { get; set; }

        
    }
}
