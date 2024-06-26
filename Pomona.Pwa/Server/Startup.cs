using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Pomona.Application.Interfaces;
using Pomona.Application.Mapping;
using Pomona.Application.Services;
using Pomona.Infrastructure.Implementation;
using Pomona.Persistence.Context;
using Pomona.Pwa.Server.Data;
using Pomona.Pwa.Server.GrpcServices;
using Pomona.Pwa.Server.Models;

namespace Pomona.Pwa.Server
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("PomonaCs")));

            services.AddDbContext<PomonaDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("PomonaCs")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentityServer()
                .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

            services.AddAuthentication()
                .AddIdentityServerJwt();

            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddGrpc();

            services.AddAutoMapper(typeof(MapperProfile));

            #region Application Services
            services.TryAddTransient<IUnitOfWork, UnitOfWork>();
            services.TryAddTransient<IInventoryService, InventoryService>();
            services.TryAddTransient<IContractService, ContractService>();
            services.TryAddTransient<IParametricService, ParametricService>();
            services.TryAddTransient<ICashService, CashService>();
            #endregion


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseGrpcWeb();

            app.UseIdentityServer();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<InventoryGrpcService>().EnableGrpcWeb();
                endpoints.MapGrpcService<ContractGrpcService>().EnableGrpcWeb();
                endpoints.MapGrpcService<ParametricGrpcService>().EnableGrpcWeb();
                endpoints.MapGrpcService<CashGrpcService>().EnableGrpcWeb();

                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
