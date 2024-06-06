using LibraryManagementSystem.Data;

namespace LibraryManagementSystem.Service
{
    public interface IProcessStateService
    {
        void AddProcessState(ProcessState processState);
        ProcessState GetProcessState(int id);
        void UpdateProcessState(ProcessState updatedProcessState, string eventType);
        void DeleteProcessState(int id);
    }
}
