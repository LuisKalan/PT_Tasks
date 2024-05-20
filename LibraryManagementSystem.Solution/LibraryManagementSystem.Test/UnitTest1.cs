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
            // Crear una nueva instancia de LibraryData
            _libraryData = new LibraryData
            {
                CurrentState = new ProcessState() // Inicializar el estado actual para evitar valores nulos
                {
                    StateId = 1,
                    Description = "Initial State"
                },
                Users = new List<User>
                {
                    new User { UserId = 1, Name = "John Doe" }
                },
                Catalog = new Dictionary<int, CatalogItem>
                {
                    { 1, new CatalogItem { ItemId = 1, Name = "Book", Price = 10.99 } }
                },
                Events = new List<Event>
                {
                    new Event { EventId = 1, Description = "First Event" }
                }
            };

            // Pasar la instancia de LibraryData a LibraryLogic
            _libraryLogic = new LibraryLogic(_libraryData);
        }

        [TestMethod]
        public void AddUser_Should_AddUserToList()
        {
            var newUser = new User { UserId = 2, Name = "Jane Doe" };
            _libraryLogic.AddUser(newUser);

            Assert.AreEqual(2, _libraryData.Users.Count);
        }

        [TestMethod]
        public void AddCatalogItem_Should_AddItemToCatalog()
        {
            var newItem = new CatalogItem { ItemId = 2, Name = "Magazine", Price = 5.99 };
            _libraryLogic.AddCatalogItem(newItem);

            Assert.AreEqual(2, _libraryData.Catalog.Count);
        }

        [TestMethod]
        public void UpdateProcessState_Should_UpdateState()
        {
            var newState = new ProcessState { StateId = 2, Description = "Updated State" };
            _libraryLogic.UpdateProcessState(newState);

            Assert.AreEqual(newState, _libraryData.CurrentState);
        }

        [TestMethod]
        public void AddEvent_Should_AddEventToList()
        {
            var newEvent = new Event { EventId = 2, Description = "Second Event" };
            _libraryLogic.AddEvent(newEvent);

            Assert.AreEqual(2, _libraryData.Events.Count);
        }

        [TestMethod]
        public void CalculateTotalCatalogValue_Should_ReturnCorrectValue()
        {
            var newItem = new CatalogItem { ItemId = 2, Name = "Magazine", Price = 5.99 };
            _libraryLogic.AddCatalogItem(newItem);
            var totalValue = _libraryLogic.CalculateTotalCatalogValue();
            Assert.AreEqual(16.98, totalValue); // Suma de 10.99 + 5.99
        }
    }
}
