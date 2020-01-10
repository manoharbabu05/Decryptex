using ACA.Decryptex.Cache;
using ACA.Decryptex.Cache.Provider;
using ACA.Decryptex.Cache.Provider.Interface;
using ACA.Decryptex.Repository.Context;
using ACA.Decryptex.Resolver;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ACA.Decryptex.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private static string ConnectionString { get; set; }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            ConnectionString = Configuration["GlobalSettings:Database:MasterConnection"];

            RegisterModelInformation(services);
            RegisterDbContextInformation(services);
        }

        private void RegisterDbContextInformation(IServiceCollection services)
        {
            services.AddDbContext<MasterDBContext>(option => option.UseSqlServer(ConnectionString));
            services.AddDbContext<ClientDBContext>(option => { });
        }

        private void RegisterModelInformation(IServiceCollection services)
        {
            services.BaseRegister();

            services.AddTransient<IMCache, MCache>();
            services.AddScoped<ITenantProvider, TenantProvider>();
        }
    }
}