// Data Layer

namespace LibraryManagementSystem.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
    }

    public class CatalogItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class ProcessState
    {
        public int StateId { get; set; }
        public string Description { get; set; }
    }

    public class Event
    {
        public int EventId { get; set; }
        public string Description { get; set; }
    }

    public class LibraryData
    {
        public List<User> Users { get; set; } = new List<User>();
        public Dictionary<int, CatalogItem> Catalog { get; set; } = new Dictionary<int, CatalogItem>();
        public ProcessState CurrentState { get; set; }
        public List<Event> Events { get; set; } = new List<Event>();
    }
}
