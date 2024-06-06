using System;

namespace LibraryManagementSystem.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> UserRepository { get; }
        IRepository<Good> GoodRepository { get; }
        IRepository<Events> EventRepository { get; }
        IRepository<ProcessState> ProcessStateRepository { get; }
        void Save();
    }
}
