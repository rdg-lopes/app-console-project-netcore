using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AppConsole.Persistence;
using AppConsole.Services;
using AppConsole.View;
using Microsoft.EntityFrameworkCore;

namespace AppConsole;

public class Program
{
    public static async Task<int> Main(string[] args)
    {
        System.Console.WriteLine("Configurando app...");
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
        builder.Services.AddScoped<IUserPersistence, UserPersistence>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<UserView>();
        builder.Services.AddDbContext<UserPersistence>(options => {
            options.UseSqlServer(builder.Configuration["ConnectionString"]);
        });
        var app = builder.Build();
        System.Console.WriteLine("Executando o app...");
        UserView view = app.Services.GetRequiredService<UserView>();
        await view.executarAsync();
        
        return 0;
    }
}



