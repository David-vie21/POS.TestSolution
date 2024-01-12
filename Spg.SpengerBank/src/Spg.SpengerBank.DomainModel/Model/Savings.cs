using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Model
{
    public class Savings
    {
        public int Id { get; set; }
        public RegistrationNumber RegistrationNumber { get; set; }
        public Customer? CustomerNav { get; set; }
        public Bank? BankNav { get; set; }

        public Savings(RegistrationNumber registrationNumber, Customer? customerNav, Bank? bankNav)
        {
            RegistrationNumber = registrationNumber;
            CustomerNav = customerNav;
            BankNav = bankNav;
        }

        public Savings()
        {
        }
    }
}
