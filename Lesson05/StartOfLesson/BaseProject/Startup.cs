using BaseProject.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProject
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
            // Comment out if you do not have a local Sql Server installed
<<<<<<< HEAD
            services.AddDbContext<ApplicationContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("BaseProjectHosted")));
=======
            services.AddDbContext<ApplicationContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("BaseProject")));
>>>>>>> 341d044c2e259b73fa141b0978ffef78d8bb2a1a
            // Uncomment if you do not have a local Sql Server installed
            //services.AddDbContext<ApplicationContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("BaseProjectHosted")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
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
        }
    }
}
