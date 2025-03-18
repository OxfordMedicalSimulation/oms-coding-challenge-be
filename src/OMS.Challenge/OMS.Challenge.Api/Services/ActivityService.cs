using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Interfaces.Queries;
using OMS.Challenge.Core.Interfaces.Services;
using OMS.Challenge.Core.Models;

namespace OMS.Challenge.Api.Services;

public class ActivityService : IActivityService
{
    private readonly IActivityQueries _activityQueries;
    
    public ActivityService(IActivityQueries activityQueries)
    {
        _activityQueries = activityQueries;
    }

    public Task<double> GetTotalDistance()
    {
        throw new NotImplementedException();
    }

    public Task<Employee> GetMostActiveEmployee()
    {
        throw new NotImplementedException();
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
        
        return await _activityQueries.CreateAsync(activity);
    }
}