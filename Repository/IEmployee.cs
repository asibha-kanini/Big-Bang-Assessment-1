using Big_Bang_Assessment_1.Model;

namespace Big_Bang_Assessment_1.Repository
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeesById(int EmployeeId);
        Employee PostEmployee(Employee employee);
        Employee PutEmployee(int EmployeeId, Employee employee);
        Employee DeleteEmployee(int EmployeeId);
    }
}
