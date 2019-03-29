using System;
using CommonPatterns.Filters;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Hubs;
using RedVentures.Bot_O_Mat.API.Services;

namespace RedVentures.Bot_O_Mat.API
{
    public class Startup
    {
        #region ctor && private
        private readonly ILogger<Startup> _logger;
        private readonly IHostingEnvironment _env;
        private Guid _correlationId;

        public Startup(IConfiguration configuration, IHostingEnvironment env, ILogger<Startup> logger)
        {
            Configuration = configuration;
            _logger = logger;
            _env = env;
            _correlationId = Guid.NewGuid();
        } 
        #endregion

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            try
            {
                DefaultServices(services);
                HelperInjections(services);
                ContextInjections(services, _env.ContentRootPath);
                ServiceInjections(services);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception: Startup.ConfigureServices");
                throw;
            }
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (!env.IsProduction()) app.UseDeveloperExceptionPage();
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseCors(policy => policy.WithOrigins("https://localhost:44328").AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSignalR(routes =>
            {
                routes.MapHub<NotificationHub>("/notification");
            });

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
        private void HelperInjections(IServiceCollection services)
        {
            HelpersManager.Configure(_correlationId, services, Configuration);
            ExceptionFilter.Configure(services);
            RequestResponseFilter.Configure(services);
            RefreshRobotCacheFilter.Configure(services);
            RefreshCyborgCacheFilter.Configure(services);
            SwaggerHelper.Configure(services);
            CacheHelper.Configure(services);
            HealthCheckHelper.Configure(services);
            BeatPulseHelper.Configure(services, Configuration);
            WhoIsHelper.Configure(services);
        }

        private static void ServiceInjections(IServiceCollection services)
        {
            services.AddScoped<IRobotService, RobotService>();
            services.AddScoped<ICyborgService, CyborgService>();
            services.AddScoped<IBattleService, BattleService>();
            services.AddScoped<IErrandService, ErrandService>();
            services.AddScoped<IKillBoardService, KillBoardService>();
            services.AddScoped<ILeaderBoardService, LeaderBoardService>();
            services.AddScoped<IGraveyardService, GraveyardService>();
        }
        private static void DefaultServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddHttpClient();
            services.AddSignalR();
        }

        private void ContextInjections(IServiceCollection services, string basePath) => services.AddDbContext<BotOMatContext>(options => options.UseSqlite($"Data Source={basePath}/BotOMatContext.db"));
        #endregion
    }
}
