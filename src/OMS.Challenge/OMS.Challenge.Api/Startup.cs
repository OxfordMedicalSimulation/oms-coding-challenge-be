using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using OMS.Challenge.Api.Services;

using OMS.Challenge.Core.Interfaces.Queries;
using OMS.Challenge.Core.Interfaces.Services;
using OMS.Challenge.Data;

namespace OMS.Challenge.Api;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "OMS.Challenge.Api", Version = "v1" });
        });
        
        services.AddDbContext<OMSChallengeContext>(options => options.UseSqlite("Data Source=OMSChallenge.db"));

        services.AddScoped<IEmployeeQueries, EmployeeQueries>();
        services.AddScoped<IActivityTypeQueries, ActivityTypeQueries>();
        services.AddScoped<IActivityQueries, ActivityQueries>();
        
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IActivityTypeService, ActivityTypeService>();
        services.AddScoped<IActivityService, ActivityService>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OMS.Challenge.Api v1"));
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}