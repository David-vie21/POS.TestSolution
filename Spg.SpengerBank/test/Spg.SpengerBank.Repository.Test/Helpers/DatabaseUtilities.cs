using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Spg.SpengerBank.Infrastructure;

namespace Spg.SpengerBank.Repository.Test.Helpers 
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
    }
} 
