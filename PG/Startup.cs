using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PG.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PG
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //  Adding services // TODO:  Add a service that works with it.  
            services.AddControllersWithViews();
            services.AddSession();
            services.AddTransient<ITransactionsRepo, MockTransactionsData>();
            //  
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();       // To use static files, eg images, text files plus others.
            app.UseRouting();           // Routing of the displays of each page .
            //app.UseCors("GlobalAccess"); //  TODO: This helps for our API calls.
            app.UseAuthorization();     //

            app.UseEndpoints(endpoints =>
            {
                // Map where all the pages will be by default .
                // For Security will be adding this code instead. 
                endpoints.MapDefaultControllerRoute();
                endpoints.MapControllers();
            });
        }
    }
}
