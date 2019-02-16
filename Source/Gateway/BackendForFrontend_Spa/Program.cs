using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace RockId.BackendForFrontend_Spa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            IWebHostBuilder builder = WebHost.CreateDefaultBuilder(args);

            builder.ConfigureServices( service => service.AddSingleton(builder))
                 .ConfigureAppConfiguration( appConf => appConf.AddJsonFile(Path.Combine("Configuration", "configuration.json")))
                 .UseStartup<Startup>()
                 .UseSerilog((builderContext, config) => 
                 {
                     config
                        .MinimumLevel.Information()
                        .Enrich.FromLogContext()
                        .WriteTo.Console();
                 });
            IWebHost host = builder.Build();

            return host;
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
