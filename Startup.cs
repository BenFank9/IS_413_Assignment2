using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS_413_Assignment2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //Add Error Page
            }
            
            //need to import the functionality from NuGet Manager
            app.UseNodeModules(); 

            //does not let us serve a file at the root directory aka security risk.
            app.UseStaticFiles(); 

            //this finds the controllers and the views this dynamically renders a view
            //use routing to find a certain endpoint
            app.UseRouting(); 

            //what are we going to run from the routing
            app.UseEndpoints(cfg =>
            {
                //create a default endpoint that the routing calls
                //look first for controller, then the action of that controller, then the id
                cfg.MapControllerRoute("Default",
                    "{controller}/{action}/{id?}",
                    new { controller = "Home", action = "Index" });
            }

            );
        }
    }
}
