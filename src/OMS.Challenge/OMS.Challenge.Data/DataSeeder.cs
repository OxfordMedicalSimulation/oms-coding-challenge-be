using System;
using System.Collections.Generic;

using OMS.Challenge.Core.Entities;

namespace OMS.Challenge.Data;

public static class DataSeeder
{
    public static IList<ActivityType> GetActivityTypes()
    {
        var activityTypes = new List<ActivityType>
        {
            new() {Id = 1, Title = "Walking"},
            new() {Id = 2, Title = "Running"},
            new() {Id = 3, Title = "Cycling"},
            new() {Id = 4, Title = "Swimming"},
            new() {Id = 5, Title = "Rowing"},
            new() {Id = 6, Title = "Kayaking"}
        };

        return activityTypes;
    }

    public static IList<Employee> GetEmployees()
    {
        var employees = new List<Employee>
        {
            new() {Id = 1, FirstName = "Mickey", LastName = "Mouse"},
            new() {Id = 2, FirstName = "Donald", LastName = "Duck"},
            new() {Id = 3, FirstName = "Marvin", LastName = "Martian"},
            new() {Id = 4, FirstName = "Elmer", LastName = "Fudd"},
            new() {Id = 5, FirstName = "Bugs", LastName = "Bunny"},
        };

        return employees;
    }

    public static IList<Activity> GetActivities()
    {
        var activities = new List<Activity>()
        {
            new () { Id = 1, EmployeeId = 1, ActivityTypeId = 2,  ActivityDate = new DateTime(2021, 11, 01), Distance = 5.5 },
            new () { Id = 2, EmployeeId = 1, ActivityTypeId = 2,  ActivityDate = new DateTime(2021, 11, 02), Distance = 5.9 },
            new () { Id = 3, EmployeeId = 1, ActivityTypeId = 2,  ActivityDate = new DateTime(2021, 12, 03), Distance = 5.6 },
            new () { Id = 4, EmployeeId = 1, ActivityTypeId = 2,  ActivityDate = new DateTime(2021, 12, 04), Distance = 5.6 },

            new () { Id = 5, EmployeeId = 2, ActivityTypeId = 3,  ActivityDate = new DateTime(2021, 12, 01), Distance = 16.8 },
            new () { Id = 6, EmployeeId = 2, ActivityTypeId = 4,  ActivityDate = new DateTime(2021, 12, 02), Distance = 10 },
            new () { Id = 7, EmployeeId = 2, ActivityTypeId = 3,  ActivityDate = new DateTime(2021, 12, 03), Distance = 16.5 },
            new () { Id = 8, EmployeeId = 2, ActivityTypeId = 3,  ActivityDate = new DateTime(2021, 12, 04), Distance = 16.5 },
            new () { Id = 9, EmployeeId = 2, ActivityTypeId = 3,  ActivityDate = new DateTime(2021, 12, 05), Distance = 16.9 },

            new () { Id = 10, EmployeeId = 3, ActivityTypeId = 4,  ActivityDate = new DateTime(2021, 12, 01), Distance = 1 },
            new () { Id = 11, EmployeeId = 3, ActivityTypeId = 4,  ActivityDate = new DateTime(2021, 12, 02), Distance = 1.1 },
            new () { Id = 12, EmployeeId = 3, ActivityTypeId = 6,  ActivityDate = new DateTime(2021, 12, 02), Distance = 8 },

        };

        return activities;
    }
}