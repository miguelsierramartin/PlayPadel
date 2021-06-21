using Customer.Persistence.Database;
using Microsoft.EntityFrameworkCore;

namespace Customer.Tests.Config
{
    public static class ApplicationDbCustomerContextInMemory
    {
        public static ApplicationDbContext Get()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: $"Customer.Db")
                .Options;

            return new ApplicationDbContext(options);
        }
    }
}