namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        //void Add(Employee employee);
    }
}
