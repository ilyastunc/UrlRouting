using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace UrlRouting
{
    public class Startup
    {
        public IConfiguration Configuration {get;}
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles(new StaticFileOptions 
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                    RequestPath = "/modules"
            });

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            // app.UseMvc(routes => {
            //     routes.MapRoute(    //burda sadece bir sabit ve action ile url'i oluşturduk. url'de controller adı kullanmadık.
            //         name:"Shop1",
            //         template:"shop/{action}",
            //         defaults: new {controller = "Product"}
            //     );

            //     routes.MapRoute(    //controller'dan önce catalog sabit ifadesini getirdik.
            //         name:"catalog", template:"catalog/{controller=Product}/{action=Index}"
            //     );

            //     routes.MapRoute(
            //         name:"default", template:"{controller=Home}/{action=Index}/{id?}/{*extraparams}");
                
            // });
            
                

        }
    }
}
