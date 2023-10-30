using Microsoft.EntityFrameworkCore;
using OMS.Challenge.Core.Entities;

namespace OMS.Challenge.Data;

public class OMSChallengeContext : DbContext
{
    public DbSet<ActivityType> ActivityTypes { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<Activity> Activities { get; set; }

    public OMSChallengeContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>().HasData(DataSeeder.GetEmployees());
        modelBuilder.Entity<Employee>().ToTable("Employee");

        modelBuilder.Entity<ActivityType>().HasData(DataSeeder.GetActivityTypes());
        modelBuilder.Entity<ActivityType>().ToTable("ActivityType");

        modelBuilder.Entity<Activity>().HasData(DataSeeder.GetActivities());
        modelBuilder.Entity<Activity>().ToTable("Activity");
    }
}