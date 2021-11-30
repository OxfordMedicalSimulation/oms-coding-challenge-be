using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMS.Challenge.Core.Entities;

namespace OMS.Challenge.Data
{
    public class ActivityQueries
    {
        private readonly IOMSChallengeContext _dbContext;

        public ActivityQueries(IOMSChallengeContext dbContext)
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
    }
}
