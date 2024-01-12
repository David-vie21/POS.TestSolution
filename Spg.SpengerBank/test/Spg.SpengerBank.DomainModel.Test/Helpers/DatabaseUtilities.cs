using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Spg.SpengerBank.DomainModel.Model;
using Spg.SpengerBank.Infrastructure;
using System.Diagnostics;

namespace Spg.SpengerBank.DomainModel.Test.Helpers 
{
    public static class DatabaseUtilities
    {
        public static BankContext GetDatabase()
        {
            SqliteConnection connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();

            DbContextOptions options = new DbContextOptionsBuilder()
                .UseSqlite(connection)
                .Options;

            BankContext db = new BankContext(options);
            db.Database.EnsureCreated();

            return db;
        }


        public static List<Demo> GetDemos()
        {
            return new List<Demo>()
            {
                new Demo() { Name="Demo 1" },
                new Demo() { Name="Demo 2" }
            };
        }


        public static List<RegistrationNumber> GetRegistrationNumbers()
        {
            return new List<RegistrationNumber>()
            {
                new RegistrationNumber("AT", "1234", "5678"),
                new RegistrationNumber("AT", "9876", "5432"),
                new RegistrationNumber("AT", "3645", "3685"),
                new RegistrationNumber("AT", "6524", "8454"),
                new RegistrationNumber("AT", "8454", "6524"),
                new RegistrationNumber("AT", "6855", "4577"),
                new RegistrationNumber("AT", "4577", "6855"),
                new RegistrationNumber("AT", "4577", "5677"),
                new RegistrationNumber("AT", "4577", "6454"),

            };
        }
        public static List<Person> GetPersons() 
        {
            return new List<Person>()
            {
                new Person(1, Guid.NewGuid(), Gender.Male, "Jon", "Dow", GetRegistrationNumbers()[0]),
                new Person(2, Guid.NewGuid(), Gender.Female, "Jane", "Dow", GetRegistrationNumbers()[1])
            };
        }
        public static List<Employee> GetEmployees() 
        {
            return new List<Employee>()
            {
                new Employee(3, Guid.NewGuid(), Gender.Male, "Jon", "Dow", GetRegistrationNumbers()[2], 1, null),
                new Employee(4, Guid.NewGuid(), Gender.Female, "Jane", "Dow", GetRegistrationNumbers()[3], 2, null)
            };
        }

        public static List<Address> GetAddresses()
        {
            return new List<Address>()
            {
                new Address("1", "testStreet", "Wien", "1210"),
                new Address("2", "testStreet2", "Wien", "1220")
            };
        }
        public static List<Customer> GetCustomers() 
        {
            return new List<Customer>()
            {
                new Customer(5, Guid.NewGuid(), Gender.Male, "Jon", "Dow", GetRegistrationNumbers()[4],"testUser", DateTime.Now, GetAddresses()[0], null),
                new Customer(6, Guid.NewGuid(), Gender.Female, "Jane", "Dow", GetRegistrationNumbers()[5],"testUser2", DateTime.Now.AddDays(-1), GetAddresses()[1], null)
            };
        }
        public static List<Bank> GetBanks()
        {
            return new List<Bank>()
            {
                new Bank(GetRegistrationNumbers()[6]),
                new Bank(GetRegistrationNumbers()[7])
            };
        }

        public static List<Savings> GetSavings()
        {
            return new List<Savings>()
            {
                new Savings(GetRegistrationNumbers()[1],GetCustomers()[0], GetBanks()[0]),
                new Savings(GetRegistrationNumbers()[2],GetCustomers()[1], GetBanks()[1])
            };
        }
    }
}
