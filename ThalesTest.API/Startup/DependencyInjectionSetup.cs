using CommonComponents.Interfaces;
using ThalesTest.Data.Data;

namespace ThalesTest.API.Startup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            services.AddCorsConfiguration();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerConfiguration();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }

        public static WebApplication ConfigureDependencies(this WebApplication app)
        {
            app.ConfigureSwagger();
            app.ConfigureCors();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            return app;
        }
    }
}
