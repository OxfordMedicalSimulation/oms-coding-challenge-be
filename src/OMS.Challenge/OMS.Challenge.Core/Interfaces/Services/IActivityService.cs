using System.Threading.Tasks;
using OMS.Challenge.Core.Entities;
using OMS.Challenge.Core.Models;

namespace OMS.Challenge.Core.Interfaces.Services;

public interface IActivityService
{
    Task<double> GetTotalDistance();

    Task<Employee> GetMostActiveEmployee();

    Task<Activity> Create(CreateActivityRequest request);
}