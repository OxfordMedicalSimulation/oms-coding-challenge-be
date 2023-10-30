using System.Collections.Generic;
using System.Threading.Tasks;
using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Interfaces.Queries;
using OMS.Challenge.Core.Interfaces.Services;

namespace OMS.Challenge.Api.Services;

public class ActivityTypeService : IActivityTypeService
{
    private readonly IActivityTypeQueries _activityTypeQueries;
    
    public ActivityTypeService(IActivityTypeQueries activityTypeQueries)
    {
        _activityTypeQueries = activityTypeQueries;
    }

    public async Task<IEnumerable<ActivityType>> GetActivityTypes()
    {
        return await _activityTypeQueries.GetActivityTypes();
    }
}