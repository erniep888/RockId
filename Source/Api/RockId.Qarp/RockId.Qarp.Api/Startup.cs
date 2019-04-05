using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RockId.Qarp.Api.Service;
using RockId.Qarp.Api.Services.Implementations;
using RockId.Qarp.DataMapper.Repositories;
using RockId.Qarp.DataMapper.Repositories.Implementations;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.Routing;

namespace RockId.Qarp.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.WithOrigins("http://localhost:4200"));
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<IQarpRepository, QarpRepository>();

            services.AddScoped<IQarpService, QarpService>();

            services.AddDbContext<RockIdQarpContext>(options =>            
                options.UseSqlServer(Configuration["ConnectionStrings:QarpConnectionString"])
            );

            services.AddApiVersioning();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {            
            app.UseCors(builder => builder.WithOrigins("http://localhost:4200"));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseMvc();            
        }
    }
}
