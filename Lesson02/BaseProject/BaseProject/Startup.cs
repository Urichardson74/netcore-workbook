using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseProject.Intrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BaseProject
{
    public class NotFoundException : Exception{}

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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
<<<<<<< HEAD
            services.AddSingleton<DateTimeProvider>(new DateTimeProvider());
=======
            services.AddSingleton<IDateTimeProvider>(new DateTimeProvider());
>>>>>>> d2cabe8699f79eaeae611990f6a1049bed0b12a6
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {   
            app.UseMiddleware<CalculateTime>();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }



            app.UseStaticFiles();

            app.UseMvc();

            app.UseMiddleware<UnwrapExceptionMiddleware>();
          
        }
    }
}
