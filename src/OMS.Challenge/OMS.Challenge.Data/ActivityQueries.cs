using System.Threading.Tasks;
using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Interfaces.Queries;

namespace OMS.Challenge.Data;

public class ActivityQueries : IActivityQueries
{
    private readonly OMSChallengeContext _dbContext;

    public ActivityQueries(OMSChallengeContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<double> GetTotalDistance()
    {
        //TODO: 1. Calculate the total distance covered by all activities and return
        return 0;
    }

    public async Task<Employee> GetMostActiveEmployee()
    {
        //TODO: 2. Find the employee who recorded the greatest number of activities.
        //For the purposes of the activity if two employees have the same number of activities recorded just return the first one
        return null;
    }

    public async Task<Activity> CreateAsync(Activity activity)
    {
        await _dbContext.Activities.AddAsync(activity);

        await _dbContext.SaveChangesAsync();

        return activity;
    }
}