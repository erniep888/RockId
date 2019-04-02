using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RockId.Qarp.DataMapper.Repositories
{
    public class RockIdQarpContextFactory : IDesignTimeDbContextFactory<RockIdQarpContext>
    {
        public RockIdQarpContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var builder = new DbContextOptionsBuilder<RockIdQarpContext>();

            var connectionString = configuration.GetConnectionString("QarpConnectionString");

            builder.UseSqlServer(connectionString);

            return new RockIdQarpContext(builder.Options);
        }
    }
}
