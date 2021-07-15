using Identity.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Tests.Config
{
    public static class ApplicationDbIdentityContextInMemory
    {
        public static ApplicationDbContext Get()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: $"Identity.Db")
                .Options;

            return new ApplicationDbContext(options);
        }
    }
}

