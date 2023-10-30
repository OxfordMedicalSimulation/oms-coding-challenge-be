using System.Collections.Generic;
using System.Threading.Tasks;
using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Interfaces.Queries;
using OMS.Challenge.Core.Interfaces.Services;

namespace OMS.Challenge.Api.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeQueries _employeeQueries;
    
    public EmployeeService(IEmployeeQueries employeeQueries)
    {
        _employeeQueries = employeeQueries;
    }
    
    public Task<IEnumerable<Employee>> GetEmployees()
    {
        return _employeeQueries.GetEmployees();
    }
}