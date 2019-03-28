using System;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace RedVentures.Bot_O_Mat.Web
{
    public class Startup
    {
        #region ctor && private
        private readonly ILogger<Startup> _logger;
        private Guid _correlationId;

        public Startup(IConfiguration configuration, ILogger<Startup> logger)
        {
            Configuration = configuration;
            _correlationId = Guid.NewGuid();
            _logger = logger;
        } 
        #endregion

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            try
            {
                services.AddHttpClient();
                //services.AddMemoryCache();
                ConfigureHelpers(services);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception: Startup.ConfigureServices");
                throw;
            }

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (!env.IsProduction()) app.UseDeveloperExceptionPage();
            //else
            //{
            app.UseDeveloperExceptionPage();
                //app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            //}

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            HealthCheckHelper.Setup(app);
            BeatPulseHelper.Setup(app);
            SwaggerHelper.Setup(app);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        #region helpers
        private void ConfigureHelpers(IServiceCollection services)
        {
            HelpersManager.Configure(_correlationId, services, Configuration);
            //CommonPatterns.Filters.ExceptionFilter.Configure(services);
            //CommonPatterns.Filters.RequestResponseFilter.Configure(services);
            SwaggerHelper.Configure(services);
            CacheHelper.Configure(services);
            HealthCheckHelper.Configure(services);
            BeatPulseHelper.Configure(services, Configuration);
            WhoIsHelper.Configure(services);
        }
        #endregion
    }
}
