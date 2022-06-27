namespace EventManagement.DataAccess.Entities
{
    internal class Event : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int VenueId { get; set; }

        public int OrganizerId { get; set; }

        public int SpeakerId { get; set; }
    }
}