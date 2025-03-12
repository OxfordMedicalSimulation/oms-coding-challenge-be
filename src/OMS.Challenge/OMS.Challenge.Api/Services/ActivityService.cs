using System.Threading.Tasks;
using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Interfaces.Queries;
using OMS.Challenge.Core.Interfaces.Services;
using OMS.Challenge.Core.Models;
using OMS.Challenge.Data;

namespace OMS.Challenge.Api.Services;

public class ActivityService : IActivityService
{
    private readonly OMSChallengeContext _dbContext;

    private readonly IActivityQueries _activityQueries;
    
    public ActivityService(IActivityQueries activityQueries, OMSChallengeContext dbContext)
    {
        _dbContext = dbContext;
        _activityQueries = activityQueries;
    }

    public Task<double> GetTotalDistance()
    {
        throw new System.NotImplementedException();
    }

    public Task<Employee> GetMostActiveEmployee()
    {
        throw new System.NotImplementedException();
    }

    public async Task<Activity> Create(CreateActivityRequest request)
    {
        var activity = new Activity
        {
            EmployeeId = request.EmployeeId,
            ActivityTypeId = request.ActivityTypeId,
            ActivityDate = request.ActivityDate,
            Distance = request.Distance
        };

        await _dbContext.Activities.AddAsync(activity);

        await _dbContext.SaveChangesAsync();

        return activity;
    }
}