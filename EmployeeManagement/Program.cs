using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

        // Dependency Injection
        builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler();
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseStaticFiles();

        app.UseMvcWithDefaultRoute();

        app.Run();
    }
}