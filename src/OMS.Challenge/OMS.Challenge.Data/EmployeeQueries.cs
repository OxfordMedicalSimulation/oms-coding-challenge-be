using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMS.Challenge.Core.Entities;

namespace OMS.Challenge.Data
{
    public class EmployeeQueries
    {
        private readonly IOMSChallengeContext _dbContext;

        public EmployeeQueries(IOMSChallengeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _dbContext.Employees.ToListAsync();
        }
    }
}
