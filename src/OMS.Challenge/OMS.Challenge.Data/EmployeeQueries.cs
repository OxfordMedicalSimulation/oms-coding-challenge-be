using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Interfaces.Queries;

namespace OMS.Challenge.Data;

public class EmployeeQueries : IEmployeeQueries
{
    private readonly OMSChallengeContext _dbContext;

    public EmployeeQueries(OMSChallengeContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Employee>> GetEmployees()
    {
        return await _dbContext.Employees.ToListAsync();
    }
}