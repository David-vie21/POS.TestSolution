using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Model
{
    public class Bank
    {
        public Bank(RegistrationNumber registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }

        public Bank()
        {
        }
        public int Id { get; set; }
        public RegistrationNumber RegistrationNumber { get; set; }
        private List<Employee> _employees { get; set; } = new();
        public IReadOnlyList<Employee> Employees => _employees;
        private List<Customer> _customers { get; set; } = new();
        public IReadOnlyList<Customer> Customers => _customers;
        private List<Savings> _savings { get; set; } = new();
        public IReadOnlyList<Savings> Savings => _savings;
        public void AddEmployee(Employee employee)
        {
            if (employee is not null)
            {
                _employees.Add(employee);
                if (employee.BankNav != this)
                    employee.BankNav = this;
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            if (employee is not null && _employees.Contains(employee))
            {
                _employees.Remove(employee);
                if (employee.BankNav == this)
                    employee.BankNav = null;
            }
        }

        public void AddCustomer(Customer customer)
        {
            if (customer is not null)
            {
                _customers.Add(customer);
                if (customer.BankNav != this)
                    customer.BankNav = this;
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            if (customer is not null && _customers.Contains(customer))
            {
                _customers.Remove(customer);
                if (customer.BankNav == this)
                    customer.BankNav = null;
            }
        }

        public void AddSavings(Savings savings)
        {
            if (savings is not null)
            {
                _savings.Add(savings);
                if (savings.BankNav != this)
                    savings.BankNav = this;
            }
        }

        public void RemoveSavings(Savings savings)
        {
            if (savings is not null && _savings.Contains(savings))
            {
                _savings.Remove(savings);
                if (savings.BankNav == this)
                    savings.BankNav = null;
            }
        }

    }
}
