using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Interfaces.Services;

namespace OMS.Challenge.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ActivityTypeController : ControllerBase
{
    private readonly IActivityTypeService _activityTypeService;
        
    public ActivityTypeController(IActivityTypeService activityTypeService)
    {
        _activityTypeService = activityTypeService;
    }

    [HttpGet]
    public async Task<IEnumerable<ActivityType>> Get()
    {
        return await _activityTypeService.GetActivityTypes();
    }

    //TODO: 7. (Number 6 must be completed first!). Create a method to soft delete an activity.
}