using Mc2.CrudTest.Acceptance.Domain.Customers.Repositories;
using Mc2.CrudTest.Acceptance.Framework.UnitOfWork.Contract;
using Mc2.CrudTest.Acceptance.Persistance.Ef.init;
using Mc2.CrudTest.Acceptance.Persistance.Ef.Repositories.Customers;
using Mc2.CrudTest.Acceptance.Persistance.Ef.UnitOfWork;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.Facade;
using Mc2.CrudTest.Presentation.Application.Contract.Customers.FacadeQuery;
using Mc2.CrudTest.Presentation.Server.Facade.Customers;
using Mc2.CrudTest.Presentation.Server.FacadeQuery.Customers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Mc2.CrudTest.Presentation.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddControllersWithViews();
            //services.AddRazorPages();
           
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mc2.CrudTest.Presentation.Server", Version = "v1" });
            });
            services.AddScoped<ICustomerQueryRepository, CustomerQueryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerFacade, CustomerFacade>();
            services.AddScoped<ICustomerFacadeQuery, CustomerFacadeQuery>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.ConfigureEf();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mc2.CrudTest.Presentation.Server"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //app.UseBlazorFrameworkFiles();
            //app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();
                endpoints.MapControllers();
                //endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
