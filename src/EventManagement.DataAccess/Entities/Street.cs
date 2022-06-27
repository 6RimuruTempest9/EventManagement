namespace EventManagement.DataAccess.Entities
{
    internal class Street : Entity
    {
        public int TownId { get; set; }

        public string Name { get; set; }
    }
}