using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Interfaces.Services;

namespace OMS.Challenge.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;
        
    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var employees = await _employeeService.GetEmployees();
        return Ok(employees);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int id)
    {
        //TODO: 4. Get the record using the injected EmployeeService by Id. If no record exists for the specified Id then return a http 404
        throw new NotImplementedException();
    }
}