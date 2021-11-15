using System;
using System.Collections.Generic;
using System.Linq;
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
    public class EmployeeController : ControllerBase
    {
        private readonly IDbContextFactory<OMSChallengeContext> _dbContextFactory;

        public EmployeeController(ILogger<ActivityTypeController> logger,
            IDbContextFactory<OMSChallengeContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Employee> employees = await new EmployeeQueries(_dbContextFactory.CreateDbContext()).GetEmployees();
            return new JsonResult(employees);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            //TODO: 4. Get the record by Id. If no record exists for the specified Id then return a http 404
            return new JsonResult(new Employee());
        }
    }
}
