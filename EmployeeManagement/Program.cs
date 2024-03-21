internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        //app.MapGet("/", () => System.Diagnostics.Process.GetCurrentProcess().ProcessName);

        app.MapGet("/", () => "Hello World!");

        app.UseFileServer();

        app.Run();
    }
}