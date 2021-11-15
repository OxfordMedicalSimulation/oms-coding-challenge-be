namespace OMS.Challenge.Core.Entities
{
    public class ActivityType
    {
        public byte Id { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
