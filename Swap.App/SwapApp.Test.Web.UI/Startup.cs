using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlGulumVerGulum.BLL.Abstract;
using AlGulumVerGulum.BLL.Concrete;
using AlGulumVerGulum.BLL.DependencyResolver;
using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DAL.Concrete;
using AlGulumVerGulum.DAL.EntityFramework;
using AlGulumVerGulum.Test.Web.UI.Extensions;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AlGulumVerGulum.Test.Web.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSingleton<IConfiguration>(provider=>Configuration);
            services.AddDi();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseAppConfig();
        }
    }
}
