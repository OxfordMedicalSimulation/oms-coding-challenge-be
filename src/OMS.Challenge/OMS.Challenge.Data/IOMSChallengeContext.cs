using Microsoft.EntityFrameworkCore;

using OMS.Challenge.Core.Entities;

namespace OMS.Challenge.Data
{
    public interface IOMSChallengeContext
    {
        DbSet<ActivityType> ActivityTypes { get; set; }

        DbSet<Employee> Employees { get; set; }

        DbSet<Activity> Activities { get; set; }
    }
}