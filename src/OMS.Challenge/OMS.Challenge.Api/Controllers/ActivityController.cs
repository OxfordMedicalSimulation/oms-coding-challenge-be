using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Interfaces.Services;
using OMS.Challenge.Core.Models;
using OMS.Challenge.Data;

namespace OMS.Challenge.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ActivityController
{
    private readonly IActivityService _activityService;

    public ActivityController(IActivityService activityService)
    {
        _activityService = activityService;
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
        var employee = await _activityService.GetMostActiveEmployee();

        return new JsonResult(employee);
    }

    [HttpGet("TotalDistance")]
    public async Task<IActionResult> GetTotalDistance()
    {
        double totalDistance = await _activityService.GetTotalDistance();

        return new JsonResult(totalDistance);
    }

    /// <summary>
    /// This controller method is not as "skinny" as we would like but for the purposes of the challenge it is sufficient.
    /// </summary>
    [HttpPost]
    public async Task<IActionResult> Create(CreateActivityRequest request)
    {
        Activity activity = await _activityService.Create(request);

        return new JsonResult(activity);
    }
}