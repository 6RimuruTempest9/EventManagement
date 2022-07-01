namespace EventManagement.DataAccess.Entities
{
    internal class Event : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Venue { get; set; }

        public string Organizer { get; set; }

        public string Speaker { get; set; }
    }
}