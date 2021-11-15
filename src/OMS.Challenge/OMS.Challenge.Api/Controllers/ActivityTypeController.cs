using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using OMS.Challenge.Core.Entities;
using OMS.Challenge.Data;

namespace OMS.Challenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityTypeController : ControllerBase
    {
        private readonly IDbContextFactory<OMSChallengeContext> _dbContextFactory;

        public ActivityTypeController(ILogger<ActivityTypeController> logger,
            IDbContextFactory<OMSChallengeContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        [HttpGet]
        public async Task<IEnumerable<ActivityType>> Get()
        {
            return await new ActivityTypeQueries(_dbContextFactory.CreateDbContext()).GetActivityTypes();
        }

        //TODO: 7. (Number 6 must be completed first!). Create a method to soft delete an activity.
    }
}