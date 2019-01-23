using EventLogger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EventLogger.Migrations
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EventLoggerContext>
    {
        public EventLoggerContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<EventLoggerContext>();
            var connectionString = configuration.GetConnectionString("migrationContextConnection");
            builder.UseSqlServer(connectionString);
            return new EventLoggerContext(builder.Options);
        }
    }
}
