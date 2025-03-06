using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using OMS.Challenge.Api.Services;
using OMS.Challenge.Core.Interfaces.Queries;
using OMS.Challenge.Core.Interfaces.Services;
using OMS.Challenge.Data;

namespace OMS.Challenge.Api.Extensions;

public static class ServiceCollectionExtensions
{
    // This method gets called by the runtime. Use this method to add services to the container.
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "OMS.Challenge.Api", Version = "v1" });
            c.EnableAnnotations();
        });
        
        services.AddDbContext<OMSChallengeContext>(options => options.LogTo(Console.WriteLine, LogLevel.Information).UseSqlite("Data Source=OMSChallenge.db"));

        services.AddScoped<IEmployeeQueries, EmployeeQueries>();
        services.AddScoped<IActivityTypeQueries, ActivityTypeQueries>();
        services.AddScoped<IActivityQueries, ActivityQueries>();
        
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IActivityTypeService, ActivityTypeService>();
        services.AddScoped<IActivityService, ActivityService>();
    }
}