using ConsoleAppLibrary.BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ConsoleAppProj;


using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<App>().Run(args);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

static IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            services.AddSingleton<IMessages, Messages>();
            services.AddSingleton<App>();
        });
}
// ////////////////////////////////////////////////////////
//                    Comment Block                      //
// ////////////////////////////////////////////////////////
//       This program uses a CustomText.json file,       //
//       To sort and handle a language preference,       //
//       and to display a respecting Hello World         //
//       message to the console. This app also handles   //
//       dependency injection using nuget packages       //
// ////////////////////////////////////////////////////////
