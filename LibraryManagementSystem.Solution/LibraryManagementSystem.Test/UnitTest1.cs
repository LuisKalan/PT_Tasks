using LibraryManagementSystem.Data;
using LibraryManagementSystem.Logic;

namespace LibraryManagementSystem.Tests
{
    [TestClass]
    public class LibraryLogicTests
    {
        private LibraryData _libraryData;
        private LibraryLogic _libraryLogic;

        [TestInitialize]
        public void Setup()
        {
            _libraryData = new LibraryData
            {
                CurrentState = new ProcessState(), // Inicializar el estado actual para evitar valores nulos
                Users = new List<User>(), // Inicializar la lista de usuarios
                Catalog = new Dictionary<int, CatalogItem>(), // Inicializar el catálogo
                Events = new List<Event>() // Inicializar la lista de eventos
            };
            _libraryLogic = new LibraryLogic(_libraryData);
        }

        [TestMethod]
        public void AddUser_Should_AddUserToList()
        {
            var user = new User { UserId = 1, Name = "John Doe" };
            _libraryLogic.AddUser(user);
            Assert.AreEqual(1, _libraryData.Users.Count);
        }

        [TestMethod]
        public void AddCatalogItem_Should_AddItemToCatalog()
        {
            var item = new CatalogItem { ItemId = 1, Name = "Book", Price = 10.99 };
            _libraryLogic.AddCatalogItem(item);
            Assert.AreEqual(1, _libraryData.Catalog.Count);
        }

        [TestMethod]
        public void UpdateProcessState_Should_UpdateState()
        {
            var newState = new ProcessState { StateId = 1, Description = "New State" };
            _libraryLogic.UpdateProcessState(newState);
            Assert.AreEqual(newState, _libraryData.CurrentState);
        }

        [TestMethod]
        public void AddEvent_Should_AddEventToList()
        {
            var newEvent = new Event { EventId = 1, Description = "New Event" };
            _libraryLogic.AddEvent(newEvent);
            Assert.AreEqual(1, _libraryData.Events.Count);
        }

        [TestMethod]
        public void CalculateTotalCatalogValue_Should_ReturnCorrectValue()
        {
            _libraryLogic.AddCatalogItem(new CatalogItem { ItemId = 1, Name = "Book", Price = 10.99 });
            _libraryLogic.AddCatalogItem(new CatalogItem { ItemId = 2, Name = "DVD", Price = 15.99 });

            var totalValue = _libraryLogic.CalculateTotalCatalogValue();
            Assert.AreEqual(26.98, totalValue);
        }
    }
}
