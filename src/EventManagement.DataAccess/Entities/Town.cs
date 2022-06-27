namespace EventManagement.DataAccess.Entities
{
    internal class Town : Entity
    {
        public int CountryId { get; set; }

        public string Name { get; set; }
    }
}