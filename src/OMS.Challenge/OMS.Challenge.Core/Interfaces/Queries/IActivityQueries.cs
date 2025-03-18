using System.Threading.Tasks;
using OMS.Challenge.Core.Entities;

namespace OMS.Challenge.Core.Interfaces.Queries;

public interface IActivityQueries
{
    Task<double> GetTotalDistance();

    Task<Employee> GetMostActiveEmployee();

    Task<Activity> CreateAsync(Activity activity);
}