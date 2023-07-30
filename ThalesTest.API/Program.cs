namespace ThalesTest.API.Startup;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.RegisterDependencies();

        var app = builder.Build();

        app.ConfigureDependencies();

        app.Run();
    }
}

