using System;

namespace OMS.Challenge.Core.Models
{
    public class CreateActivityRequest
    {
        public int EmployeeId { get; set; }

        public byte ActivityTypeId { get; set; }

        public DateTime ActivityDate { get; set; }

        /// <summary>
        /// The distance traveled in km
        /// </summary>
        public double Distance { get; set; }

        public bool Validate()
        {
            //TODO: 9.1 Write some code to validate the date is not in the future and that the distance is not a negative number

            return true;
        }
    }
}
