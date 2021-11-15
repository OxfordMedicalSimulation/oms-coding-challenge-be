using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Models;
using OMS.Challenge.Data;

namespace OMS.Challenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityController
    {
        private readonly IDbContextFactory<OMSChallengeContext> _dbContextFactory;

        public ActivityController(IDbContextFactory<OMSChallengeContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var activities = new List<ActivityModel>();

            //TODO: 3. Get all activities in a flattened model including the name of the employee, activity title etc ordered by activity date (most recent first)

            return new JsonResult(activities);
        }

        [HttpGet("MostActiveEmployee")]
        public async Task<IActionResult> MostActiveEmployee()
        {
            var employee = await new ActivityQueries(_dbContextFactory.CreateDbContext()).GetMostActiveEmployee();

            return new JsonResult(employee);
        }

        [HttpGet("TotalDistance")]
        public async Task<IActionResult> GetTotalDistance()
        {
            decimal totalDistance = await new ActivityQueries(_dbContextFactory.CreateDbContext()).GetTotalDistance();

            return new JsonResult(totalDistance);
        }

        /// <summary>
        /// This controller method is not as "skinny" as we would like but for the purposes of the challenge it is sufficient.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create(CreateActivityRequest request)
        {
            var dbContext = _dbContextFactory.CreateDbContext();

            var activity = new Activity
            {
                EmployeeId = request.EmployeeId,
                ActivityTypeId = request.ActivityTypeId,
                ActivityDate = request.ActivityDate,
                Distance = request.Distance
            };

            await dbContext.Activities.AddAsync(activity);

            await dbContext.SaveChangesAsync();

            return new JsonResult(activity);
        }
    }
}
