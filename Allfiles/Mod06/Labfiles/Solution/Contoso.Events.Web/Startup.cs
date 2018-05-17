using Contoso.Events.Data;
using Contoso.Events.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Contoso.Events.Web
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
            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddMvc();
            
            services.Configure<ApplicationSettings>(Configuration.GetSection(nameof(ApplicationSettings)));
            services.Configure<CosmosSettings>(Configuration.GetSection(nameof(CosmosSettings)));

            services.AddSingleton<IConfiguration>(Configuration);
            services.AddSingleton<RegistrationContext>();

            services.AddDbContext<EventsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("EventsContextConnectionString")));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
            }

            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();

            app.UseMvc(routes => { });
        }
    }
}