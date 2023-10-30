using System.Collections.Generic;
using System.Threading.Tasks;
using OMS.Challenge.Core.Entities;

namespace OMS.Challenge.Core.Interfaces.Queries;

public interface IActivityTypeQueries
{
    Task<IEnumerable<ActivityType>> GetActivityTypes();
}