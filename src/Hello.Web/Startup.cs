using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Swashbuckle.Swagger;

namespace Hello.Web
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.ConfigureCors(options =>
                                    options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                                        .AllowAnyMethod()
                                                                        .AllowAnyHeader()));
            services.AddMvc();
            services.AddSwagger(c =>
            {
                c.SwaggerGeneratorOptions.SingleApiVersion(new Info
                {
                    Version = "v1",
                    Title = "Huzzah!",
                    Description = "An example ASP.NET 5 service",
                    TermsOfService = "Unintelligible legalese..."
                });
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseCors("AllowAll");
            app.UseMvc();
            app.UseSwaggerUi("api");
            app.UseSwagger("{apiVersion}");
            app.UseWelcomePage();
        }
    }
}
