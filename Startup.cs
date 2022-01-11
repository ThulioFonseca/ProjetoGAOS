using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoGAOS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ProjetoGAOS
{
    public class Startup
    {

            public IConfiguration Configuration { get; set; }

            public Startup(IConfiguration configuration)
         {
            Configuration = configuration;

         }
               public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDbContext<aulaContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DBconnetionsString")));
        }

        public void Configure(IApplicationBuilder app)
        {
        
            
                app.UseDeveloperExceptionPage();
                app.UseStaticFiles();
                app.UseRouting();
                app.UseEndpoints(endpoints =>
            {
               endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
