using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OrisonSPMSAPI.Logics.Concrete;
using OrisonSPMSAPI.Logics.Contract;
using OrisonSPMSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI
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
            services.AddDbContext<OrisonSystemALZAMREEQContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IDapperManager, DapperManager>();
            services.AddTransient<IItemMasterManager, ItemMasterManager>();
            services.AddTransient<ILoginManager, LoginManager>();
            services.AddTransient<IOrderingCartManager, OrderingCartManager>();
            services.AddTransient<IOrdersChildManager, OrdersChildManager>();
            services.AddTransient<IOrdersManager, OrdersManager>();
            services.AddTransient<INewOrderManager, NewOrderManager>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
