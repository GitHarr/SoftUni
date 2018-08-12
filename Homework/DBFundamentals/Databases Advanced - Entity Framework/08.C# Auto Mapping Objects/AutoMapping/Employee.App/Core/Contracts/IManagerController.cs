namespace Employee.App.Core.Contracts
{
    using App.Core.DTOs;

    public interface IManagerController
    {
        void SetManager(int employeeId, int managerId);

        ManagerDto GetManagerInfo(int employeeId);
    }
}
