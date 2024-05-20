using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data
{
    public interface ILibraryData
    {
        List<User> Users { get; }
        Dictionary<int, CatalogItem> Catalog { get; }
        ProcessState CurrentState { get; set; }
        List<Event> Events { get; }
    }
}
