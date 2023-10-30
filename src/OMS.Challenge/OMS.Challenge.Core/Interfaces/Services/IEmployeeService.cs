using System.Collections.Generic;
using System.Threading.Tasks;
using OMS.Challenge.Core.Entities;

namespace OMS.Challenge.Core.Interfaces.Services;

public interface IEmployeeService
{
    Task<IEnumerable<Employee>> GetEmployees();
}