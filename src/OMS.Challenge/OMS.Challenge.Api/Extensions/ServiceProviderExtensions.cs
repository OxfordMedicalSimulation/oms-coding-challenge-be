using Microsoft.EntityFrameworkCore;
using OMS.Challenge.Data;

namespace OMS.Challenge.Api.Extensions;

public static class ServiceProviderExtensions
{
    public static void RunMigrations(this IServiceProvider serviceProvider)
    {
        using var serviceScope = serviceProvider.CreateScope();
        var context = serviceScope.ServiceProvider.GetRequiredService<OMSChallengeContext>();
        context.Database.EnsureCreated();
        context.Database.Migrate();
    }
}