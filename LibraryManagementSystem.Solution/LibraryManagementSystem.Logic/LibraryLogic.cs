// Logic Layer

using LibraryManagementSystem.Data;

namespace LibraryManagementSystem.Logic
{
    public class LibraryLogic
    {
        private readonly ILibraryData _libraryData;

        public LibraryLogic(ILibraryData libraryData)
        {
            _libraryData = libraryData;
        }

        public void AddUser(User user)
        {
            _libraryData.Users.Add(user);
        }

        public void AddCatalogItem(CatalogItem item)
        {
            _libraryData.Catalog.Add(item.ItemId, item);
        }

        public void UpdateProcessState(ProcessState newState)
        {
            _libraryData.CurrentState = newState;
        }

        public void AddEvent(Event newEvent)
        {
            _libraryData.Events.Add(newEvent);
        }

        public double CalculateTotalCatalogValue()
        {
            return _libraryData.Catalog.Sum(item => item.Value.Price);
        }
    }
}
