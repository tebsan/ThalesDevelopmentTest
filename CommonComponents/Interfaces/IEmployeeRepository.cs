using System.Threading.Tasks;

namespace CommonComponents.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<string> GetAllEmployees();
        Task<string> GetEmployeeById(int id);
    }
}
