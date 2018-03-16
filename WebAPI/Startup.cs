﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using DatabaseLibrary;
using Microsoft.Extensions.Configuration;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            log.Write($"Logging:LogLevel:Microsoft: {configuration["Logging:LogLevel:Microsoft"]}");
        }

        public IConfiguration Configuration { get; }

        public Log log = new Log();

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //Project will be run on development environment only, so staging and production environments are ignored
            //more information here: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("CRM WebAPI");
            });
        }
    }
}
