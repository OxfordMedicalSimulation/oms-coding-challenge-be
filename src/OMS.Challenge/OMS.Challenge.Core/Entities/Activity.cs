using System;

namespace OMS.Challenge.Core.Entities
{
    /// <summary>
    /// This class represents an activity an employee has recorded as part of the challenge
    /// </summary>
    //TODO: 6.  Create a base class for all entities to inherit from that contains the fields DateCreated (set to Now by default), DateUpdated, DateDeleted.
    //          We do not want developers to be able to create concrete instances of this class.
    //          Note: When you have done this it is easiest to delete the database file and restart the API. The database will be recreated with the new schema and 
    //          migrations are considered beyond the scope of this exercise.
    public class Activity
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public byte ActivityTypeId { get; set; }

        public DateTime ActivityDate { get; set; }

        /// <summary>
        /// The distance traveled in km
        /// </summary>
        public double Distance { get; set; }

        //Navigation Properties
        public Employee Employee { get; set; }

        public ActivityType ActivityType { get; set; }
    }
}
