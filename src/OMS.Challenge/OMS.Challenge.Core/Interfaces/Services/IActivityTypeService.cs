using System.Collections.Generic;
using System.Threading.Tasks;
using OMS.Challenge.Core.Entities;

namespace OMS.Challenge.Core.Interfaces.Services;

public interface IActivityTypeService
{
    Task<IEnumerable<ActivityType>> GetActivityTypes();
}