using Microsoft.EntityFrameworkCore;
using ApplicationContext = kpo_lab_2.DataBase.ApplicationContext;

namespace kpo_lab_2;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var options = new DbContextOptionsBuilder<ApplicationContext>()
            .UseNpgsql("UserId=postgres;Password=aASDnqn1k_02;Host=localhost;Port=5434;Database=KPOlaba2;Encoding=UTF8;")
            .Options;
        
        using var context = new ApplicationContext(options);
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        
        AuthenticationAndRegistration authAndRegistration = new AuthenticationAndRegistration(context);
        if (authAndRegistration.ShowDialog() == DialogResult.OK)
        {
            Application.Run(new MainForm(context)); 
        }
    }
}