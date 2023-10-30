using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace OMS.Challenge.Api;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                //TODO: 5. A penetration test has been conducted and we must remove the kestrel server header.
                webBuilder.UseStartup<Startup>();
            });
}