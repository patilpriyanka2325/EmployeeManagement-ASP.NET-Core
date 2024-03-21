internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        //app.MapGet("/", () => System.Diagnostics.Process.GetCurrentProcess().ProcessName);

        //app.MapGet("/", () => "Hello World!");

        FileServerOptions options = new FileServerOptions();
        options.DefaultFilesOptions.DefaultFileNames.Clear();
        options.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
        app.UseFileServer(options);

        app.Run();
    }
}