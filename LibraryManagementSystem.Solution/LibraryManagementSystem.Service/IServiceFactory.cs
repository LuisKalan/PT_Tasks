namespace LibraryManagementSystem.Service
{
    public interface IServiceFactory
    {
        IUserService CreateUserService();
        IGoodService CreateGoodService();
        IProcessStateService CreateProcessStateService();
    }
}
