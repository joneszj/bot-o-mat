using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace CommonPatterns.Helpers
{
    /// <summary>
    /// Encapsulates Swagger configuration and setup. 
    /// navigate to ~/swagger/index.html for API definitions
    /// </summary>
    /// Install-Package Swashbuckle.AspNetCore
    /// Install-Package Swashbuckle.AspNetCore.SwaggerUI
    public class SwaggerHelper
    {
        #region public
        public static void Configure(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
        }
        public static void Setup(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        } 
        #endregion
    }
}