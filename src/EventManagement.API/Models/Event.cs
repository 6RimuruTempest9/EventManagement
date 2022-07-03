namespace EventManagement.API.Models
{
    internal class Event
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Venue { get; set; }

        public string Organizer { get; set; }

        public string Speaker { get; set; }

        #endregion
    }
}