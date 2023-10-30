using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Interfaces.Queries;

namespace OMS.Challenge.Data;

public class ActivityTypeQueries : IActivityTypeQueries
{
    private readonly OMSChallengeContext _dbContext;

    public ActivityTypeQueries(OMSChallengeContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<ActivityType>> GetActivityTypes()
    {
        return await _dbContext.ActivityTypes.ToListAsync();
    }
}