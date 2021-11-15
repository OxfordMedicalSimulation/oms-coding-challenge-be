using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMS.Challenge.Core.Entities;

namespace OMS.Challenge.Data
{
    public class ActivityTypeQueries
    {
        private readonly IOMSChallengeContext _dbContext;

        public ActivityTypeQueries(IOMSChallengeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ActivityType>> GetActivityTypes()
        {
            return await _dbContext.ActivityTypes.ToListAsync();
        }
    }
}
