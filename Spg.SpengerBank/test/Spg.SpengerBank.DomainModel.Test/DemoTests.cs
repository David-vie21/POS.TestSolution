using Spg.SpengerBank.DomainModel.Model;
using Spg.SpengerBank.DomainModel.Test.Helpers;
using Spg.SpengerBank.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.SpengerBank.DomainModel.Test
{
    public class DemoTests
    {
        [Fact()]
        public void DemoTest_ShouldSucceed_When_DBCreates()
        {
            using (BankContext db = DatabaseUtilities.GetDatabase())
            {
                // Arrange
                var data = DatabaseUtilities.GetDemos()[0];

                // Act
                db.Demos.AddRange(data);
                db.SaveChanges();

                // Assert
                Assert.Single(db.Demos);
            }
        }

        [Fact()]
        public void Bank_Create()
        {
            using (BankContext db = DatabaseUtilities.GetDatabase())
            {
                // Arrange
                var data = DatabaseUtilities.GetBanks()[0];

                // Act
                db.Banks.AddRange(data);
                db.SaveChanges();

                // Assert
                Assert.Single(db.Banks);
            }
        }

        [Fact]
        public void Customer_Create()
        {
            using (BankContext db = DatabaseUtilities.GetDatabase())
            {
                // Arrange
                var data = DatabaseUtilities.GetCustomers()[0];
                // Act
                db.Customers.AddRange(data);
                db.SaveChanges();
                // Assert
                Assert.Single(db.Customers);
            }
        }
        [Fact]
        public void Employee_Create()
        {
            using (BankContext db = DatabaseUtilities.GetDatabase())
            {
                // Arrange
                var data = DatabaseUtilities.GetEmployees()[0];
                // Act
                db.Employees.AddRange(data);
                db.SaveChanges();
                // Assert
                Assert.Single(db.Employees);
            }
        }

        [Fact]
        public void Savings_Create()
        {
            using (BankContext db = DatabaseUtilities.GetDatabase())
            {
                // Arrange
                var data = DatabaseUtilities.GetSavings()[0];
                // Act
                db.Savings.AddRange(data);
                db.SaveChanges();
                // Assert
                Assert.Single(db.Savings);
            }
        }


    }
}
